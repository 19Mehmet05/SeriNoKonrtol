using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SeriNoKonrtol
{
    public partial class Form1 : Form
    {
        AesSifreleCoz aesSifrelecoz = new AesSifreleCoz();
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //SezarSifreleme sezarSifreleme = new SezarSifreleme();
          
            ////SezarSifreCoz sezarSifreCoz = new SezarSifreCoz();
            ////Base64SifreCoz base64SifreCoz = new Base64SifreCoz();
            //label1.Text = sezarSifreleme.Sıfre();
            //label2.Text = sezarSifreleme.Sıfre();
            //label3.Text = sezarSifreleme.Sıfre();
            //label4.Text = sezarSifreleme.Sıfre();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = aesSifrelecoz.AesSifrele("Okan Can Coşar");      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text==string.Empty)
            {
                MessageBox.Show("bton1 e tıkla");
            }
            else
            {
                label2.Text = aesSifrelecoz.AesSifre_Coz(label1.Text);
            }
        }
    }
}
