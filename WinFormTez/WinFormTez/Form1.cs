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

namespace WinFormTez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.comboBoxVeri.Items.Clear();
            this.comboBoxOran.Items.Clear();
            labelAzalan.Text = "Azalan";
            labelArtan.Text = "Artan";

            StreamReader sr = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/TumKelimeKokleri.txt");
            string text = sr.ReadLine();
            sr.Close();
            string[] kelimeler = text.Split(' ');
            comboBoxOran.SelectedText = "--Oran Seçiniz--";
            for (int i = 0; i < 100; i+=10)
            {
                this.comboBoxOran.Items.Add("%"+i+"-"+"%"+(i+10));
            }
            comboBoxVeri.SelectedText = "--Kelime Seçiniz--";
            for (int i = 0; i < kelimeler.Length; i++)
            {
                this.comboBoxVeri.Items.Add(kelimeler[i]);
            }
           
            //this.chart1.Series["Series1"].Points.AddY(10);
        }

        private void comboBoxVeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
            //this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.Series["Yillar"].Points.AddY(0);
          
            int sayac=0,sayac2 = 0,sayac3=0,sayac4=0;
            string secilenDeger = this.comboBoxVeri.Text;
            StreamReader sr2 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/1945-1962-KelimeKok.txt");
            string text2 = sr2.ReadLine();
            StreamReader sr3 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/1963-1980-KelimeKok.txt");
            string text3 = sr3.ReadLine();
            StreamReader sr4 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/1981-1999-KelimeKok.txt");
            string text4 = sr4.ReadLine();
            StreamReader sr5 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/2000-2019-KelimeKok.txt");
            string text5 = sr5.ReadLine();
          
            sr2.Close();
            sr3.Close();
            sr4.Close();
            sr5.Close();
            string[] kelimeler2 = text2.Split(' ');
            string[] kelimeler3 = text3.Split(' ');
            string[] kelimeler4 = text4.Split(' ');
            string[] kelimeler5 = text5.Split(' ');
       
          

            for (int i = 0; i < kelimeler2.Length; i++)
            {
                if ( secilenDeger== kelimeler2[i])
                {
                    sayac++;
                }
            }
            for (int i = 0; i < kelimeler3.Length; i++)
            {
                if (secilenDeger == kelimeler3[i])
                {
                    sayac2++;
                }
            }
            for (int i = 0; i < kelimeler4.Length; i++)
            {
                if (secilenDeger == kelimeler4[i])
                {
                    sayac3++;
                }
            }
            for (int i = 0; i < kelimeler5.Length; i++)
            {
                if (secilenDeger == kelimeler5[i])
                {
                    sayac4++;
                }
            }
        
            

            if (sayac>sayac2&& sayac > sayac3 && sayac > sayac4 )
            {
                this.chart1.ChartAreas[0].AxisY.Maximum = sayac;
            }
            if (sayac2> sayac&& sayac2 > sayac3 && sayac2 > sayac4)
            {
                this.chart1.ChartAreas[0].AxisY.Maximum = sayac2;
            }
            if (sayac3 > sayac2 && sayac3 > sayac && sayac3> sayac4)
            {
                this.chart1.ChartAreas[0].AxisY.Maximum = sayac3;
            }
            if (sayac4> sayac2 && sayac4> sayac3 && sayac4 > sayac)
            {
                this.chart1.ChartAreas[0].AxisY.Maximum = sayac4;
            }


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
           

            this.chart1.Series["Yillar"].Points.Add(sayac);
            this.chart1.Series["Yillar"].Points.Add(sayac2);
            this.chart1.Series["Yillar"].Points.Add(sayac3);
            this.chart1.Series["Yillar"].Points.Add(sayac4);
            chart1.Series["Yillar"].Points[0].AxisLabel = "1945-1962";
            chart1.Series["Yillar"].Points[1].AxisLabel = "1963-1980";
            chart1.Series["Yillar"].Points[2].AxisLabel = "1981-1999";
            chart1.Series["Yillar"].Points[3].AxisLabel = "2000-2019";
            chart1.Series["Yillar"].Points[0].Color = Color.Blue;
            chart1.Series["Yillar"].Points[1].Color = Color.Green;
            chart1.Series["Yillar"].Points[2].Color = Color.Red;
            chart1.Series["Yillar"].Points[3].Color = Color.Orange;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;

        }

        private void comboBoxOran_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxArtan.ScrollBars = ScrollBars.Vertical;
            textBoxAzalan.ScrollBars = ScrollBars.Vertical;
            int sayac=0;
            int secilenId = this.comboBoxOran.SelectedIndex;
            StreamReader sr = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/ArtanOranlar.txt");
            string text = sr.ReadLine();
            sr.Close();
            string[] artankelimeOranlari = text.Split(' ');

            StreamReader sr2 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/AzalanOranlar.txt");
            string text2 = sr2.ReadLine();
            sr.Close();
            string[] azalankelimeOranlari = text2.Split(' ');
            textBoxAzalan.Clear();
            textBoxArtan.Clear();
            //for (int i = 0; i < artankelimeOranlari.Length - 1; i += 2)
            //{
            //    if (secilenId == 0)
            //    {
            //        labelAzalan.Text = "%0-%10 Artma";
            //        if (Convert.ToDecimal(artankelimeOranlari[i]) > 0 && Convert.ToDecimal(artankelimeOranlari[i]) <= 10)
            //        {
            //            textBoxArtan.Text += artankelimeOranlari[i];
            //        }



            //    }
            //}

            //Azalan Oranların Getirilmesi
            for (int i = 0; i < azalankelimeOranlari.Length - 1; i += 2)
            {

                if (secilenId == 0)
                {


                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 0 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 10)
                    {

                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%0-%10  azalan";

                }

                else if (secilenId == 1)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 10 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 20)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%10-%20  azalan";
                }
                else if (secilenId == 2)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 20 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 30)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%20-%30  azalan";
                }
                else if (secilenId == 3)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 30 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 40)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%30-%40  azalan";
                }
                else if (secilenId == 4)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 40 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 50)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%40-%50 azalan";
                }
                else if (secilenId == 5)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 50 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 60)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%50-%60  azalan";
                }
                else if (secilenId == 6)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 60 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 70)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%60-%70  azalan";
                }
                else if (secilenId == 7)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 70 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 80)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%70-%80  azalan";
                }
                else if (secilenId == 8)
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 80 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 90)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%80-%90  azalan";
                }

                else
                {

                    if (Convert.ToDecimal(azalankelimeOranlari[i]) > 90 && Convert.ToDecimal(azalankelimeOranlari[i]) <= 100)
                    {
                        textBoxAzalan.Text += azalankelimeOranlari[i + 1] + ": " + " %" + azalankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelAzalan.Text = "%90-%100  azalan";
                }

            }

            for (int i = 0; i < artankelimeOranlari.Length-1; i+=2)
            {

                if (secilenId == 0)
                {


                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 0 && Convert.ToDecimal(artankelimeOranlari[i]) <= 10)
                    {

                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%0-%10  artan";

                }

                else if (secilenId == 1)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 10 && Convert.ToDecimal(artankelimeOranlari[i]) <= 20)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%10-%20  artan";
                }
                else if (secilenId == 2)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 20 && Convert.ToDecimal(artankelimeOranlari[i]) <= 30)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%20-%30  artan";
                }
                else if (secilenId == 3)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 30 && Convert.ToDecimal(artankelimeOranlari[i]) <= 40)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%30-%40  artan";
                }
                else if (secilenId == 4)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 40 && Convert.ToDecimal(artankelimeOranlari[i]) <= 50)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%40-%50 artan";
                }
                else if (secilenId == 5)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 50 && Convert.ToDecimal(artankelimeOranlari[i]) <= 60)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%50-%60  artan";
                }
                else if (secilenId == 6)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 60 && Convert.ToDecimal(artankelimeOranlari[i]) <= 70)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%60-%70  artan";
                }
                else if (secilenId == 7)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 70 && Convert.ToDecimal(artankelimeOranlari[i]) <= 80)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%70-%80  artan";
                }
                else if (secilenId == 8)
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 80 && Convert.ToDecimal(artankelimeOranlari[i]) <= 90)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%80-%90  artan";
                }

                else
                {

                    if (Convert.ToDecimal(artankelimeOranlari[i]) > 90 && Convert.ToDecimal(artankelimeOranlari[i]) <= 100)
                    {
                        textBoxArtan.Text += artankelimeOranlari[i + 1] + ": " + " %" + artankelimeOranlari[i] + Environment.NewLine;
                    }
                    labelArtan.Text = "%90-%100  artan";
                }

            }





        }




    }


        //private void btnHesapla_Click(object sender, EventArgs e)
        //{
        //    StreamReader sr = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/TumKelimeKokleri.txt");
        //    string text = sr.ReadLine();
        //    StreamReader sr2 = new StreamReader("C:/Users/kulas/Desktop/WinFormTez/Kelimeler/1945-1962-KelimeKok.txt");
        //    string text2 = sr2.ReadLine();
        //    sr.Close();
        //    string[] kelimeler2 = text2.Split(' ');
        //    string[] kelimeler = text.Split(' ');
        //    int[] say;
        //    say = new int[kelimeler2.Length];

        //    for (int i = 0; i < kelimeler.Length; i++)
        //    {
        //        for (int j = 0; j < kelimeler2.Length; j++)
        //        {
        //            if (kelimeler[i] == kelimeler2[j])
        //                say[i] += 1;
        //        }

        //    }
        //    for (int i = 0; i < kelimeler2.Length; i++)
        //    {

        //        textBox1.Text += say[i].ToString();


        //    }
        //}
    }

