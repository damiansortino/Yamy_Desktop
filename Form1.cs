using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Yamy_Desktop.Models;
using Yamy_Desktop.Views;

namespace Yamy_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_VerTodos_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = ProductosDGV("todos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cargando todos los productos \n" + ex.Message);
            }
        }

        private List<ProductoDTO> ProductosDGV(string filtro)
        {
            try
            {
                List<ProductoDTO> lista = new List<ProductoDTO>();
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    if (filtro == "todos")
                    {
                        var query = from a in DB.producto
                                    where a.fechaBaja == null
                                    select new ProductoDTO
                                    {
                                        Id = a.ProductoId,
                                        Codigo = a.codigo,
                                        Nombre = a.nombre,
                                        Descripcion = a.descripcion,
                                        PrecioUnit = a.precioUnitario,
                                        Rentabilidad = a.porcentajeRentabilidad,
                                        Precio = (int)Math.Ceiling(a.precioUnitario + ((a.precioUnitario * a.porcentajeRentabilidad) / 100)),
                                        Talle = a.talle,
                                        Color = a.color,
                                        Marca = a.marca
                                    };

                        lista = query.ToList();
                    }
                    else if (filtro == "ultimos")
                    {
                        DateTime menoscien = DateTime.Now.Date.AddDays(-60);

                        var query = from a in DB.producto
                                    where a.fechaBaja == null && a.fechaAlta >= menoscien
                                    select new ProductoDTO
                                    {
                                        Id = a.ProductoId,
                                        Codigo = a.codigo,
                                        Nombre = a.nombre,
                                        Descripcion = a.descripcion,
                                        PrecioUnit = a.precioUnitario,
                                        Rentabilidad = a.porcentajeRentabilidad,
                                        Precio = (int)Math.Ceiling(a.precioUnitario + ((a.precioUnitario * a.porcentajeRentabilidad) / 100)),
                                        Talle = a.talle,
                                        Color = a.color,
                                        Marca = a.marca
                                    };

                        lista = query.ToList();
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void btn_UltimosCargados_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = ProductosDGV("ultimos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cargando ultimos productos \n" + ex.Message);
            }

        }

        private void btn_okSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                string columna = "";

                if (rb_Codigo.Checked)
                {
                    columna = "Codigo";
                }
                else if (rb_Marca.Checked)
                {
                    columna = "Marca";
                }
                else if (rb_Nombre.Checked)
                {
                    columna = "Nombre";
                }

                List<ProductoDTO> productosFiltrados = new List<ProductoDTO>();

                if (!string.IsNullOrEmpty(columna))
                {
                    productosFiltrados = ((List<ProductoDTO>)dgv.DataSource)
                        .Where(p => GetPropertyValue(p, columna)?.ToString()?.ToUpper()?.Trim()?.Contains(filtro.ToUpper().Trim()) == true)
                        .ToList();
                }
                else
                {
                    productosFiltrados = ((List<ProductoDTO>)dgv.DataSource);
                }

                dgv.DataSource = null;
                dgv.DataSource = productosFiltrados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_okSearch.PerformClick();
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error textbox filtro \n" + ex.Message);
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditSeleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEditarForm form = new ProductoEditarForm((ProductoDTO)dgv.CurrentRow.DataBoundItem);
                form.ShowDialog();
                btn_VerTodos.PerformClick();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
        }

        private void btn_ElimProducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    producto eliminar = DB.producto.Find(((ProductoDTO)dgv.CurrentRow.DataBoundItem).Id);
                    eliminar.fechaBaja = DateTime.Now;
                    DB.SaveChanges();
                    MessageBox.Show("El producto ha sido eliminado");
                    btn_VerTodos.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Eliminando producto \n" + ex.Message);
            }
        }

        private void btn_NuevoProducto_Click(object sender, EventArgs e)
        {
            ProductoEditarForm nuevo = new ProductoEditarForm();
            nuevo.ShowDialog();
            btn_VerTodos.PerformClick();

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
