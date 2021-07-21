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
        protected void Page_Load(object sender, EventArgs e)
        {
            ITemasDAL dal = TemasDALFactory.Create();
            List<Tema> temas = dal.GetAll();
            Repetidor.DataSource = temas;
            Repetidor.DataBind();
        }
    }
}