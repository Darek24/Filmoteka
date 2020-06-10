using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmotekaWebApp
{
    public partial class _Default : Page
    {
        DataSet dataSet = new DataSet();
        string sampleXmlFile = @"C:\Users\dariu\source\repos\FilmotekaWebApp\FilmotekaWebApp\filmoteka.xml";
        protected void Page_Load(object sender, EventArgs e)
        {

            dataSet.ReadXml(sampleXmlFile);
            DataView dataView = new DataView(dataSet.Tables[0]);
            GridView1.DataSource = dataView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataSet.Tables[0]);
            dataView.Sort = "rok desc";

            GridView1.DataSource = dataView;
            GridView1.DataBind();
            dataSet.WriteXml(sampleXmlFile);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataSet.Tables[0]);
            dataView.Sort = "kraj desc";
            GridView1.DataSource = dataView;
            GridView1.DataBind();
            dataSet.WriteXml(sampleXmlFile);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataSet.Tables[0]);
            dataView.Sort = "tytul_pol desc";
            GridView1.DataSource = dataView;
            GridView1.DataBind();
            dataSet.WriteXml(sampleXmlFile);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text;
            DataView dataView = new DataView(dataSet.Tables[0]);
            dataView.Sort = "tytul_pol desc";
            int i = dataView.Find(text);

            GridView1.DataSource = dataView;
            GridView1.DataBind();
        }
    }
}