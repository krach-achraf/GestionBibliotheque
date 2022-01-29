using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioProjet.forms.stock
{
    public partial class StockForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id;

        public StockForm()
        {
            InitializeComponent();
            remplirLivres();
        }

        private void remplirLivres()
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            livreTxt.Items.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select ouvrage.cote, ouvrage.edition from ouvrage;";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                livreTxt.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
            }
            connection.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void augmenterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idOuvrage = 0, count = 0;

            String []livre = livreTxt.SelectedItem.ToString().Split('-');
            int quantite = int.Parse(quantiteTxt.Text);

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from ouvrage where cote = @cote;";
            cmd.Parameters.AddWithValue("cote", livre[0]);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idOuvrage = reader.GetInt32(0);
                reader.Close();
            }

            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select count(*) from stock where idOuvrage = @idOuvrage";
            cmd1.Parameters.AddWithValue("idOuvrage", idOuvrage);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                count = reader1.GetInt32(0);
                reader1.Close();
            }
            
            if(count > 0)
            {
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "update stock set quantite = quantite + @quantite where idOuvrage = @idOuvrage;";
                cmd2.Parameters.AddWithValue("quantite", quantite);
                cmd2.Parameters.AddWithValue("idOuvrage", idOuvrage);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Quantité ajoutée.");
                connection.Close();
            }
            else
            {
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "insert into stock (quantite,idOuvrage) values(@quantite, @idOuvrage);";
                cmd2.Parameters.AddWithValue("quantite", quantite);
                cmd2.Parameters.AddWithValue("idOuvrage", idOuvrage);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Quantité ajoutée.");
                connection.Close();
            }
            
        }

        private void diminuerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idOuvrage = 0, count = 0, quantiteStock = 0;

            String[] livre = livreTxt.SelectedItem.ToString().Split('-');
            int quantite = int.Parse(quantiteTxt.Text);

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from ouvrage where cote = @cote";
            cmd.Parameters.AddWithValue("cote", livre[0]);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idOuvrage = reader.GetInt32(0);
                reader.Close();
            }

            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select count(*) from stock where idOuvrage = @idOuvrage";
            cmd1.Parameters.AddWithValue("idOuvrage", idOuvrage);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                count = reader1.GetInt32(0);
                reader1.Close();
            }

            if (count > 0)
            {
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "select quantite from stock where idOuvrage = @idOuvrage";
                cmd2.Parameters.AddWithValue("idOuvrage", idOuvrage);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    quantiteStock = reader2.GetInt32(0);
                    reader2.Close();
                }
            }
            else
            {
                MessageBox.Show("Livre inexiste dans le stock.");
            }

            if(quantite <= quantiteStock)
            {
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "update stock set quantite = quantite - @quantite where idOuvrage = @idOuvrage;";
                cmd2.Parameters.AddWithValue("quantite", quantite);
                cmd2.Parameters.AddWithValue("idOuvrage", idOuvrage);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Quantité diminuée.");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Quantité insuffisante.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadStock();
        }

        private void loadStock()
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select ouvrage.id, ouvrage.cote, ouvrage.edition, stock.quantite " +
                "from stock, ouvrage " +
                "where ouvrage.id = stock.idOuvrage;";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridStock.DataSource = data;
        }

        private void effacerBtn_Click(object sender, EventArgs e)
        {
            quantiteTxt.Clear();
            dataGridStock.DataSource = null;
        }

       
    }
}
