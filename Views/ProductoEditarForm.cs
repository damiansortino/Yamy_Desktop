using System;
using System.Linq;
using System.Windows.Forms;
using Yamy_Desktop.Models;

namespace Yamy_Desktop.Views
{
    public partial class ProductoEditarForm : Form
    {
        int idproducto;
        int idstock;
        public ProductoEditarForm(ProductoDTO dataBoundItem)
        {
            InitializeComponent();

            using (baselaymarEntities DB = new baselaymarEntities())
            {
                idproducto = dataBoundItem.Id;
                idstock = DB.stock.ToList().Find(x => x.ProductoId == idproducto).StockId;

                producto product = DB.producto.Find(dataBoundItem.Id);

                stock stockproducto = DB.stock.ToList().Find(x => x.ProductoId == idproducto);

                combo_Proveedores.DataSource = DB.personaJuridica.ToList().FindAll(x => x.Discriminator == "Proveedor" && x.fechaBaja == null);
                combo_Proveedores.DisplayMember = "razonSocial";
                combo_Proveedores.ValueMember = "PersonaJuridicaId";
                combo_Proveedores.SelectedValue = product.ProveedorId;
                lbl_Codigo.Text = product.codigo;

                text_Nombre.Text = product.nombre;
                text_Descripcion.Text = product.descripcion;
                lblFechaCreacion.Text = product.fechaAlta.ToString();
                text_Talle.Text = product.talle;
                text_Color.Text = product.color;
                text_Marca.Text = product.marca;
                text_PrecioUnitario.Text = product.precioUnitario.ToString();
                text_Rentabilidad.Text = product.porcentajeRentabilidad.ToString();
                lbl_PrecioFinal.Text = "$ " + ((int)Math.Ceiling(product.precioUnitario +
                    ((product.precioUnitario * product.porcentajeRentabilidad) / 100))).ToString();
            }
        }
        public ProductoEditarForm()
        {
            InitializeComponent();

            using (baselaymarEntities DB = new baselaymarEntities())
            {
                idproducto = 0;

                combo_Proveedores.DataSource = DB.personaJuridica.ToList().FindAll(x => x.Discriminator == "Proveedor" && x.fechaBaja == null);
                combo_Proveedores.DisplayMember = "razonSocial";
                combo_Proveedores.ValueMember = "PersonaJuridicaId";
                lbl_Codigo.Text = "";

                text_Nombre.Text = "";
                text_Descripcion.Text = "";
                lblFechaCreacion.Text = DateTime.Now.ToString();
                text_Talle.Text = "";
                text_Color.Text = "";
                text_Marca.Text = "";
                text_PrecioUnitario.Text = "0";
                text_Rentabilidad.Text = DB.personaJuridica.Find((int)combo_Proveedores.SelectedValue).porcentajeRentabilidad.ToString();
                lbl_PrecioFinal.Text = "$ 0";
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                decimal unitario, rentabilidad, total;
                unitario = decimal.Parse(text_PrecioUnitario.Text.Trim());
                rentabilidad = decimal.Parse(text_Rentabilidad.Text.Trim());
                total = (int)Math.Ceiling(unitario + ((unitario * rentabilidad) / 100));
                lbl_PrecioFinal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btn Refresh \n" + ex.Message);

            }
        }

        private void text_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_Refresh.PerformClick();
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void text_Rentabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_Refresh.PerformClick();
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (idproducto == 0)
                {
                    using (baselaymarEntities DB = new baselaymarEntities())
                    {
                        producto editar = new producto();
                        editar.nombre = text_Nombre.Text.ToUpper();
                        editar.descripcion = text_Descripcion.Text.ToUpper();
                        editar.talle = text_Talle.Text.ToUpper();
                        editar.color = text_Color.Text.ToUpper();
                        editar.marca = text_Marca.Text.ToUpper();
                        editar.ProveedorId = (int)combo_Proveedores.SelectedValue;
                        editar.precioUnitario = double.Parse(text_PrecioUnitario.Text);
                        editar.porcentajeRentabilidad = double.Parse(text_Rentabilidad.Text);
                        editar.fechaAlta = DateTime.Now;
                        DB.producto.Add(editar);
                        DB.SaveChanges();

                        editar.codigo = editar.ProductoId.ToString();
                        do
                        {
                            editar.codigo = "0" + editar.codigo;
                        } while (editar.codigo.Length < 8);

                        DB.Entry(editar).State = System.Data.Entity.EntityState.Modified;

                        DB.SaveChanges();

                        foreach (sucursal item in DB.sucursal.ToList().FindAll(x => x.fechaBaja == null))
                        {
                            //crer el stock
                            stock nuevo = new stock();
                            nuevo.ProductoId = editar.ProductoId;
                            nuevo.cantidad = 0;
                            nuevo.SucursalId = item.SucursalId;

                            DB.stock.Add(nuevo);
                            DB.SaveChanges();

                            //crear el movimiento de stock de carga inicial

                            movimientoStock movstock = new movimientoStock();
                            movstock.cantidad = 0;
                            movstock.entra = true;
                            movstock.sale = false;
                            movstock.fechaAlta = DateTime.Now;
                            movstock.StockId = nuevo.StockId;
                            movstock.TipoMovimientoStockId = 1;
                            DB.movimientoStock.Add(movstock);
                            DB.SaveChanges();

                        }

                        MessageBox.Show("Producto Agregado correctamente");
                        this.Close();
                    }

                }
                else
                {
                    using (baselaymarEntities DB = new baselaymarEntities())
                    {
                        producto editar = DB.producto.Find(idproducto);
                        editar.nombre = text_Nombre.Text.ToUpper();
                        editar.descripcion = text_Descripcion.Text.ToUpper();
                        editar.talle = text_Talle.Text.ToUpper();
                        editar.color = text_Color.Text.ToUpper();
                        editar.marca = text_Marca.Text.ToUpper();
                        editar.ProveedorId = (int)combo_Proveedores.SelectedValue;
                        editar.precioUnitario = double.Parse(text_PrecioUnitario.Text);
                        editar.porcentajeRentabilidad = double.Parse(text_Rentabilidad.Text);

                        DB.SaveChanges();
                        MessageBox.Show("Producto Actualizado correctamente");
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando producto \n" + ex.Message);
            }
        }

        private void combo_Proveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    personaJuridica proveedor = (personaJuridica)combo_Proveedores.SelectedItem;

                    text_Rentabilidad.Text = proveedor.porcentajeRentabilidad.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
