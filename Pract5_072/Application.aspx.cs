using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract5_072
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tusers, ousers;
            Application.Lock();
            tusers = Application["tusers"].ToString();
            ousers = Application["ousers"].ToString();
            Application.UnLock();
            TextBox3.Text = tusers;
            TextBox4.Text = ousers;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}