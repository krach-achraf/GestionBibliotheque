using biblioProjet.forms.stock;
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
    public partial class LivreForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        private int id;

        public LivreForm()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string cote = coteTxt.Text;
            string auteur = auteurTxt.Text;
            string titre = titreTxt.Text;
            string editeur = editeurTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmdCount = connection.CreateCommand();
            cmdCount.CommandText = "select count(*) " +
                "from livre, ouvrage " +
                "where ouvrage.idLivre = livre.id " +
                "and (titre = @titre) " +
                "or (edition = @edition and cote = @cote)";
            cmdCount.Parameters.AddWithValue("@titre", titre);
            cmdCount.Parameters.AddWithValue("@cote", cote);
            cmdCount.Parameters.AddWithValue("@edition", edition);
            MySqlDataReader reader = cmdCount.ExecuteReader();
            if (reader.Read() && reader.GetUInt32(0) > 0)            
                MessageBox.Show("Livre existe");
            else
            {
                reader.Close();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into livre(auteur, titre, editeur) values(@auteur, @titre, @editeur)";
                cmd.Parameters.AddWithValue("@auteur", auteur);
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.Parameters.AddWithValue("@editeur", editeur);
                cmd.ExecuteNonQuery();
                connection.Close();
                insrerOuvrage(cote, edition,  titre);
                MessageBox.Show("Livre ajouté.");
            }           
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editeurTxt.Clear();
            editionTxt.Clear();
        }

        private void insrerOuvrage(string cote, int edition, string titre)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select id from livre where titre =  @titre;";
            cmd1.Parameters.AddWithValue("@titre", titre);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into ouvrage(cote, edition, idLivre) values(@cote, @edition, @id)";
                cmd.Parameters.AddWithValue("@cote", cote);
                cmd.Parameters.AddWithValue("@edition", edition);
                cmd.Parameters.AddWithValue("@id", reader.GetInt32(0));
                reader.Close();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void loadLivres()
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select ouvrage.id, ouvrage.cote, ouvrage.edition, livre.titre, livre.auteur, livre.editeur " +
                "from livre, ouvrage " +
                "where livre.id = ouvrage.idLivre;";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridLivres.DataSource = data;
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            string reference = coteTxt.Text;
            string auteur = auteurTxt.Text;
            string titre = titreTxt.Text;
            string editeur = editeurTxt.Text;
            int edition = int.Parse(editionTxt.Text);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update ouvrage set cote = @cote, edition = @edition where id = @id";
            cmd.Parameters.AddWithValue("@reference", reference);
            cmd.Parameters.AddWithValue("@edition", edition);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            updateLivre(titre, auteur, editeur);

            id = 0;
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editeurTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
            MessageBox.Show("Livre modifié.");
        }

        private void updateLivre(string titre, string auteur, string editeur)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idLivre from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update livre set titre = @titre, auteur = @auteur, editeur = @editeur where id = @id";
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.Parameters.AddWithValue("@auteur", auteur);
                cmd.Parameters.AddWithValue("@editeur", editeur);
                cmd.Parameters.AddWithValue("@id", reader.GetInt32(0));
                reader.Close();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int idLivre;

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select idLivre from ouvrage where id =  @id;";
            cmd1.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                idLivre = reader.GetInt32(0);
                reader.Close();
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "delete from ouvrage where id = @id";
                cmd2.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd2.ExecuteNonQuery();
                    MySqlCommand cmd3 = connection.CreateCommand();
                    cmd3.CommandText = "delete from livre where id = @id";
                    cmd3.Parameters.AddWithValue("@id", idLivre);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Livre supprimé.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer ce livre");
                }
            }

            id = 0;
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editeurTxt.Clear();
            editionTxt.Clear();
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            MessageBox.Show("Livre supprimé.");
        }

        private void dataGridLivres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int i = dataGridLivres.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridLivres.Rows[i].Cells[0].Value.ToString());

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select ouvrage.id, ouvrage.cote, ouvrage.edition, livre.titre, livre.auteur, livre.editeur " +
                "from livre, ouvrage " +
                "where livre.id = ouvrage.idLivre and ouvrage.id = @id;";
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                coteTxt.Text = reader.GetString(1);
                editionTxt.Text = reader.GetInt32(2).ToString();
                titreTxt.Text = reader.GetString(3);
                auteurTxt.Text = reader.GetString(4);
                editeurTxt.Text = reader.GetString(5);
            }
            connection.Close();

            supprimerBtn.Enabled = true;
            modifierBtn.Enabled = true;
            ajouterBtn.Enabled = false;
        }

        private void afficherBtn_Click(object sender, EventArgs e)
        {
            loadLivres();
        }

        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            coteTxt.Clear();
            auteurTxt.Clear();
            titreTxt.Clear();
            editeurTxt.Clear();
            editionTxt.Clear();
            dataGridLivres.DataSource = null;
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
        }

         
        
    }
}
