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

namespace biblioProjet.forms
{
    public partial class PeriodiqueForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        private int id;

        public PeriodiqueForm()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string cote = coteTxt.Text;
            string numero = numeroTxt.Text;
            string nom = nomTxt.Text;
            string periodicite = periodiciteTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmdCount = connection.CreateCommand();
            cmdCount.CommandText = "select count(*) " +
                "from périodique, ouvrage " +
                "where ouvrage.idPeriodique = périodique.id " +
                "and (nom = @nom) " +
                "or (edition = @edition and cote = @cote)";
            cmdCount.Parameters.AddWithValue("@nom", nom);
            cmdCount.Parameters.AddWithValue("@cote", cote);
            cmdCount.Parameters.AddWithValue("@edition", edition);
            MySqlDataReader reader = cmdCount.ExecuteReader();
            if (reader.Read() && reader.GetUInt32(0) > 0)
                MessageBox.Show("Périodique existe");
            else
            {
                reader.Close();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into périodique(numero, nom, periodicite) values(@numero, @nom, @periodicite)";
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@periodicite", periodicite);
                cmd.ExecuteNonQuery();
                connection.Close();
                insrerOuvrage(cote, edition, nom);
                MessageBox.Show("Périodique ajouté.");
            }
            coteTxt.Clear();
            numeroTxt.Clear();
            nomTxt.Clear();
            periodiciteTxt.Clear();
            editionTxt.Clear();
        }

        private void insrerOuvrage(string cote, int edition, string nom)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select id from périodique where nom =  @nom;";
            cmd1.Parameters.AddWithValue("@nom", nom);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into ouvrage(cote, edition, idPeriodique) values(@cote, @edition, @id)";
                cmd.Parameters.AddWithValue("@cote", cote);
                cmd.Parameters.AddWithValue("@edition", edition);
                cmd.Parameters.AddWithValue("@id", reader.GetInt32(0));
                reader.Close();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void afficherBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select ouvrage.id, ouvrage.cote, ouvrage.edition, périodique.numero, périodique.nom, périodique.periodicite " +
                "from périodique, ouvrage " +
                "where périodique.id = ouvrage.idPeriodique;";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridPeriodiques.DataSource = data;
        }

        private void effacerBtn_Click(object sender, EventArgs e)
        {
            coteTxt.Clear();
            numeroTxt.Clear();
            nomTxt.Clear();
            periodiciteTxt.Clear();
            editionTxt.Clear();
            dataGridPeriodiques.DataSource = null;
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
        }

        private void dataGridPeriodiques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int i = dataGridPeriodiques.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridPeriodiques.Rows[i].Cells[0].Value.ToString());

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select ouvrage.id, ouvrage.cote, ouvrage.edition, périodique.numero, périodique.nom, périodique.periodicite " +
                "from périodique, ouvrage " +
                "where périodique.id = ouvrage.idPeriodique and ouvrage.id = @id;";
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                coteTxt.Text = reader.GetString(1);
                editionTxt.Text = reader.GetString(2);
                numeroTxt.Text = reader.GetInt32(3).ToString();
                nomTxt.Text = reader.GetString(4);
                periodiciteTxt.Text = reader.GetString(4);
            }
            connection.Close();

            supprimerBtn.Enabled = true;
            modifierBtn.Enabled = true;
            ajouterBtn.Enabled = false;
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string cote = coteTxt.Text;
            int numero = int.Parse(numeroTxt.Text);
            string nom = nomTxt.Text;
            string periodicite = periodiciteTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update ouvrage set cote = @cote, edition = @edition where id = @id";
            cmd.Parameters.AddWithValue("@cote", cote);
            cmd.Parameters.AddWithValue("@edition", edition);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            updateLivre(numero, nom, periodicite);

            MessageBox.Show("Périodique modifié.");
            id = 0;
            coteTxt.Clear();
            numeroTxt.Clear();
            nomTxt.Clear();
            periodiciteTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
        }

        private void updateLivre(int numero, string nom, string periodicite)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idPeriodique from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update périodique set numero = @numero, nom = @nom, periodicite = @periodicite where id = @id";
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@periodicite", periodicite);
                cmd.Parameters.AddWithValue("@id", reader.GetInt32(0));
                reader.Close();
                cmd.ExecuteNonQuery();
                connection.Close();               
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idPeriodique;

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idPeriodique from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                idPeriodique = reader.GetInt32(0);
                reader.Close();
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "delete from ouvrage where id = @id";
                cmd2.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd2.ExecuteNonQuery();
                    MySqlCommand cmd3 = connection.CreateCommand();
                    cmd3.CommandText = "delete from périodique where id = @id";
                    cmd3.Parameters.AddWithValue("@id", idPeriodique);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Périodique supprimé.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer cette périodique.");
                }
            }

            id = 0;
            coteTxt.Clear();
            numeroTxt.Clear();
            nomTxt.Clear();
            periodiciteTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
        }
    }
}
