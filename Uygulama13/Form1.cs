﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama13
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekleNesne_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumaraN.Text);
            ogrenci.AdSoyad = txtAdSoyadN.Text;
            if (radioButton1.Checked) ogrenci.cinsiyet = true;
            else ogrenci.cinsiyet = false;
            ogrencilerList.Add(ogrenci);
            lbNesne.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                if (item.cinsiyet) cinsiyet = "BAY";
                else cinsiyet = "BAYAN";
                lbNesne.Items.Add(item.Numara +" "+item.AdSoyad+" "+cinsiyet);
            }
        }
    }
}
