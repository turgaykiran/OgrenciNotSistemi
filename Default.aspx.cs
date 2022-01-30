using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["VeriTabaniBaglanti"].ConnectionString);
        SqlCommand listeislemi = new SqlCommand("SELECT * FROM Kayitlar ORDER BY OgrenciNo ASC", baglanti);
        baglanti.Open();
        SqlDataReader liste = listeislemi.ExecuteReader();
        GridNotGoster.DataSource = liste;
        GridNotGoster.DataBind();
        baglanti.Close();
        listeislemi.Dispose();
        baglanti.Dispose();
    }
}