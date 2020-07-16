using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMoney
{
    public partial class SortMoney : Form
    {
        public SortMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sortMoney = { 100, 50, 20, 10, 5, 2, 1 };

            TextBox textBox;

            int j = 1; 

            for (int i = 0; i < sortMoney.Length; i++)
            {
                // sort money
                int results = Convert.ToInt32(textBox8.Text) / sortMoney[i];

                //looping through the text boxes 
                textBox = (TextBox)this.Controls["textBox" + j];

                textBox.Text = results.ToString(); // display result in correct textboxes

                if (results != 0) {
                    //reduce the money from the textbox 
                    int t = results * sortMoney[i];

                    t = Convert.ToInt32(textBox8.Text) - t;

                    textBox8.Text = t.ToString();
                }
                j++; // next textbox

            }
        }
    }
}
