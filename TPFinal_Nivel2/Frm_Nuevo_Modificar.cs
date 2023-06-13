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
    public partial class Frm_Nuevo_Modificar : Form
    {
        public Frm_Nuevo_Modificar()
        {
            InitializeComponent();
        }

        private void button1Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Cargar_Click(object sender, EventArgs e)//no puedo convertir el string a marca
        {
            Articulo_Negocio nuevo = new Articulo_Negocio();
            Articulo aux = new Articulo();
            aux.Codigo = textBox2Codigo.Text;
            aux.Nombre = textBox1Nombre.Text;
            aux.Descripcion = textBox3Descripcion.Text;
            aux.Imagen = textBox4Url.Text;
            aux.Precio = int.Parse(textBox5Precio.Text);
            aux.Marca = (Marcas)comboBox2Marca.SelectedItem;
            aux.Categoria = (Categoria)comboBox2Marca.SelectedItem;
            nuevo.cargarNuevo(aux);

        }
        private void cargar()
        {

        }
        private void modificar()
        {

        }

        private void Frm_Nuevo_Modificar_Load(object sender, EventArgs e)

        {
            Articulo_Negocio negocio = new Articulo_Negocio();


            comboBox1Categoria.DataSource = negocio.listaCategorias();
            comboBox1Categoria.ValueMember = "Id";
            comboBox1Categoria.DisplayMember = "Categoria";

            comboBox2Marca.DataSource = negocio.listar();
            comboBox2Marca.ValueMember = "IdMarca";
            comboBox2Marca.DisplayMember = "Marca";

        }
    }
}
