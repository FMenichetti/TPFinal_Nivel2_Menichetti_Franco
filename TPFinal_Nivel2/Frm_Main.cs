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
            try
            {
                Frm_Nuevo_Modificar agregar = new Frm_Nuevo_Modificar();
                agregar.ShowDialog();
                cargarDatosLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, por favor contacte a su Developer.");
            }

        }

        private void button3ModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    MessageBox.Show("No ha seleccionado ningun articulo para realizar la operacion!", "ATENCION!");
                return;
                Articulo seleccionado = new Articulo();

                seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                Frm_Nuevo_Modificar modificar = new Frm_Nuevo_Modificar(seleccionado);
                modificar.ShowDialog();
                cargarDatosLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error inesperado, por favor contacte a su developer");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatosComboBox();
                cargarDatosLista();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudieron cargar los datos, por favor cierre la aplicacion e intente nuevamente. En caso de no funcionar contacte a su Developer.");
            }

        }
        private void cargarDatosComboBox()
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
        }
        private void cargarDatosLista()
        {
            try
            {
                Articulo_Negocio negocio = new Articulo_Negocio();

                listaArticulo = negocio.listar();
                dataGridView1.DataSource = listaArticulo;
                ocultarColumnas();

            }
            catch (Exception)
            {

                MessageBox.Show("No se pueden cargar Datos, por favor contacte a su developer");
            }
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
                listaBuscar = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(buscar.ToUpper()) || x.Codigo.ToUpper().Contains(buscar.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(buscar.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(buscar.ToUpper()));
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
            cargarDatosLista();
            //comboBox1Categorias.ResetText();
            //comboBox2Marcas.ResetText();
        }

        private void button1Filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarFiltros();
                //comboBox1Categorias.ResetText();
                //comboBox2Marcas.ResetText();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la lista seleccionada, intente nuevamente. Si el problema persiste contacte a su developer");
            }



        }
        private void cargarFiltros()//Carga de filtros de marca y categoria contra db
        {
            List<Articulo> listaFiltros = new List<Articulo>();
            Articulo_Negocio articulo = new Articulo_Negocio();
            string marca = null;
            string categoria = null;
            if (comboBox2Marcas.SelectedIndex >= 0)
                marca = " and m.Descripcion ='" + comboBox2Marcas.SelectedItem.ToString() + "'";
            else marca = "";

            if (comboBox1Categorias.SelectedIndex >= 0)
                categoria = "and c.Descripcion = '" + comboBox1Categorias.SelectedItem.ToString() + "'";
            else categoria = "";

            try
            {

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

        private void button1Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("No ha seleccionado ningun articulo para realizar la operacion!", "ATENCION!");
            return;
            try
            {
                eliminar();
                cargarDatosLista();

            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido un error, por favor contacte a su desarrollador");
            }
        }
        private void eliminar()
        {

            Articulo seleccionado;
            seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            Articulo_Negocio negocio = new Articulo_Negocio();
            DialogResult respuesta;
            respuesta = MessageBox.Show("Esta seguro que desea eliminar definitivamente este archivo?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == respuesta)
                try
                {
            negocio.eliminar(seleccionado.Id);
                                    }
                catch (Exception)
                {
                    MessageBox.Show("A ocurrido un error, por favor contacte a su desarrollador");
                                   }  

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("No ha seleccionado ningun articulo para realizar la operacion!", "ATENCION!");
            return;
            Articulo seleccionado = new Articulo();
            try
            {
            seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            Frm_Detalle_Productos frm = new Frm_Detalle_Productos(seleccionado);
            frm.ShowDialog();
                            }
            catch (Exception ex )
            {
                MessageBox.Show("A ocurrido un error, por favor contacte a su developer");
            } 
        }

    }
}




