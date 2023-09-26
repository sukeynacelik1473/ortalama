using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace öğreci_ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2;
            double sonuc;
             
            not1= Convert.ToInt32(txtNot1.Text);
            not2= Convert.ToInt32(txtNot2.Text);

            sonuc = (not1 + not2) / 2;

            lblSonuç.Text = sonuc.ToString();
            
            
        }
    }
}
