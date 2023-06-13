using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class Articulo_Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearConsulta("Select A.Id, Codigo,Nombre, A.Descripcion,M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, precio, IdCategoria, IdMarca from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Articulo> filtrar(string marca, string categoria)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            Acceso_Datos datos = new Acceso_Datos();

            try
            {
                datos.setearConsulta(" Select A.Id, Codigo,Nombre, A.Descripcion,M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id " + marca + categoria);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["precio"];

                    listaFiltrada.Add(aux);

                }

                datos.cerrarConexion();
                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cargarNuevo(Articulo articulo)
        {
            try
            {
                Acceso_Datos datos = new Acceso_Datos();
                datos.setearConsulta(" Insert into ARTICULOS(Codigo,Nombre,Descripcion, ImagenUrl, precio, IdMarca, IdCategoria ) values (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Codigo", articulo.Codigo.ToString());
                datos.setearParametro("@Nombre", articulo.Nombre.ToString());
                datos.setearParametro("@Descripcion", articulo.Descripcion.ToString());
                datos.setearParametro("@ImagenUrl", articulo.Imagen.ToString());
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void modificar()
        {

        }

        public List<Articulo> listaCategorias()
        {
            List<Articulo> listaCategorias = new List<Articulo>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearConsulta("select descripcion, Id from CATEGORIAS  ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["descripcion"];
                    aux.Categoria.Id = (int)datos.Lector["Id"];
                    listaCategorias.Add(aux);
                }

                return listaCategorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<Articulo> listaMarcas()
        {
            List<Articulo> listaMarcas = new List<Articulo>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearConsulta("select descripcion, Id from  Marcas ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datos.Lector["descripcion"];
                    aux.Marca.Id = (int)datos.Lector["Id"];
                    listaMarcas.Add(aux);
                }

                return listaMarcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
