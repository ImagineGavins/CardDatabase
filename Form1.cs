using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CardDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectClick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();
                MessageBox.Show("Connected");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected");
                MessageBox.Show(ex.Message);
            }
        }


        private void YGOButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();

                MessageBox.Show("Loading Yu-Gi-Oh");
                this.Hide();
                yugiohForm f2 = new CardDatabase.yugiohForm();
                f2.ShowDialog();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MTGButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();

                MessageBox.Show("Loading Magic: The Gathering");
                this.Hide();
                magicForm f4 = new CardDatabase.magicForm();
                f4.ShowDialog();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PokemonButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();

                MessageBox.Show("Loading Pokemon");
                this.Hide();
                pokemonForm f3 = new CardDatabase.pokemonForm();
                f3.ShowDialog();

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
