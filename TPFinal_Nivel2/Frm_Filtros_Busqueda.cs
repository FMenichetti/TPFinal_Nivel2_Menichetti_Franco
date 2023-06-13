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
    public partial class Frm_Filtros_Busqueda : Form
    {
        public Frm_Filtros_Busqueda()
        {
            InitializeComponent();
        }

        private void Frm_Nuevo_Modificar_Load(object sender, EventArgs e)
        {
            
            cargar();
        }
        private void cargar()
        {
            Articulo_Negocio negocio = new Articulo_Negocio();
            List<Articulo> articulo = new List<Articulo>();
            articulo = negocio.listar();
            dataGridView1.DataSource = articulo;
        }

        



    }
}

