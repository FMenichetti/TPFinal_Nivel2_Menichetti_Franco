using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPFinal_Nivel2
{
    public partial class Frm_Main : Form
    {
        List<Articulo> listaArticulo = new List<Articulo>();

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1VerStock_Click(object sender, EventArgs e)
        {
            Frm_Filtros_Busqueda busqueda = new Frm_Filtros_Busqueda();
            busqueda.Show();
        }

        private void button2AgregarProducto_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Modificar agregar = new Frm_Nuevo_Modificar();
            agregar.Show();
        }

        private void button3ModificarProducto_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Modificar modificar = new Frm_Nuevo_Modificar();
            modificar.Show();

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

            comboBox1Categorias.Items.Add("Celulares");
            comboBox1Categorias.Items.Add("Televisores");
            comboBox1Categorias.Items.Add("Media");
            comboBox1Categorias.Items.Add("Audio");
            comboBox2Marcas.Items.Add("Samsung");
            comboBox2Marcas.Items.Add("Apple");
            comboBox2Marcas.Items.Add("Sony");
            comboBox2Marcas.Items.Add("Huawei");
            comboBox2Marcas.Items.Add("Motorola");
            cargar();

        }
        private void cargar()
        {
            Articulo_Negocio negocio = new Articulo_Negocio();

            listaArticulo = negocio.listar();
            dataGridView1.DataSource = listaArticulo;
            ocultarColumnas();
        }



        private void textBox1Buscar_TextChanged(object sender, EventArgs e)
        {
            buscarLupa();
        }
        private void buscarLupa()
        {
            List<Articulo> listaBuscar;
            string buscar = textBox1Buscar.Text;
            if (buscar.Length >= 3)
            {
                listaBuscar = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(buscar.ToUpper()) || x.Descripcion.ToUpper().Contains(buscar.ToUpper()));
            }
            else
            {
                listaBuscar = listaArticulo;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaBuscar;
            ocultarColumnas();
        }
        private void ocultarColumnas()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Imagen"].Visible = false;
            dataGridView1.Columns["Descripcion"].Visible = false;
        }
        private void filtrosMarca()
        {
            string marca;
            marca = comboBox2Marcas.SelectedText;
            textBox1Buscar.Clear();
        }
        private void filtroCategoria()
        {
            string categoria;
            categoria = comboBox1Categorias.SelectedText;
            textBox1Buscar.Clear();
        }




        private void comboBox2Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpio casilla de filtro buscar
            textBox1Buscar.Clear();
            dataGridView1.DataSource = null;

        }

        private void comboBox1Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpio casilla de filtro buscar
            textBox1Buscar.Clear();
            dataGridView1.DataSource = null;

        }

        private void textBox1Buscar_Click(object sender, EventArgs e)
        {
            //refresh a data grid view y blanqueo las casillas de combo box
            cargar();
            comboBox1Categorias.ResetText();
            comboBox2Marcas.ResetText();
        }

        private void button1Filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                cargarFiltros();

                comboBox1Categorias.ResetText();

                comboBox2Marcas.ResetText();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la lista seleccionada");
            }



        }
        private void cargarFiltros()//Carga de filtros de marca y categoria contra db
        {
            List<Articulo> listaFiltros = new List<Articulo>();
            Articulo_Negocio articulo = new Articulo_Negocio();
            string marca = null;
            string categoria = null;
            try
            {

                if (comboBox2Marcas.SelectedIndex >= 0)
                    marca = " and m.Descripcion ='" + comboBox2Marcas.SelectedItem.ToString() + "'";
                else marca = "";

                if (comboBox1Categorias.SelectedIndex >= 0)
                    categoria = "and c.Descripcion = '" + comboBox1Categorias.SelectedItem.ToString() + "'";
                else categoria = "";

                listaFiltros = articulo.filtrar(marca, categoria);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaFiltros;
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo en lectura DB, contacte al desarrollador");
            }
        }

        
    }
}




