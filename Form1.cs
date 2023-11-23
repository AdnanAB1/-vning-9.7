using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nivå = int.Parse(tbxNivå.Text);
            for (int i=1 ; i <= nivå; i++)
            {
                for (int j=1 ; j <=10; j++)
                {
                    tbxUtdata.AppendText(i * j + "\t"); //Här Beräknas produkten av i och j och läggs den till resultatet i en TextBox komponent med namnet tbxUtdata.
                }
                tbxUtdata.AppendText("\r\n");
            }
        }
    }
}
