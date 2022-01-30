using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class sil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSil_Click(object sender, EventArgs e)
    {
        string ogrencino = TxtOgrenciNo.Text;
        string ders = DropDers.Text;
        SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["VeriTabaniBaglanti"].ConnectionString);
        SqlCommand silislemi = new SqlCommand("DELETE FROM Kayitlar WHERE OgrenciNo=@ogrencino AND Ders=@ders", baglanti);
        silislemi.Parameters.AddWithValue("@ogrencino", ogrencino);
        silislemi.Parameters.AddWithValue("@ders", ders);
        baglanti.Open();
        silislemi.ExecuteNonQuery();
        baglanti.Close();
        BilgiGoster.Text = ogrencino + " Numaralı Öğrenci Veritabanından Silindi!";
        silislemi.Dispose();
        baglanti.Dispose();
    }
}