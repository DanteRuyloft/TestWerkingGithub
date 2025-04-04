using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalogus;

namespace Grootwarenhuis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVerkoopprijs_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Aankoopprijs = Convert.ToInt32(TxtAankoopprijs.Text);
            food.BTW = Convert.ToDouble(CbBTW.Text)/100;
            food.Naam = TxtNaam.Text;
            food.ProdID = Convert.ToInt32(txtProductID.Text);
            food.Vervaldatum = dtpHoudbaarheidsDatum.Value;
            MessageBox.Show(string.Format("De verkoopprijs van product {0} met als naam {1} heeft een verkoop prijs van {2} euro", txtProductID.Text, TxtNaam.Text,Convert.ToString(food.BerekenVerkoopprijs())));
        }
    }
}
