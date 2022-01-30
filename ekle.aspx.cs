using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnKaydet_Click(object sender, EventArgs e)
    {
        string durum = "";
        string ogrencino = TxtOgrenciNo.Text;
        string adsoyad = TxtAdSoyad.Text;
        string ders = DropDers.SelectedValue;
        int vizenotu = Convert.ToInt32(TxtVizeNotu.Text);
        int finalnotu = Convert.ToInt32(TxtFinalNotu.Text);
        decimal ortalama = (vizenotu * 30 / 100) + (finalnotu * 80 / 100);
        if (ortalama >= 60)
            durum = "Geçti";
        else if (ortalama < 60)
            durum = "Kaldı";
        SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["VeriTabaniBaglanti"].ConnectionString);
        SqlCommand ekleislemi = new SqlCommand("INSERT INTO Kayitlar (OgrenciNo, Ders, AdSoyad, VizeNotu, FinalNotu, Ortalama, Durum) VALUES (@ogrencino, @ders, @adsoyad, @vizenotu, @finalnotu, @ortalama, @durum)", baglanti);
        ekleislemi.Parameters.AddWithValue("@ogrencino", ogrencino);
        ekleislemi.Parameters.AddWithValue("@ders", ders);
        ekleislemi.Parameters.AddWithValue("@adsoyad", adsoyad);
        ekleislemi.Parameters.AddWithValue("@vizenotu", vizenotu);
        ekleislemi.Parameters.AddWithValue("@finalnotu", finalnotu);
        ekleislemi.Parameters.AddWithValue("@ortalama", ortalama);
        ekleislemi.Parameters.AddWithValue("@durum", durum);
        baglanti.Open();
        ekleislemi.ExecuteNonQuery();
        baglanti.Close();
        BilgiGoster.Text = ogrencino + " Numaralı Öğrenci Veritabanına Kaydedildi!";
        ekleislemi.Dispose();
        baglanti.Dispose();
    }
}