using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades": showAceSpade(); break;
                case "10 of HEarts": showTenHearts(); break;
                case "King of Clubs": showKingClubs(); break;
            }
        }

        private void showAceSpade()
        {
            aceSPB.Visible = true;
            tenHPB.Visible = false;
            kingSPB.Visible = false;
        }


        private void showTenHearts()
        {
            tenHPB.Visible = true;
            aceSPB.Visible = false;
            kingSPB.Visible = false;

        }
        private void showKingClubs()
        {
            kingSPB.Visible = true;
            aceSPB.Visible = false;
            tenHPB.Visible = false;
        }



        private void showBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                ShowCard(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
