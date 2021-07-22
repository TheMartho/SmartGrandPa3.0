using SmartGrandPaModel.DAL;
using SmartGrandPaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartGrandpaWeb
{
    public partial class Tutoriales : System.Web.UI.Page
    {
        public static ITemasDAL dal = TemasDALFactory.Create();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Tema> temas = dal.GetAll();
            Repetidor.DataSource = temas;
            Repetidor.DataBind();
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            String filtro = filtroTxt.Text.Trim();
            if (!string.IsNullOrEmpty(filtro)){
                List<Tema> temas = dal.temasFiltrados(filtro);
                Repetidor.DataSource = temas;
                Repetidor.DataBind();
            }

        }
    }

}