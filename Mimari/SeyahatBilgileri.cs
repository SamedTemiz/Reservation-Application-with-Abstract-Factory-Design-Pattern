using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimari
{
    public partial class SeyahatBilgileri : Form
    {
        public SeyahatBilgileri()
        {
            InitializeComponent();
            radio_tek.Checked = true;
            cmb_kisi.SelectedIndex = 0;
            date_kalkis.Value = DateTime.Now;
            date_donus.Value = DateTime.Now;
        }

        //Antalya
        string[,] Oteller_A = { { "Starlight Resort Hotel", "1350" }, { "Kamelya Collection Fulya", "980" }, { "Rabinson Club Pamfilya", "2150" } };
        string[,] Kamplar_A = { { "Ridocamp", "300" }, { "Mandalina Camping", "350" }, { "Mutlu Camping", "500" } };

        //Muğla
        string[,] Oteller_M = { { "Tui Magic Life Sarıgerme", "1100" }, { "Tui Blue Tropical", "1400" }, { "Acroter Hotel Spa", "1250" } };
        string[,] Kamplar_M = { { "Azmakbaşı Camping", "350" }, { "Alpina Beach Camping", "400" }, { "Kayra Beach Camping", "250" } };

        //İzmir
        string[,] Oteller_I = { { "Boyalık Beach Hotel Spa", "1650" }, { "Pırıl Hotel Therman Beauty Spa", "1400" }, { "Design Plus Seya Beach Hotel", "1800" } };
        string[,] Kamplar_I = { { "Alaçatı Camping", "500" }, { "Huzur Camp", "400" }, { "Delikli Köy Kamp Alanı", "600" } };

        //Uçaklar
        string[,] ucak = { { "Türk Hava Yolları", "1700" }, { "Pegasus", "1200" }, { "AtlasJet", "1150" } };

        //Otobüsler
        string[,] otobus = { { "Kamikoç", "450" }, { "Metro Turizm", "385" }, { "Çeşme Seyahat", "430" } };

        private void pic_change_Click(object sender, EventArgs e)
        {
            int temp = cmb_varis.SelectedIndex;
            cmb_varis.SelectedIndex = cmb_kalkis.SelectedIndex;

            cmb_kalkis.SelectedIndex = temp;
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmb_kalkis.SelectedIndex > -1 && cmb_varis.SelectedIndex > -1 && (radio_cift.Checked == true || radio_tek.Checked == true) && cmb_kisi.SelectedIndex > -1 && cmb_kalkis.SelectedItem != cmb_varis.SelectedItem)
            {
                pnl_bilgiler.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri doğru bir şekilde giriniz!");
            }
        }
        private void cmb_konaklama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_konaklama.SelectedIndex == 0)
            {
                pic_konaklama.Visible = true;

                lbl_otel.Visible = true;
                cmb_otel.Visible = true;

                lbl_kamp.Visible = false;
                cmb_kamp.Visible = false;

                if (cmb_ulasim.SelectedIndex > -1)
                {
                    pic_tutar.Visible = true;
                    lbl_Tutar.Visible = true;
                    txt_tutar.Visible = true;
                }
            }
            else if (cmb_konaklama.SelectedIndex == 1)
            {
                pic_konaklama.Visible = true;

                lbl_kamp.Visible = true;
                cmb_kamp.Visible = true;

                lbl_otel.Visible = false;
                cmb_otel.Visible = false;

                if (cmb_ulasim.SelectedIndex > -1)
                {
                    pic_tutar.Visible = true;
                    lbl_Tutar.Visible = true;
                    txt_tutar.Visible = true;
                }
            }
        }
        private void cmb_ulasim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ulasim.SelectedIndex == 0)
            {
                pic_ulasim.Visible = true;

                lbl_ucak.Visible = true;
                cmb_ucak.Visible = true;

                lbl_otobus.Visible = false;
                cmb_otobus.Visible = false;

                if (cmb_konaklama.SelectedIndex > -1)
                {
                    pic_tutar.Visible = true;
                    lbl_Tutar.Visible = true;
                    txt_tutar.Visible = true;
                    btn_hesapla.Visible = true;
                    btn_onayla.Visible = true;
                    lbl_ktutar.Visible = true;
                    lbl_ututar.Visible = true;
                }
            }
            else if (cmb_ulasim.SelectedIndex == 1)
            {
                pic_ulasim.Visible = true;

                lbl_otobus.Visible = true;
                cmb_otobus.Visible = true;

                lbl_ucak.Visible = false;
                cmb_ucak.Visible = false;

                if (cmb_konaklama.SelectedIndex > -1)
                {
                    pic_tutar.Visible = true;
                    lbl_Tutar.Visible = true;
                    txt_tutar.Visible = true;
                    btn_hesapla.Visible = true;
                    btn_onayla.Visible = true;
                    lbl_ktutar.Visible = true;
                    lbl_ututar.Visible = true;
                }
            }
        }

        ISoyutFabrika paket;
        Seyahat seyahat;
        int k_fiyat, u_fiyat;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int Tip = 1, KisiSayi, gun = 1;
            string kalkis, varis, mekanAdi, firmaAdi;
            DateTime gidis = date_kalkis.Value;
            DateTime donus = date_donus.Value;
            if (radio_tek.Checked)
            {
                Tip = 1;
                gun = 1;
            }
            
            else if (radio_cift.Checked)
            {
                Tip = 2;
                if (date_donus.Value > date_kalkis.Value)
                    gun = date_donus.Value.Day - date_kalkis.Value.Day;
                else
                    gun = 1;
            }

            KisiSayi = int.Parse(cmb_kisi.SelectedItem.ToString());
            kalkis = cmb_kalkis.SelectedItem.ToString();
            varis = cmb_varis.SelectedItem.ToString();

            int konak = cmb_konaklama.SelectedIndex + 1;
            int ulas = cmb_ulasim.SelectedIndex + 1;

            switch (konak + ulas)
            {
                case 2:
                    mekanAdi = cmb_otel.SelectedItem.ToString();
                    firmaAdi = cmb_ucak.SelectedItem.ToString();
                    paket = new Otel_Ucak(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus, k_fiyat, u_fiyat);
                    break;
                case 3:
                    if (cmb_konaklama.SelectedIndex == 0)
                    {
                        mekanAdi = cmb_otel.SelectedItem.ToString();
                        firmaAdi = cmb_otobus.SelectedItem.ToString();
                        paket = new Otel_Otobus(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus, k_fiyat, u_fiyat);
                    }
                    else if (cmb_ulasim.SelectedIndex == 0)
                    {
                        mekanAdi = cmb_kamp.SelectedItem.ToString();
                        firmaAdi = cmb_ucak.SelectedItem.ToString();
                        paket = new Kamp_Ucak(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus, k_fiyat, u_fiyat);
                    }
                    break;
                case 4:
                    mekanAdi = cmb_kamp.SelectedItem.ToString();
                    firmaAdi = cmb_otobus.SelectedItem.ToString();
                    paket = new Kamp_Otobus(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus, k_fiyat, u_fiyat);
                    break;
            }
            seyahat = new Seyahat(paket);
            int konaklama_tutari = int.Parse(seyahat.KonaklamaBilgileri()[4]);
            int ulasim_tutari = int.Parse(seyahat.UlasimBilgileri()[4]);
            lbl_ktutar.Text = string.Format(konaklama_tutari.ToString()+"TL");
            lbl_ututar.Text = string.Format(ulasim_tutari.ToString()+"TL");
            txt_tutar.Text = string.Format((konaklama_tutari + ulasim_tutari).ToString()+"TL");
        }
        private void btn_onayla_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;  
            data_seyahat.Rows.Add(seyahat.UlasimBilgileri()[1], seyahat.UlasimBilgileri()[2], cmb_ulasim.SelectedItem.ToString(), cmb_konaklama.SelectedItem.ToString(), seyahat.KonaklamaBilgileri()[0] ,seyahat.KonaklamaBilgileri()[1], seyahat.KonaklamaBilgileri()[3], seyahat.KonaklamaBilgileri()[2], txt_tutar.Text);
            
        }
        private void radio_tek_CheckedChanged(object sender, EventArgs e)
        {
            date_donus.Enabled = false;
        }
        private void radio_cift_CheckedChanged(object sender, EventArgs e)
        {
            date_donus.Enabled = true;
            date_donus.MinDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        private void cmb_otel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmb_otel.SelectedIndex;
            string sehir = cmb_varis.SelectedItem.ToString();
            switch (sehir)
            {
                case "Antalya":
                    k_fiyat = int.Parse(Oteller_A[secim, 1]);
                    break;
                case "Muğla":
                    k_fiyat = int.Parse(Oteller_M[secim, 1]);
                    break;
                case "İzmir":
                    k_fiyat = int.Parse(Oteller_I[secim, 1]);
                    break;
            }
        }
        private void cmb_varis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_otel.Items.Clear();
            cmb_kamp.Items.Clear();
            cmb_ucak.Items.Clear();
            cmb_otobus.Items.Clear();

            cmb_otel.Text = "";
            cmb_kamp.Text = "";
            cmb_ucak.Text = "";
            cmb_otobus.Text = "";
            string sehir = cmb_varis.SelectedItem.ToString();
            switch (sehir)
            {
                case "Antalya":
                   

                    for (int i = 0; i < 3; i++)
                    {
                        cmb_otel.Items.Add(Oteller_A[i, 0]);
                        cmb_kamp.Items.Add(Kamplar_A[i, 0]);
                    }
                    break;
                case "Muğla":
                    cmb_otel.Items.Clear();
                    cmb_kamp.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_otel.Items.Add(Oteller_M[i, 0]);
                        cmb_kamp.Items.Add(Kamplar_M[i, 0]);
                    }
                    break;
                case "İzmir":
                    cmb_otel.Items.Clear();
                    cmb_kamp.Items.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_otel.Items.Add(Oteller_I[i, 0]);
                        cmb_kamp.Items.Add(Kamplar_I[i, 0]);
                    }
                    break;
            }
            
            for (int i = 0; i < 3; i++)
            {
                cmb_otobus.Items.Add(otobus[i, 0]);
                cmb_ucak.Items.Add(ucak[i, 0]);
            }
        }
        private void cmb_kamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmb_kamp.SelectedIndex;
            string sehir = cmb_varis.SelectedItem.ToString();
            switch (sehir)
            {
                case "Antalya":
                    k_fiyat = int.Parse(Kamplar_A[secim, 1]);
                    break;
                case "Muğla":
                    k_fiyat = int.Parse(Kamplar_M[secim, 1]);
                    break;
                case "İzmir":
                    k_fiyat = int.Parse(Kamplar_I[secim, 1]);
                    break;
            }
        }
        private void cmb_otobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmb_otobus.SelectedIndex;
            u_fiyat = int.Parse(otobus[secim, 1]);
        }
        private void cmb_ucak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmb_ucak.SelectedIndex;
            u_fiyat = int.Parse(ucak[secim, 1]);
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            int k = data_bilgiler.RowCount + 1;
            int kisisay = int.Parse(cmb_kisi.SelectedItem.ToString());

            if (txt_KimlikNo.Text == " " && txt_Ad.Text == " " && txt_Soyad.Text == " " && txt_Mail.Text == " " && cmb_Cinsiyet.Text == " ")
            {
                MessageBox.Show("Boşlukları Doldurunuz.");
            }
            else
            {
                data_bilgiler.Rows.Add(txt_KimlikNo.Text, txt_Ad.Text, txt_Soyad.Text, msked_telefon.Text, txt_Mail.Text, cmb_Cinsiyet.SelectedItem);
            }
            txt_Ad.Text = "";
            txt_KimlikNo.Text = "";
            txt_Soyad.Text = "";
            msked_telefon.Text = "";
            txt_Mail.Text = "";
            cmb_Cinsiyet.Text = "";
            group_KimlikBilgileri.Text = k + 1 + ".Kişinin Bilgileri";
        }

        KimlikBilgileri kimlik = new KimlikBilgileri();
        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            if (data_bilgiler.RowCount > 0)
            {
                
                for (int i = 0; i < data_bilgiler.RowCount; i++)
                {
                    kimlik.Tc = data_bilgiler.Rows[i].Cells[0].Value.ToString();
                    kimlik.Ad = data_bilgiler.Rows[i].Cells[1].Value.ToString();
                    kimlik.Soyad = data_bilgiler.Rows[i].Cells[2].Value.ToString();
                    kimlik.Telefon = data_bilgiler.Rows[i].Cells[3].Value.ToString();
                    kimlik.Mail = data_bilgiler.Rows[i].Cells[4].Value.ToString();
                    kimlik.Cinsiyet = data_bilgiler.Rows[i].Cells[5].Value.ToString();
                }
                MessageBox.Show("İşlem tamamlandı.");

                //Görsel değişiklikler
                btn_tamamla.Visible = false;
                btn_Gonder.Visible = false;
                group_KimlikBilgileri.Visible = false;

                data_bilgiler.Width = 856;
                data_bilgiler.Location = new Point(10, 10);
                data_seyahat.Visible = true;
                cmb_cikti.Visible = true;
                btn_cikti.Visible = true;

                cmb_cikti.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Herhangi bir bilgi girilmedi!");
            }

        }

        private void txt_KimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            switch (cmb_cikti.SelectedItem)
            {
                case "JSON":
                    Json json = new Json();
                    json.SeyahatBilgi(seyahat, kimlik);
                    json.SeyahatDetayliBilgi(seyahat);
                    json.Tutar(seyahat);
                    json.GetProduct();
                    MessageBox.Show("Başarılı");
                    break;
                case "XML":
                    //Xml olacak
                    Xml xml = new Xml();
                    xml.SeyahatBilgi(seyahat, kimlik);
                    xml.SeyahatDetayliBilgi(seyahat);
                    xml.Tutar(seyahat);
                    xml.GetProduct();
                    MessageBox.Show("Başarılı");
                    break;
                case "HTML":
                    //Html olacak
                    break;
            }
        }
    }
}
