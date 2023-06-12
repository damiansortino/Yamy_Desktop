
namespace Yamy_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_VerTodos = new System.Windows.Forms.Button();
            this.btn_UltimosCargados = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rb_Codigo = new System.Windows.Forms.RadioButton();
            this.rb_Marca = new System.Windows.Forms.RadioButton();
            this.rb_Nombre = new System.Windows.Forms.RadioButton();
            this.btn_EditSeleccionado = new System.Windows.Forms.Button();
            this.btn_ElimProducto = new System.Windows.Forms.Button();
            this.btn_NuevoProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_okSearch = new System.Windows.Forms.Button();
            this.lbl_PrecioProducto = new System.Windows.Forms.Label();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1276, 493);
            this.dgv.TabIndex = 0;
            this.dgv.Leave += new System.EventHandler(this.dgv_Leave);
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // btn_VerTodos
            // 
            this.btn_VerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerTodos.Location = new System.Drawing.Point(12, 113);
            this.btn_VerTodos.Name = "btn_VerTodos";
            this.btn_VerTodos.Size = new System.Drawing.Size(162, 54);
            this.btn_VerTodos.TabIndex = 1;
            this.btn_VerTodos.Text = "Ver Todos";
            this.btn_VerTodos.UseVisualStyleBackColor = true;
            this.btn_VerTodos.Click += new System.EventHandler(this.btn_VerTodos_Click);
            // 
            // btn_UltimosCargados
            // 
            this.btn_UltimosCargados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UltimosCargados.Location = new System.Drawing.Point(180, 113);
            this.btn_UltimosCargados.Name = "btn_UltimosCargados";
            this.btn_UltimosCargados.Size = new System.Drawing.Size(162, 54);
            this.btn_UltimosCargados.TabIndex = 2;
            this.btn_UltimosCargados.Text = "Ultimos Cargados";
            this.btn_UltimosCargados.UseVisualStyleBackColor = true;
            this.btn_UltimosCargados.Click += new System.EventHandler(this.btn_UltimosCargados_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(375, 132);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(271, 26);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // rb_Codigo
            // 
            this.rb_Codigo.AutoSize = true;
            this.rb_Codigo.Checked = true;
            this.rb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Codigo.Location = new System.Drawing.Point(375, 93);
            this.rb_Codigo.Name = "rb_Codigo";
            this.rb_Codigo.Size = new System.Drawing.Size(77, 24);
            this.rb_Codigo.TabIndex = 6;
            this.rb_Codigo.TabStop = true;
            this.rb_Codigo.Text = "Código";
            this.rb_Codigo.UseVisualStyleBackColor = true;
            // 
            // rb_Marca
            // 
            this.rb_Marca.AutoSize = true;
            this.rb_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Marca.Location = new System.Drawing.Point(482, 93);
            this.rb_Marca.Name = "rb_Marca";
            this.rb_Marca.Size = new System.Drawing.Size(71, 24);
            this.rb_Marca.TabIndex = 7;
            this.rb_Marca.TabStop = true;
            this.rb_Marca.Text = "Marca";
            this.rb_Marca.UseVisualStyleBackColor = true;
            // 
            // rb_Nombre
            // 
            this.rb_Nombre.AutoSize = true;
            this.rb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nombre.Location = new System.Drawing.Point(578, 93);
            this.rb_Nombre.Name = "rb_Nombre";
            this.rb_Nombre.Size = new System.Drawing.Size(83, 24);
            this.rb_Nombre.TabIndex = 8;
            this.rb_Nombre.TabStop = true;
            this.rb_Nombre.Text = "Nombre";
            this.rb_Nombre.UseVisualStyleBackColor = true;
            // 
            // btn_EditSeleccionado
            // 
            this.btn_EditSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EditSeleccionado.Enabled = false;
            this.btn_EditSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditSeleccionado.Location = new System.Drawing.Point(748, 29);
            this.btn_EditSeleccionado.Name = "btn_EditSeleccionado";
            this.btn_EditSeleccionado.Size = new System.Drawing.Size(173, 44);
            this.btn_EditSeleccionado.TabIndex = 9;
            this.btn_EditSeleccionado.Text = "Editar Seleccionado";
            this.btn_EditSeleccionado.UseVisualStyleBackColor = false;
            this.btn_EditSeleccionado.Click += new System.EventHandler(this.btn_EditSeleccionado_Click);
            // 
            // btn_ElimProducto
            // 
            this.btn_ElimProducto.BackColor = System.Drawing.Color.Salmon;
            this.btn_ElimProducto.Enabled = false;
            this.btn_ElimProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ElimProducto.Location = new System.Drawing.Point(748, 79);
            this.btn_ElimProducto.Name = "btn_ElimProducto";
            this.btn_ElimProducto.Size = new System.Drawing.Size(173, 44);
            this.btn_ElimProducto.TabIndex = 10;
            this.btn_ElimProducto.Text = "Eliminar Seleccionado";
            this.btn_ElimProducto.UseVisualStyleBackColor = false;
            this.btn_ElimProducto.Click += new System.EventHandler(this.btn_ElimProducto_Click);
            // 
            // btn_NuevoProducto
            // 
            this.btn_NuevoProducto.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_NuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoProducto.Location = new System.Drawing.Point(748, 129);
            this.btn_NuevoProducto.Name = "btn_NuevoProducto";
            this.btn_NuevoProducto.Size = new System.Drawing.Size(173, 44);
            this.btn_NuevoProducto.TabIndex = 11;
            this.btn_NuevoProducto.Text = "Nuevo Producto";
            this.btn_NuevoProducto.UseVisualStyleBackColor = false;
            this.btn_NuevoProducto.Click += new System.EventHandler(this.btn_NuevoProducto_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nueva Venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.AutoSize = true;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Image = global::Yamy_Desktop.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(1231, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(39, 39);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.AutoSize = true;
            this.btn_Min.BackgroundImage = global::Yamy_Desktop.Properties.Resources.minimize;
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Min.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Min.Location = new System.Drawing.Point(1186, 12);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(39, 39);
            this.btn_Min.TabIndex = 13;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_okSearch
            // 
            this.btn_okSearch.AutoSize = true;
            this.btn_okSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okSearch.Image = global::Yamy_Desktop.Properties.Resources.ok;
            this.btn_okSearch.Location = new System.Drawing.Point(665, 118);
            this.btn_okSearch.Name = "btn_okSearch";
            this.btn_okSearch.Size = new System.Drawing.Size(40, 40);
            this.btn_okSearch.TabIndex = 5;
            this.btn_okSearch.UseVisualStyleBackColor = true;
            this.btn_okSearch.Click += new System.EventHandler(this.btn_okSearch_Click);
            // 
            // lbl_PrecioProducto
            // 
            this.lbl_PrecioProducto.AutoSize = true;
            this.lbl_PrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioProducto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_PrecioProducto.Location = new System.Drawing.Point(968, 102);
            this.lbl_PrecioProducto.Name = "lbl_PrecioProducto";
            this.lbl_PrecioProducto.Size = new System.Drawing.Size(66, 55);
            this.lbl_PrecioProducto.TabIndex = 14;
            this.lbl_PrecioProducto.Text = "$ ";
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.Location = new System.Drawing.Point(338, 53);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(367, 20);
            this.lbl_aviso.TabIndex = 15;
            this.lbl_aviso.Text = "Presione \"Ver Todos\" antes de buscar un producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1282, 691);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.lbl_PrecioProducto);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_NuevoProducto);
            this.Controls.Add(this.btn_ElimProducto);
            this.Controls.Add(this.btn_EditSeleccionado);
            this.Controls.Add(this.rb_Nombre);
            this.Controls.Add(this.rb_Marca);
            this.Controls.Add(this.rb_Codigo);
            this.Controls.Add(this.btn_okSearch);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_UltimosCargados);
            this.Controls.Add(this.btn_VerTodos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yamy";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_VerTodos;
        private System.Windows.Forms.Button btn_UltimosCargados;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btn_okSearch;
        private System.Windows.Forms.RadioButton rb_Codigo;
        private System.Windows.Forms.RadioButton rb_Marca;
        private System.Windows.Forms.RadioButton rb_Nombre;
        private System.Windows.Forms.Button btn_EditSeleccionado;
        private System.Windows.Forms.Button btn_ElimProducto;
        private System.Windows.Forms.Button btn_NuevoProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Label lbl_PrecioProducto;
        private System.Windows.Forms.Label lbl_aviso;
    }
}

