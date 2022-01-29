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
    public partial class EmpruntForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        private int id;

        public EmpruntForm()
        {
            InitializeComponent();
            loadAdherents();
            loadOuvrages();
            checkDate();
        }

        private void checkDate()
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id, dateFin, etat from emprunt;";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetDateTime(1) < DateTime.Now && reader.GetString(2).Equals("emprunté"))
                {
                    blocAdherent(reader.GetInt32(0));
                    changeEtat(reader.GetInt32(0));
                }
            }
            connection.Close();
        }

        private void blocAdherent(int id)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update adherents set etat = 'bloqué' where id = (select idAdherent from emprunt where id = @id)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void changeEtat(int id)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update emprunt set etat = 'à rendre' where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void loadAdherents()
        {
            adherentTxt.Items.Clear();
            MySqlConnection connection = new MySqlConnection(parametres);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select nom, prenom from adherents where id not in (select idadherent from emprunt where etat like 'emprunté' or etat like 'à rendre')";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                adherentTxt.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
            }
            connection.Close();
        }

        private void loadOuvrages()
        {
            ouvrageTxt.Items.Clear();
            MySqlConnection connection = new MySqlConnection(parametres);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select cote, edition from ouvrage where id in (select idOuvrage from stock where quantite > 0)";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ouvrageTxt.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
            }
            connection.Close();

        }

        private void emprunterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idAdherent, idOuvrage;
            string[] cotes = ouvrageTxt.SelectedItem.ToString().Split('-');
            string[] adherents = adherentTxt.SelectedItem.ToString().Split(' ');

            string cote = cotes[0];
            string edition = cotes[1];
            string nom = adherents[0];
            string prenom = adherents[1];
            DateTime dateFin = dateFinTxt.Value;

            if (dateFin > DateTime.Now)
            {
                connection.Open();
                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandText = "select id from ouvrage where cote =  @cote and edition = @edition;";
                cmd1.Parameters.AddWithValue("@cote", cote);
                cmd1.Parameters.AddWithValue("@edition", edition);
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    idOuvrage = reader1.GetInt32(0);
                    reader1.Close();
                    MySqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = "select id from adherents where nom = @nom and prenom = @prenom;";
                    cmd2.Parameters.AddWithValue("@nom", nom);
                    cmd2.Parameters.AddWithValue("@prenom", prenom);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        idAdherent = reader2.GetInt32(0);
                        reader2.Close();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "insert into emprunt(idOuvrage, Idadherent, dateDebut, dateFin, etat) values(@ouvrage, @adherent, @dateDebut, @dateFin, 'emprunté')";
                        cmd.Parameters.AddWithValue("@ouvrage", idOuvrage);
                        cmd.Parameters.AddWithValue("@adherent", idAdherent);
                        cmd.Parameters.AddWithValue("@dateDebut", DateTime.Now);
                        cmd.Parameters.AddWithValue("@dateFin", dateFin);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ouvrage emprunté");
                        updateStockMoins(idOuvrage);
                        connection.Close();
                    }
                }
                loadAdherents();
                loadOuvrages();
            }
            else {
                MessageBox.Show("Date fin invalide");
            }
            
        }

        private void updateStockMoins(int idOuvrage)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update stock set quantite = quantite - 1 where idOuvrage = @idouvrage";
            cmd.Parameters.AddWithValue("@idouvrage", idOuvrage);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateStockPlus(int idOuvrage)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update stock set quantite = quantite + 1 where idOuvrage = @idouvrage";
            cmd.Parameters.AddWithValue("@idouvrage", idOuvrage);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void rendreBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update emprunt set etat = 'rendu' where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Changement effectué.");

            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "update adherents set etat = 'debloqué' where id = (select idAdherent from emprunt where id = @id)";
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.ExecuteNonQuery();

            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "select idOuvrage from emprunt where id = @id";
            cmd2.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                updateStockPlus(reader.GetInt32(0));
            }
                
            connection.Close();
        }

        private void afficherBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select emprunt.id, adherents.nom, adherents.prenom , ouvrage.cote, ouvrage.edition, emprunt.dateDebut, emprunt.dateFin, emprunt.etat " +
                "from emprunt, ouvrage, adherents " +
                "where emprunt.idOuvrage = ouvrage.id and emprunt.idadherent = adherents.id ";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridEmprunts.DataSource = data;

        }

        private void effacerBtn_Click(object sender, EventArgs e)
        {
            dataGridEmprunts.DataSource = null;
            rendreBtn.Enabled = false;
            emprunterBtn.Enabled = true;
        }

        private void aRendreBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select emprunt.id, adherents.nom, adherents.prenom , ouvrage.cote, ouvrage.edition, emprunt.dateDebut, emprunt.dateFin " +
                "from emprunt, ouvrage, adherents " +
                "where emprunt.idOuvrage = ouvrage.id and emprunt.idadherent = adherents.id " +
                "and emprunt.etat = 'à rendre'";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridEmprunts.DataSource = data;
        }

        private void empruntésBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select emprunt.id, adherents.nom, adherents.prenom , ouvrage.cote, ouvrage.edition, emprunt.dateDebut, emprunt.dateFin " +
                "from emprunt, ouvrage, adherents " +
                "where emprunt.idOuvrage = ouvrage.id and emprunt.idadherent = adherents.id " +
                "and emprunt.etat = 'emprunté'";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridEmprunts.DataSource = data;
        }

        private void dataGridEmprunts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridEmprunts.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridEmprunts.Rows[i].Cells[0].Value.ToString());

            rendreBtn.Enabled = true;
            emprunterBtn.Enabled = false;
        }
    }
}
