using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
		string durum = "";
        string ogrencino = TxtOgrenciNo.Text;
        string ders = DropDers.Text;
        int vizenotu = Convert.ToInt32(TxtVizeNotu.Text);
        int finalnotu = Convert.ToInt32(TxtFinalNotu.Text);
		decimal ortalama = (vizenotu * 30 / 100) + (finalnotu * 80 / 100);
        if (ortalama >= 60)
            durum = "Geçti";
        else if (ortalama < 60)
            durum = "Kaldı";
        SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["VeriTabaniBaglanti"].ConnectionString);
        SqlCommand guncelleislemi = new SqlCommand("UPDATE Kayitlar SET VizeNotu=@vizenotu, FinalNotu=@finalnotu, Ortalama=@ortalama, Durum=@durum WHERE OgrenciNo=@ogrencino AND Ders=@ders", baglanti);
        guncelleislemi.Parameters.AddWithValue("@ogrencino", ogrencino);
        guncelleislemi.Parameters.AddWithValue("@ders", ders);
        guncelleislemi.Parameters.AddWithValue("@vizenotu", vizenotu);
        guncelleislemi.Parameters.AddWithValue("@finalnotu", finalnotu);
		guncelleislemi.Parameters.AddWithValue("@ortalama", ortalama);
        guncelleislemi.Parameters.AddWithValue("@durum", durum);
        baglanti.Open();
        guncelleislemi.ExecuteNonQuery();
        baglanti.Close();
        BilgiGoster.Text = ogrencino + " Numaralı Öğrenci Güncellendi!";
        guncelleislemi.Dispose();
        baglanti.Dispose();
    }
}