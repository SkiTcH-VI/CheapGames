using System;
using System.Linq;
using CheapGames.Models;
using System.Web.Routing;
using CheapGames.Pages.Helpers;

namespace CheapGames.Controls
{
    public partial class LoginButton : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cart myCart = SessionHelper.GetCart(Session);
            csLink.HRef = RouteTable.Routes.GetVirtualPath(null, "login",
                null).VirtualPath;
        }
    }
}