using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartGrandpaWeb
{
    public partial class TutorialVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String urlTxt = Request.QueryString.Get("url");
        }
    }
}