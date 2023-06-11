using System;
using System.Linq;
using System.Windows.Forms;
using Yamy_Desktop.Models;

namespace Yamy_Desktop.Views
{
    public partial class ProductoEditarForm : Form
    {
        int idproducto;
        public ProductoEditarForm(ProductoDTO dataBoundItem)
        {
            InitializeComponent();

            using (baselaymarEntities DB = new baselaymarEntities())
            {
                idproducto = dataBoundItem.Id;
                producto product = DB.producto.Find(dataBoundItem.Id);

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
                text_PrecioUnitario.Text = "";
                text_Rentabilidad.Text = "100";
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
                        editar.nombre = text_Nombre.Text;
                        editar.descripcion = text_Descripcion.Text;
                        editar.talle = text_Talle.Text;
                        editar.color = text_Color.Text;
                        editar.marca = text_Marca.Text;
                        editar.ProveedorId = (int)combo_Proveedores.SelectedValue;
                        editar.precioUnitario = double.Parse(text_PrecioUnitario.Text);
                        editar.porcentajeRentabilidad = double.Parse(text_Rentabilidad.Text);
                        editar.fechaAlta = DateTime.Now;

                        int proximo = DB.Database.SqlQuery<int>("SELECT IDENT_CURRENT('producto') + IDENT_INCR('producto')").FirstOrDefault();
                        editar.codigo = proximo.ToString();

                        do
                        {
                            editar.codigo = "0" + editar.codigo;
                        } while (editar.codigo.Length<8);

                        DB.producto.Add(editar);
                        DB.SaveChanges();

                        MessageBox.Show("Producto Agregado correctamente");
                        this.Close();
                    }

                }
                else
                {
                    using (baselaymarEntities DB = new baselaymarEntities())
                    {
                        producto editar = DB.producto.Find(idproducto);
                        editar.nombre = text_Nombre.Text;
                        editar.descripcion = text_Descripcion.Text;
                        editar.talle = text_Talle.Text;
                        editar.color = text_Color.Text;
                        editar.marca = text_Marca.Text;
                        editar.ProveedorId = (int)combo_Proveedores.SelectedValue;
                        editar.precioUnitario = double.Parse(text_PrecioUnitario.Text);
                        editar.porcentajeRentabilidad = double.Parse(text_Rentabilidad.Text);

                        DB.SaveChanges();
                        MessageBox.Show("Producto Actualizado correctamente");
                        this.Close();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
