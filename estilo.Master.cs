﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Sonsv
{
    public partial class estilo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HtmlGenericControl liItem = (HtmlGenericControl)Master.FindControl("liItemID");
            //liItem.Attributes.Add("class", "someCssClass");
            switch (Page.Title)
            {
                case "Tablero":
                    lblSubtitulo.InnerText = "Bienvenido a Sonora sin violencia vial";
                    liTablero.Attributes.Add("class", "start active");
                    break;
                case "AltaSolicitud":
                    lblSubtitulo.InnerText = "Levanta tu solicitud";
                    liAlta.Attributes.Add("class", "start active");
                    liSolicitar.Attributes.Add("class", "active");
                    break;
                //case "AltaSolicitud":
                //    liSolicitar.Attributes.Add("class", "dropdown dropdown-fw open selected");
                //    break;
                //case "AltaSolicitud":
                //    liSolicitar.Attributes.Add("class", "dropdown dropdown-fw open selected");
                //    break;

            }
        }
    }
}