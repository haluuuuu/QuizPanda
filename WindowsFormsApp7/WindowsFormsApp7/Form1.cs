using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Formp : Form
    {
        public Formp()
        {
            InitializeComponent();
        }

        private void btnkonversihuruf_Click(object sender, EventArgs e)
        {
            string kata = txtinputkalimat.Text.ToUpper();
            int output, konversi, batas = kata.Length;
            string a = txtinputhuruf.Text.ToUpper();
            string b = txthurufubah.Text.ToUpper();
            char aa;
            aa = a[0];
            char bb;
            bb = b[0];
            konversi = (bb - aa);
            for (int z = 0; z < batas; z++)
            {
                char kata1 = kata[z];
                if (kata1 != 32)
                {
                    output = kata1 + konversi;
                    if (output < 65)
                    {
                        int i = 65 - output;
                        output = 91 - i;
                    }
                    else if (output > 90)
                    {
                        int i = output - 90;
                        output = 64 + i;
                    }
                    lblhasil.Text=((char)output).ToString();

                    
                }
                else
                {
                   lblhasil.Text = kata1.ToString();
                }
            }

        }
    }
}
