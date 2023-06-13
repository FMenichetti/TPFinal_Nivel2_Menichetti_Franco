using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPFinal_Nivel2
{
    public partial class Frm_Detalle_Productos : Form
    {
        Articulo articulo;
        public Frm_Detalle_Productos()
        {
            InitializeComponent();
        }
        public Frm_Detalle_Productos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void Frm_Detalle_Productos_Load(object sender, EventArgs e)
        {
            
            cargaDatos(articulo);
        }
        private void cargaDatos(Articulo articulo)
        {
            textBox1Nombre.Text = articulo.Nombre;
            textBox2Codigo.Text = articulo.Codigo;
            textBox4Descripcion.Text = articulo.Descripcion;
            textBox3Precio.Text = articulo.Precio.ToString();
            textBox6Marca.Text = articulo.Marca.Descripcion;
            textBox5Categoria.Text = articulo.Categoria.Descripcion;
            cargarImagen(articulo.Imagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
