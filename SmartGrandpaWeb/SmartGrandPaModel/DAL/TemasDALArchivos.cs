using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartGrandPaModel.DTO;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SmartGrandPaModel.DAL
{


    public class TemasDALArchivos : ITemasDAL
    {
        //PATRON SINGLETON
        private TemasDALArchivos()
        {

        }
        private static ITemasDAL instancia;
        public static ITemasDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new TemasDALArchivos();
            return instancia;
        }


        //METODO PARA DEVOLVER TODOS LOS TEMAS DE LA BASE DE DATOS
        public List<Tema> GetAll()
        {
            List<Tema> temas = new List<Tema>();
            using (MySqlConnection conexion = Conectar())
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Select idTema, Nombre_tema, Url_imagen_tema, Descripcion_tema, VideoTutorial_idVideoTutorial, GuiaEscrita_idGuiaEscrita, MaterialDidactico_idMaterialDidactico from tema"),conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Tema t = new Tema();
                    t.Id = reader.GetInt32(0);
                    t.NombreTema = reader.GetString(1);
                    t.UrlImagen = reader.GetString(2);
                    t.Descripcion = reader.GetString(3);
                    t.IdVideo = reader.GetString(4);
                    t.IdGuia = reader.GetString(5);
                    t.IdMaterialDidactico = reader.GetString(6);
                    temas.Add(t);
                }
                comando = null;
                conexion.Close();

                return temas;
            }

        }
        //METODO PARA CONECTAR CON LA BASE DE DATOS
            public static MySqlConnection Conectar()
        {
            MySqlConnection cn = new MySqlConnection("server=localhost; Uid=root; Password=; Database=smartgrandpa; Port=3306");
            cn.Open();
            return cn;
        }
        //METODO PARA FILTRAR POR ID LOS TEMAS
        public Tema FindById(int id)
        {
            List<Tema> temas = GetAll();
            Tema tema = temas.Find(t => t.Id == id);
            return tema;
        }
        //METODO PARA OBTENENR LAS URLS DE LOS MATERIALES EDUCATIVOS DE LOS TEMAS
        public List<string> GetUrls(Tema t)
        {
            List<String> urls = new List<string>();
            using (MySqlConnection conexion = Conectar())
            {
                MySqlCommand comandoVideo = new MySqlCommand(string.Format("SELECT url from videotutorial where idVideoTutorial = " + t.IdVideo), conexion);
                MySqlCommand comandoMaterialDidactico = new MySqlCommand(string.Format("SELECT url from materialdidactico where idMaterialDidactico = "+ t.IdMaterialDidactico), conexion);
                MySqlCommand comandoGuiaEscrita = new MySqlCommand(string.Format("SELECT url from guiaescrita where idGuiaEscrita = "+ t.IdGuia), conexion);
                String url="";
                //Se obtiene el video
                MySqlDataReader reader = comandoVideo.ExecuteReader();
                while (reader.Read())
                {
                    url = reader.GetString(0);
                }
                urls.Add(url);
                //Se obtiene la Guia
                reader.Close();
                reader = comandoGuiaEscrita.ExecuteReader();
                while (reader.Read())
                {
                    url = reader.GetString(0);
                }
                urls.Add(url);
                //Se obtiene el Maeterial Didactico
                reader.Close();
                reader = comandoMaterialDidactico.ExecuteReader();
                while (reader.Read())
                {
                    url = reader.GetString(0);
                }
                urls.Add(url);
                conexion.Close();
            }
            return urls;
        }
    }


}
