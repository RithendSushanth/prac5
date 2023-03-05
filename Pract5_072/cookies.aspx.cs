using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract5_072
{
    //Rithend_072 practical 5 :-
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            //-------------------ADDING cOOKIES-------------//
            if (apple.Checked)
                Response.Cookies["computer"]["apple"] = "Apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "Dell";
            if (hp.Checked)
                Response.Cookies["computer"]["hp"] = "Hp";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "Acer";
            if (lenevo.Checked)
                Response.Cookies["computer"]["lenevo"] = "Lenevo";
            if (asus.Checked)
                Response.Cookies["computer"]["asus"] = "Asus";
            if (sony.Checked)
                Response.Cookies["computer"]["sony"] = "Sony";
            //------------------FETCHING COOKIES--------------//
            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["apple"] + " ";
                if (Request.Cookies["computer"]["dell"] != null)
                    Label2.Text += Request.Cookies["computer"]["dell"] + " ";
                if (Request.Cookies["computer"]["acer"] != null)
                    Label2.Text += Request.Cookies["computer"]["acer"] + " ";
                if (Request.Cookies["computer"]["lenevo"] != null)
                    Label2.Text += Request.Cookies["computer"]["lenevo"] + " ";
                if (Request.Cookies["computer"]["asus"] != null)
                    Label2.Text += Request.Cookies["computer"]["asus"] + " ";
                if (Request.Cookies["computer"]["sony"] != null)
                    Label2.Text += Request.Cookies["computer"]["sony"] + " ";
                if (Request.Cookies["computer"]["hp"] != null)
                    Label2.Text += Request.Cookies["computer"]["hp"] + " ";
            }
            else Label2.Text = "Please select your choice!!";
            Response.Cookies["Computer"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}