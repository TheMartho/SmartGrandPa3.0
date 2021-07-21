using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGrandPaModel.DTO
{
    //CLASE TEMA QUE REPRESENTA LA TABLA TEMA EN LA BASE DE DATOS
    public class Tema
    {
        private int id;
        private String nombreTema;
        private String urlImagen;
        private String descripcion;
        private String idVideo;
        private String idGuia;
        private String idMaterialDidactico;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string NombreTema
        {
            get
            {
                return nombreTema;
            }

            set
            {
                nombreTema = value;
            }
        }

        public string UrlImagen
        {
            get
            {
                return urlImagen;
            }

            set
            {
                urlImagen = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string IdVideo
        {
            get
            {
                return idVideo;
            }

            set
            {
                idVideo = value;
            }
        }

        public string IdGuia
        {
            get
            {
                return idGuia;
            }

            set
            {
                idGuia = value;
            }
        }

        public string IdMaterialDidactico
        {
            get
            {
                return idMaterialDidactico;
            }

            set
            {
                idMaterialDidactico = value;
            }
        }
    }
}
