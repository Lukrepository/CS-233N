using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilogramConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables for kgtopounds and poundstoounces
        double kilos, pounds, ounces;

        // Display a list of all kilograms, pounds and ounces in
        // the outputListBox when the form is loaded. Use the
        // KgToPounds and PoundsToOunces methods to accomplish
        // the conversions.
        private void Form1_Load(object sender, EventArgs e)
        {
            kilos = 10;
            for (int x = 10; x <= 25; x++)
            {
                KgToPounds(kilos);
                PoundsToOunces(pounds);
                outputListBox.Items.Add(kilos.ToString("n0"));
                kilos++;
                outputListBox.Items.Add(pounds.ToString("n2"));
                outputListBox.Items.Add(ounces.ToString("n2"));
                //could not figure out how to properly format.
            }
        }

        // This method called KgToPounds converts kilograms
        // to pounds given kilograms
        private double KgToPounds(double kilos)
        {
            pounds = kilos * 2.20462;
            return pounds;
        }

        // This method called PoundsToOunces converts pounds
        // to ounces given pounds
        private double PoundsToOunces(double pounds)
        {
            ounces = pounds * 16;
            return ounces;
        }
    }
}
