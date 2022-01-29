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
    public partial class CdForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        private int id;

        public CdForm()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string cote = coteTxt.Text;
            string auteur = auteurTxt.Text;
            string titre = titreTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmdCount = connection.CreateCommand();
            cmdCount.CommandText = "select count(*) " +
                "from cd, ouvrage " +
                "where ouvrage.idCd = cd.id " +
                "and (titre = @titre) " +
                "or (edition = @edition and cote = @cote)";
            cmdCount.Parameters.AddWithValue("@titre", titre);
            cmdCount.Parameters.AddWithValue("@cote", cote);
            cmdCount.Parameters.AddWithValue("@edition", edition);
            MySqlDataReader reader = cmdCount.ExecuteReader();
            if (reader.Read() && reader.GetUInt32(0) > 0)
                MessageBox.Show("Cd existe");
            else
            {
                reader.Close();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into cd(auteur, titre) values(@auteur, @titre)";
                cmd.Parameters.AddWithValue("@auteur", auteur);
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.ExecuteNonQuery();
                connection.Close();
                insrerOuvrage(cote, edition, titre);
                MessageBox.Show("Cd ajouté.");
            }
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editionTxt.Clear();
        }

        private void insrerOuvrage(string cote, int edition, string titre)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select id from cd where titre =  @titre;";
            cmd1.Parameters.AddWithValue("@titre", titre);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into ouvrage(cote, edition, idCd) values(@cote, @edition, @id)";
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
            String request = "select ouvrage.id, ouvrage.cote, ouvrage.edition, cd.titre, cd.auteur from cd, ouvrage where cd.id = ouvrage.idCd;";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridCds.DataSource = data;
        }

        private void effacerBtn_Click(object sender, EventArgs e)
        {
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editionTxt.Clear();
            dataGridCds.DataSource = null;
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string cote = coteTxt.Text;
            string auteur = auteurTxt.Text;
            string titre = titreTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update ouvrage set cote = @cote, edition = @edition where id = @id";
            cmd.Parameters.AddWithValue("@cote", cote);
            cmd.Parameters.AddWithValue("@edition", edition);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            updateCd(titre, auteur);
            MessageBox.Show("Cd modifié");
            id = 0;
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
        }

        private void updateCd(string titre, string auteur)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idCd from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update cd set titre = @titre, auteur = @auteur where id = @id";
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.Parameters.AddWithValue("@auteur", auteur);
                cmd.Parameters.AddWithValue("@id", reader.GetInt32(0));
                reader.Close();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void dataGridCds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int i = dataGridCds.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridCds.Rows[i].Cells[0].Value.ToString());

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select ouvrage.id, ouvrage.cote, ouvrage.edition, cd.titre, cd.auteur " +
                "from cd, ouvrage " +
                "where cd.id = ouvrage.idCd and ouvrage.id = @id;";
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                coteTxt.Text = reader.GetString(1);
                editionTxt.Text = reader.GetString(2);
                titreTxt.Text = reader.GetString(3);
                auteurTxt.Text = reader.GetString(4);
            }
            connection.Close();

            supprimerBtn.Enabled = true;
            ajouterBtn.Enabled = false;
            modifierBtn.Enabled = true;
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idCd;

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idCd from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                idCd = reader.GetInt32(0);
                reader.Close();
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "delete from ouvrage where id = @id";
                cmd2.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd2.ExecuteNonQuery();
                    MySqlCommand cmd3 = connection.CreateCommand();
                    cmd3.CommandText = "delete from cd where id = @id";
                    cmd3.Parameters.AddWithValue("@id", idCd);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("CD supprimé.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer ce CD");
                }
            }

            id = 0;
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
        }
    }
}
