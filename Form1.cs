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

namespace Szemelyek_Database_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listViewDb.View = View.Details;
            listViewDb.Columns.Add("Nev", 70, HorizontalAlignment.Left);
            listViewDb.Columns.Add("ID", 30, HorizontalAlignment.Left);

            listViewDb.View = View.Details;
            listViewDb.GridLines = true;
            listViewDb.FullRowSelect = true;
            dataGridViewDb.ColumnCount = 2;
            dataGridViewDb.Columns[0].Name = "nev"; //HeaderText
            dataGridViewDb.Columns[1].Name = "id";


        }

        static MySqlConnection connection;


        private void dBConnection()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "sql7.freemysqlhosting.net";
            sb.UserID = "sql7373844";
            sb.Password = "gD1Hn9IQqY";
            sb.Database = "sql7373844";

            connection = new MySqlConnection(sb.ToString());
            
            int dbRow = 0; // hanyadik rekordot dolgozza fel


            try
            {
                connection.Open();
                MySqlCommand sql = connection.CreateCommand();
                sql.CommandText = "SELECT `id`, `nev` FROM `dolgozo`;";

                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // ---------- listBox ----------

                        int id = dr.GetInt32("id");
                        string nev = dr.GetString("nev");
                        listBoxDb.Items.Add(id.ToString() + " " + nev.ToString());


                        // ---------- listView ----------

                        //object bugID = dr["ID"];
                        //object description = dr["Nev"];
                        string[] lv = new string[2];
                        ListViewItem items;
                        lv[0] = nev.ToString();
                        lv[1] = id.ToString();
                        items = new ListViewItem(lv);
                        listViewDb.Items.Add(items);



                        // ---------- dataGridView ----------

                        int index = dataGridViewDb.Rows.Add();
                        dataGridViewDb.Rows[index].Cells[0].Value = dr.GetString("nev");
                        dataGridViewDb.Rows[index].Cells[1].Value = dr.GetString("id");

                        // ---------- Label ----------

                        Label[] Nev = new Label[dbRow + 1];
                        Label[] ID = new Label[dbRow + 1];

                        Nev[dbRow] = new Label();
                        Nev[dbRow].Text = nev;
                        Nev[dbRow].Location = new Point(594, 85 + (dbRow * 28));
                        Nev[dbRow].AutoSize = true;
                        Nev[dbRow].Font = new Font("Ebrima", 10);
                        Nev[dbRow].ForeColor = Color.Red;
                        Nev[dbRow].Name = "nev" + dbRow.ToString();
                        this.Controls.Add(Nev[dbRow]);

                        ID[dbRow] = new Label();
                        ID[dbRow].Text = id.ToString();
                        ID[dbRow].Location = new Point(674, 85 + (dbRow * 28));
                        ID[dbRow].AutoSize = true;
                        ID[dbRow].Font = new Font("Ebrima", 10);
                        ID[dbRow].ForeColor = Color.Blue;
                        ID[dbRow].Name = "ID" + dbRow.ToString();
                        this.Controls.Add(ID[dbRow]);

                        dbRow++;
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
            }
            finally
            {

            }
        }


        private void listBoxDbSelectedItem()
        {
            string asd = listBoxDb.SelectedItem.ToString();
            string dsa = asd.Substring(2, asd.Length - 2);
            MessageBox.Show(dsa, "SelectedItem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void listViewDbSelectedItems()
        {
            string asd = listViewDb.SelectedItems[0].Text.ToString(); // SelectedItems[0].SubItems[0].Text
            MessageBox.Show(asd, "SelectedItem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("ID: " + listViewDb.SelectedItems[0].SubItems[1].Text);
        }



        // --------------- MenuItems ---------------

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listBoxDb.Items.Clear();
            listViewDb.Items.Clear();

            dBConnection();
        }

        private void btnListBoxViewSelectedItem_Click(object sender, EventArgs e)
        {
            listBoxDbSelectedItem();
        }

        private void btnListViewViewSelectedItem_Click(object sender, EventArgs e)
        {
            listViewDbSelectedItems();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }



        // --------------- MenuItems ---------------

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxDb.Items.Clear();
            listViewDb.Items.Clear();
            dBConnection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripListBoxSelectedItem_Click(object sender, EventArgs e)
        {
            listBoxDbSelectedItem();
        }

        private void toolStripListViewSelectedItem_Click(object sender, EventArgs e)
        {
            listViewDbSelectedItems();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
