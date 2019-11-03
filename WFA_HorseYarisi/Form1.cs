using System;
using System.Windows.Forms;

namespace WFA_HorseYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pc1.Left += rnd.Next(1, 20);
            pc2.Left += rnd.Next(1, 20);
            pc3.Left += rnd.Next(1, 20);
        

            if (pc1.Right >= lblFinishCizgisi.Left && pc1.Right > pc2.Right && pc1.Right > pc3.Right)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 1. Kulvardaki ŞahBatur kazandı");
            }
            else if (pc2.Right >= lblFinishCizgisi.Left && pc2.Right > pc1.Right && pc2.Right > pc3.Right)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 2. Kulvardaki GülBatur kazandı");
            }
            else if (pc3.Right >= lblFinishCizgisi.Left && pc3.Right > pc1.Right && pc3.Right > pc2.Right)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 3. Kulvardaki CanBatur kazandı");
            }


            // 1) Sol üst köşede bir label eklenecek ve hangi atın önde gittiğini bize bildirecek.
            // 2) Yarışı sıfırla butonu eklenecek ve bu butona tıklandığında yarış sıfırlanacak. Atlar başlangı. çizgisine gelecek ve ekrandaki bildirimler temizlenecek. 
            // 3) Oyuna hile eklenecek. finish çizgisinin gerisine her bir at için panel eklenip mouse üzerine geldiğinde ata +15 değer ekleyecek :)
            // 4) Oyun setup haline getirilecek :D


        }
    }
}
