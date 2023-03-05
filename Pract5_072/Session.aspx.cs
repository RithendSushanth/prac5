using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract5_072
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (tpsswd.Text == "hulk")
            {
                //Storing email to Session variable
                Session["username"] = tuname.Text;
            }
            else
            {
                error.Text = "Wrong Password";
            }
            if (Session["username"] != null)
            {
                //Displaying Stored email
                error.Text = "This username is stored to the session";
                session.Text = Session["username"].ToString();
            }
        }
    }
}