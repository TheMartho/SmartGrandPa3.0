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
    public partial class Opciones : System.Web.UI.Page
    {
        public static List<String> urls = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            String idTemaTxt = Request.QueryString.Get("Id");
            int idTema = Convert.ToInt32(idTemaTxt);
            ITemasDAL dal = TemasDALFactory.Create();
            Tema t = dal.FindById(idTema);
            urls = dal.GetUrls(t);
        }
        //REDIRIGE A UNA GUIA ESCRITA (GUIA EN DESARROLLO)
        protected void EscritoBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect(urls[1]);
        }
        //REDIRIGE A UN VIDEO EXPLICATIVO (VIDEO EN DESARROLLO, MIENTRAS SE DEJA UNO DE YOUTUBE)
        protected void VideoBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialVideo.aspx?url=" + urls[0]);
        }
        //REDIRIGE A UN MATERIAL DIDACTICO (MATERIAL EN DESARROLLO)
        protected void DidacticoBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect(urls[2]);

        }
    }
    

}