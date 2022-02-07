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
    public partial class yugiohForm : Form
    {
        public yugiohForm()
        {
            InitializeComponent();
            fill_listbox();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Enter))
            {

                btnInsertCard.PerformClick();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void fill_listbox()
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "show tables in yugioh;";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string tableName = myReader.GetString("Tables_in_yugioh");
                    listBox1.Items.Add(tableName);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "select * from yugioh." + txtFindSet.Text + " where cardNumber='" + listBox1.Text + "';";
                //MessageBox.Show(query);

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sNumber = myReader.GetString("cardNumber");
                    string sName = myReader.GetString("cardName");
                    string sSet = myReader.GetInt32("setCard").ToString();
                    string sExtras = myReader.GetInt32("extras").ToString();
                    txtCardNumber.Text = sNumber;
                    txtCardName.Text = sName;
                    txtSetCard.Text = sSet;
                    txtExtras.Text = sExtras;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSetClick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "create table yugioh." + txtAddSet.Text + " (" +
                    "cardNumber varchar(45) not null," +
                    "cardName varchar(45) not null," +
                    "setCard int not null," +
                    "extras int not null," +
                    "primary key (cardNumber));";
                MessageBox.Show(query);
                MySqlCommand TableCommand = new MySqlCommand(query, myConn);

                myConn.Open();
                TableCommand.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findSetClick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "select * from yugioh." + txtFindSet.Text;
                //MessageBox.Show(query);

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                listBox1.Items.Clear();

                while (myReader.Read())
                {
                    string sNumber = myReader.GetString("cardNumber");
                    //string sName = myReader.GetString("cardName");
                    listBox1.Items.Add(sNumber/* + " | " + sName*/);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateClick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "update yugioh." + txtFindSet.Text + " set cardNumber='"
                    + this.txtCardNumber.Text + "', cardName='"
                    + this.txtCardName.Text + "', setCard="
                    + this.txtSetCard.Text + ", extras="
                    + this.txtExtras.Text + " where cardNumber='"
                    + this.txtCardNumber.Text + "';";

                MessageBox.Show(query);
                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertClick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=6210;username=root;password=password;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "insert into yugioh." + txtFindSet.Text + " (cardNumber, cardName, setCard, extras) values ('"
                    + this.txtCardNumber.Text + "', '"
                    + this.txtCardName.Text + "', "
                    + this.txtSetCard.Text + ", "
                    + this.txtExtras.Text + ");";
                MessageBox.Show(query);
                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                { }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSetsClick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                fill_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yugiohForm_Load(object sender, EventArgs e)
        {

        }
    }
}
