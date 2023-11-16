using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yamy_Desktop.Models;

namespace Yamy_Desktop.Views
{
    public partial class ProductoAjustarStockForm : Form
    {
        int id = 0;
        public ProductoAjustarStockForm()
        {
            InitializeComponent();
        }
        public ProductoAjustarStockForm(int idproducto)
        {
            InitializeComponent();
            id = idproducto;
            Llenarlabels();
        }

        private void Llenarlabels()
        {
            try
            {
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    producto producto = DB.producto.Find(id);

                    lblCodigo.Text = producto.codigo;
                    lblNombre.Text = producto.nombre;
                    lblDescripcion.Text = producto.descripcion;
                    lblMarca.Text = producto.marca;
                    lblTalle.Text = producto.talle;
                    lblColor.Text = producto.color;
                    lb
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error abriendo el producto para modificar stock \n"+ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoAjustarStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
