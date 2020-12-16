using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        /*Globalne promjenjive */

        //Rezultat
        double rezultat = 0;
        String izvrsenaOperacije = "";
        bool jelOperacijaIzvrsena = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {


            
            if ((bunifuTextBox1.Text == "0" )|| (jelOperacijaIzvrsena))  
            
                bunifuTextBox1.Clear();
            
            jelOperacijaIzvrsena = false;
            Bunifu.UI.WinForms.BunifuButton.BunifuButton button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            //Decimalni zapis
            if (button.Text == ".")
            {
                if (!bunifuTextBox1.Text.Contains("."))
                    bunifuTextBox1.Text = bunifuTextBox1.Text + button.Text;

            }
            else
                bunifuTextBox1.Text = bunifuTextBox1.Text + button.Text;

        
        }
        //Matematičke Operacije
        private void operator_click(object sender, EventArgs e)
        {

            Bunifu.UI.WinForms.BunifuButton.BunifuButton button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            if (rezultat != 0)
            {
                buttonEql.PerformClick();
                izvrsenaOperacije = button.Text;
                //Labela sa rezultatima
                bunifuLabel1.Text = rezultat + " " + izvrsenaOperacije;
                jelOperacijaIzvrsena = true;

            }
            else
            {
                izvrsenaOperacije = button.Text;
                rezultat = Double.Parse(bunifuTextBox1.Text);
                bunifuLabel1.Text = rezultat + " " + izvrsenaOperacije;
                jelOperacijaIzvrsena = true;
            }
     
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "0";
            
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "0";
            rezultat = 0;
        }

        private void buttonEql_Click(object sender, EventArgs e)
        {

            switch (izvrsenaOperacije)
            {
              
                case "+":
                    bunifuTextBox1.Text = (rezultat + Double.Parse(bunifuTextBox1.Text)).ToString();
                    break;
                case "-":
                    bunifuTextBox1.Text = (rezultat - Double.Parse(bunifuTextBox1.Text)).ToString();

                    break;
                case "/":
                    bunifuTextBox1.Text = (rezultat / Double.Parse(bunifuTextBox1.Text)).ToString();

                    break;
                case "*":
                    bunifuTextBox1.Text = (rezultat * Double.Parse(bunifuTextBox1.Text)).ToString();
                    break;
                case "√":
                    bunifuTextBox1.Text = (Math.Sqrt(Double.Parse(bunifuTextBox1.Text))).ToString();
                    break;
                default:
                    break;
            }
            rezultat = double.Parse(bunifuTextBox1.Text);
            bunifuLabel1.Text = "";
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
