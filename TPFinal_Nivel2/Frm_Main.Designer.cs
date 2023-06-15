
namespace TPFinal_Nivel2
{
    partial class Frm_Main
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
            System.Windows.Forms.Label label1Titulo;
            this.button2AgregarProducto = new System.Windows.Forms.Button();
            this.button3ModificarProducto = new System.Windows.Forms.Button();
            this.label1digiteFiltro = new System.Windows.Forms.Label();
            this.textBox1Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1Filtrar = new System.Windows.Forms.Button();
            this.comboBox1Categorias = new System.Windows.Forms.ComboBox();
            this.comboBox2Marcas = new System.Windows.Forms.ComboBox();
            this.button1Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1ImagenLogo = new System.Windows.Forms.PictureBox();
            label1Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ImagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Titulo
            // 
            label1Titulo.AutoSize = true;
            label1Titulo.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1Titulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1Titulo.Location = new System.Drawing.Point(24, 17);
            label1Titulo.Name = "label1Titulo";
            label1Titulo.Size = new System.Drawing.Size(158, 34);
            label1Titulo.TabIndex = 0;
            label1Titulo.Text = "Store Room";
            label1Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2AgregarProducto
            // 
            this.button2AgregarProducto.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2AgregarProducto.Location = new System.Drawing.Point(14, 177);
            this.button2AgregarProducto.Name = "button2AgregarProducto";
            this.button2AgregarProducto.Size = new System.Drawing.Size(188, 52);
            this.button2AgregarProducto.TabIndex = 2;
            this.button2AgregarProducto.Text = "Agregar producto";
            this.button2AgregarProducto.UseVisualStyleBackColor = true;
            this.button2AgregarProducto.Click += new System.EventHandler(this.button2AgregarProducto_Click);
            // 
            // button3ModificarProducto
            // 
            this.button3ModificarProducto.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3ModificarProducto.Location = new System.Drawing.Point(14, 265);
            this.button3ModificarProducto.Name = "button3ModificarProducto";
            this.button3ModificarProducto.Size = new System.Drawing.Size(188, 52);
            this.button3ModificarProducto.TabIndex = 3;
            this.button3ModificarProducto.Text = "Modificar producto";
            this.button3ModificarProducto.UseVisualStyleBackColor = true;
            this.button3ModificarProducto.Click += new System.EventHandler(this.button3ModificarProducto_Click);
            // 
            // label1digiteFiltro
            // 
            this.label1digiteFiltro.AutoSize = true;
            this.label1digiteFiltro.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label1digiteFiltro.Location = new System.Drawing.Point(455, 28);
            this.label1digiteFiltro.Name = "label1digiteFiltro";
            this.label1digiteFiltro.Size = new System.Drawing.Size(168, 19);
            this.label1digiteFiltro.TabIndex = 11;
            this.label1digiteFiltro.Text = "¿Que estas buscando..?";
            // 
            // textBox1Buscar
            // 
            this.textBox1Buscar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Buscar.Location = new System.Drawing.Point(263, 62);
            this.textBox1Buscar.Name = "textBox1Buscar";
            this.textBox1Buscar.Size = new System.Drawing.Size(543, 22);
            this.textBox1Buscar.TabIndex = 12;
            this.textBox1Buscar.Click += new System.EventHandler(this.textBox1Buscar_Click);
            this.textBox1Buscar.TextChanged += new System.EventHandler(this.textBox1Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10F);
            this.label1.Location = new System.Drawing.Point(330, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marcas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10F);
            this.label2.Location = new System.Drawing.Point(515, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categorias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(263, 178);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 271);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1Filtrar
            // 
            this.button1Filtrar.Font = new System.Drawing.Font("Gadugi", 10F);
            this.button1Filtrar.Location = new System.Drawing.Point(660, 109);
            this.button1Filtrar.Name = "button1Filtrar";
            this.button1Filtrar.Size = new System.Drawing.Size(146, 41);
            this.button1Filtrar.TabIndex = 24;
            this.button1Filtrar.Text = "Filtrar";
            this.button1Filtrar.UseVisualStyleBackColor = true;
            this.button1Filtrar.Click += new System.EventHandler(this.button1Filtrar_Click);
            // 
            // comboBox1Categorias
            // 
            this.comboBox1Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Categorias.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Categorias.FormattingEnabled = true;
            this.comboBox1Categorias.Location = new System.Drawing.Point(477, 128);
            this.comboBox1Categorias.Name = "comboBox1Categorias";
            this.comboBox1Categorias.Size = new System.Drawing.Size(146, 22);
            this.comboBox1Categorias.TabIndex = 25;
            this.comboBox1Categorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1Categorias_SelectedIndexChanged);
            // 
            // comboBox2Marcas
            // 
            this.comboBox2Marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2Marcas.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2Marcas.FormattingEnabled = true;
            this.comboBox2Marcas.Location = new System.Drawing.Point(280, 128);
            this.comboBox2Marcas.Name = "comboBox2Marcas";
            this.comboBox2Marcas.Size = new System.Drawing.Size(146, 22);
            this.comboBox2Marcas.TabIndex = 26;
            this.comboBox2Marcas.SelectedIndexChanged += new System.EventHandler(this.comboBox2Marcas_SelectedIndexChanged);
            // 
            // button1Eliminar
            // 
            this.button1Eliminar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Eliminar.Location = new System.Drawing.Point(14, 353);
            this.button1Eliminar.Name = "button1Eliminar";
            this.button1Eliminar.Size = new System.Drawing.Size(188, 52);
            this.button1Eliminar.TabIndex = 27;
            this.button1Eliminar.Text = "Eliminar";
            this.button1Eliminar.UseVisualStyleBackColor = true;
            this.button1Eliminar.Click += new System.EventHandler(this.button1Eliminar_Click);
            // 
            // pictureBox1ImagenLogo
            // 
            this.pictureBox1ImagenLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1ImagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1ImagenLogo.Location = new System.Drawing.Point(14, 49);
            this.pictureBox1ImagenLogo.Name = "pictureBox1ImagenLogo";
            this.pictureBox1ImagenLogo.Size = new System.Drawing.Size(188, 122);
            this.pictureBox1ImagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1ImagenLogo.TabIndex = 28;
            this.pictureBox1ImagenLogo.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1Eliminar);
            this.Controls.Add(this.comboBox2Marcas);
            this.Controls.Add(this.comboBox1Categorias);
            this.Controls.Add(this.button1Filtrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Buscar);
            this.Controls.Add(this.label1digiteFiltro);
            this.Controls.Add(this.button3ModificarProducto);
            this.Controls.Add(this.button2AgregarProducto);
            this.Controls.Add(label1Titulo);
            this.Controls.Add(this.pictureBox1ImagenLogo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ImagenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2AgregarProducto;
        private System.Windows.Forms.Button button3ModificarProducto;
        private System.Windows.Forms.Label label1digiteFiltro;
        private System.Windows.Forms.TextBox textBox1Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1Filtrar;
        private System.Windows.Forms.ComboBox comboBox1Categorias;
        private System.Windows.Forms.ComboBox comboBox2Marcas;
        private System.Windows.Forms.Button button1Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1ImagenLogo;
    }
}

