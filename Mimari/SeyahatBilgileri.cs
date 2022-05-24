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
        }

        private void pic_change_Click(object sender, EventArgs e)
        {
            int temp = cmb_varis.SelectedIndex;
            cmb_varis.SelectedIndex = cmb_kalkis.SelectedIndex;

            cmb_kalkis.SelectedIndex = temp;
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmb_kalkis.SelectedIndex > -1 && cmb_varis.SelectedIndex > -1)
            {
                pnl_bilgiler.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!");
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
                }
            }
        }

        ISoyutFabrika paket;
        Seyahat seyahat;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int Tip = 1, KisiSayi, gun = 1;
            string kalkis, varis, mekanAdi, firmaAdi;
            DateTime gidis = date_kalkis.Value;
            DateTime donus = date_donus.Value;
            if (radio_tek.Checked)
                Tip = 1;
            else if (radio_cift.Checked)
            {
                Tip = 2;
                gun = (date_donus.Value.Day - date_kalkis.Value.Day);
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
                    paket = new Otel_Ucak(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus);
                    break;
                case 3:
                    if (cmb_konaklama.SelectedIndex == 0)
                    {
                        mekanAdi = cmb_otel.SelectedItem.ToString();
                        firmaAdi = cmb_otobus.SelectedItem.ToString();
                        paket = new Otel_Otobus(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus);
                    }
                    else if (cmb_ulasim.SelectedIndex == 0)
                    {
                        mekanAdi = cmb_kamp.SelectedItem.ToString();
                        firmaAdi = cmb_ucak.SelectedItem.ToString();
                        paket = new Kamp_Ucak(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus);
                    }
                    break;
                case 4:
                    mekanAdi = cmb_kamp.SelectedItem.ToString();
                    firmaAdi = cmb_otobus.SelectedItem.ToString();
                    paket = new Kamp_Otobus(varis, mekanAdi, gun, KisiSayi, Tip, firmaAdi, kalkis, varis, gidis, donus);
                    break;
            }
            seyahat = new Seyahat(paket);
        }
        private void btn_onayla_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
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

        }

        private void cmb_varis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = cmb_varis.SelectedItem.ToString();

            switch (sehir)
            {
                case "Antalya":
                    cmb_otel.Items.Clear();
                    cmb_otel.Items.Add("Starlight Resort Hotel");
                    cmb_otel.Items.Add("Kamelya Collection Fulya");
                    cmb_otel.Items.Add("Rabinson Club Pamfilya");

                    cmb_kamp.Items.Clear();
                    cmb_kamp.Items.Add("Ridocamp");
                    cmb_kamp.Items.Add("Mandalina Camping");
                    cmb_kamp.Items.Add("Mutlu Camping");
                    break;
                case "Muğla":
                    cmb_otel.Items.Clear();
                    cmb_otel.Items.Add("Tui Magic Life Sarıgerme");
                    cmb_otel.Items.Add("Tui Blue Tropical");
                    cmb_otel.Items.Add("Acroter Hotel Spa");

                    cmb_kamp.Items.Clear();
                    cmb_kamp.Items.Add("Azmakbaşı Camping");
                    cmb_kamp.Items.Add("Alpina Beach Camping");
                    cmb_kamp.Items.Add("Kayra Beach Camping");
                    break;
                case "İzmir":
                    cmb_otel.Items.Clear();
                    cmb_otel.Items.Add("Boyalık Beach Hotel Spa");
                    cmb_otel.Items.Add("Pırıl Hotel Therman Beauty Spa");
                    cmb_otel.Items.Add("Design Plus Seya Beach Hotel");

                    cmb_kamp.Items.Clear();
                    cmb_kamp.Items.Add("Alaçatı Camping");
                    cmb_kamp.Items.Add("Huzur Camp");
                    cmb_kamp.Items.Add("Delikli Köy Kamp Alanı");
                    break;
            }
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            int k = data_bilgiler.RowCount + 1;
            int kisisay = int.Parse(cmb_kisi.SelectedItem.ToString());

            if (txt_KimlikNo.Text == " " && txt_Ad.Text == " " && txt_Soyad.Text == " " && msked_telefon.Text == " " && txt_Mail.Text == "" && cmb_Cinsiyet.Text == "")
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
        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            KimlikBilgileri kimlik = new KimlikBilgileri();
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

            data_bilgiler.Width = 780;
            data_bilgiler.Location = new Point(50, 15);
            list_seyahat.Visible = true;
            cmb_cikti.Visible = true;
            btn_cikti.Visible = true;

            cmb_cikti.SelectedIndex = 0;
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            switch(cmb_cikti.SelectedItem)
            {
                case "JSON":
                    //Json olacak
                    break;
                case "XML":
                    //Xml olacak
                    break;
                case "HTML":
                    //Html olacak
                    break;
            }
        }
    }
}
