using Catalogus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grootwarenhuis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NonFood food = new NonFood();
            food.Aankoopprijs = Convert.ToInt32(txtAankoopprijs.Text);
            food.BTW = Convert.ToDouble(cbBTW.Text) / 100;
            food.Naam = txtNaam.Text;
            food.ProdID = Convert.ToInt32(TxtProductID.Text);
            if(cbElektrisch.Checked==true)
            {
                food.Elektro = true;
            }
            MessageBox.Show(string.Format("De verkoopprijs van product {0} met als naam {1} heeft een verkoop prijs van {2} euro", TxtProductID.Text, txtNaam.Text, Convert.ToString(food.BerekenVerkoopprijs())));
        }
    }
}
