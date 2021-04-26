using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GercekZamanliGenericStackOrnegi
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoadComplete(EventArgs e)
        {
            if (Session["URLStack"] == null)
            {
                Stack<string> urlStack = new Stack<string>();
                Session["URLStack"] = urlStack;
            }
            if (Request.UrlReferrer != null && !this.Page.IsPostBack && Session["BackButtonClicked"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }
            if (Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }
        }
    }
}