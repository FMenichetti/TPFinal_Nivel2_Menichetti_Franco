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
        Articulo articulo = null;
        public Frm_Nuevo_Modificar()
        {
            InitializeComponent();
            Text = "Cargar Nuevo";
        }
        public Frm_Nuevo_Modificar(Articulo articulo)//Constructor para modificar articulo
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void button1Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Cargar_Click(object sender, EventArgs e)
        {
            Articulo_Negocio negocio = new Articulo_Negocio();
            if (articulo == null)
            {
                articulo = new Articulo();
            }

            try
            {
                articulo.Precio = decimal.Parse(textBox5Precio.Text);
                articulo.Nombre = textBox1Nombre.Text;
                articulo.Descripcion = textBox3Descripcion.Text;
                articulo.Imagen = textBox4Url.Text;
                articulo.Codigo = textBox2Codigo.Text;
                articulo.Marca = (Marcas)comboBox2Marca.SelectedItem;
                articulo.Categoria = (Categoria)comboBox1Categoria.SelectedItem;
                if (datosNuevosCargados(articulo) == false)
                {
                    MessageBox.Show("Cargue todos los datos por favor");
                    return;
                }
                else
                {
                    if (articulo.Id != 0)
                    {

                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");

                    }
                    else
                    {
                        negocio.cargarNuevo(articulo);
                        MessageBox.Show("Cargado exitosamente");
                    }
                }

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo completar la operacion, intente cargando todos los valores. Caso contrario contacte a su developer");
            }
        }
        private bool datosNuevosCargados(Articulo articulo)
        {
            bool bandera = true;
            if (
            articulo.Nombre != "" &&
            articulo.Descripcion != "" &&
            articulo.Imagen != "" &&
            articulo.Codigo != "")
                bandera = true;
            else bandera = false;
            return bandera;
        }

        private void cargarValoresModificar(Articulo articulo)
        {
            try
            {
                textBox1Nombre.Text = articulo.Nombre;
                textBox2Codigo.Text = articulo.Codigo;
                textBox3Descripcion.Text = articulo.Descripcion;
                textBox4Url.Text = articulo.Imagen;
                comboBox1Categoria.SelectedValue = articulo.Categoria.Id;
                comboBox2Marca.SelectedValue = articulo.Marca.Id;
                cargarImagen(articulo.Imagen);

                textBox5Precio.Text = articulo.Precio.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema cargando los datos, por favor contacte a su desarrollador");
            }
        }
        private void Frm_Nuevo_Modificar_Load(object sender, EventArgs e)

        {
            Categoria_Negocio categoria = new Categoria_Negocio();
            Marcas_Negocio marca = new Marcas_Negocio();
            //Datos de los combobox
            try
            {
                comboBox1Categoria.DataSource = categoria.listaCategorias();
                comboBox1Categoria.ValueMember = "Id";
                comboBox1Categoria.DisplayMember = "Descripcion";
                comboBox2Marca.DataSource = marca.listaMarcas();
                comboBox2Marca.ValueMember = "Id";
                comboBox2Marca.DisplayMember = "Descripcion";


                if (articulo != null)
                    cargarValoresModificar(articulo);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un problema, por favor contacte a su developer");
            }
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1Imagen.Load(imagen);
            }
            catch (Exception)
            {

                pictureBox1Imagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void textBox4Url_Leave(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(textBox4Url.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, contacte a su desarrollador");
            }
        }

        private void textBox5Precio_KeyPress(object sender, KeyPressEventArgs e)//filtro de Keypress para solo numeros y coma
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }


    }
}
