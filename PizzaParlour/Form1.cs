using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        double slicePrice = 3.75;
        int numberOfSlices;
        double subtotal;
        double tax;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void slicesInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfSlices = Convert.ToInt16(slicesInput.Text);
                subtotal = numberOfSlices * slicePrice;
                 tax = subtotal * .13;
                total = subtotal + tax;
               

                untaxedLabel.Text = subtotal.ToString("C");
                TaxLabel.Text = tax.ToString("C");
                totalLabel.Text = total.ToString("C");
            }
            catch
            {
                totalLabel.Text = "пошел на хуй";
                untaxedLabel.Text = "пошел на хуй";
                TaxLabel.Text = "пошел на хуй";
                return;
            }
        }
    }
}
