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
    public partial class AdherentsForm : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        private int id;

        public AdherentsForm()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            String CIN = cinTxt.Text;
            String nom = nomTxt.Text;
            String prenom = prenomTxt.Text;
            String numTel = numTelTxt.Text;
            String adresse = adresseTxt.Text;

            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select count(*) from adherents where (cin = @CIN) or (nom = @nom and prenom = @prenom)";
            cmd1.Parameters.AddWithValue("@CIN", CIN);
            cmd1.Parameters.AddWithValue("@nom", nom);
            cmd1.Parameters.AddWithValue("@prenom", prenom);
            MySqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                if(reader.GetInt32(0) == 0)
                {
                    reader.Close();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into adherents(CIN, nom, prenom, numero, adresse, etat) values(@CIN, @nom, @prenom, @numero , @adresse, @etat)";
                    cmd.Parameters.AddWithValue("@CIN", CIN);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@numero", numTel);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@etat", "débloqué");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adhérent ajouté.");
                }
                else
                {
                    MessageBox.Show("Adhérent existe.");
                }
            }

            connection.Close();
            
            nomTxt.Clear();
            cinTxt.Clear();
            prenomTxt.Clear();
            numTelTxt.Clear();
            adresseTxt.Clear();
        }

        private void dataGridAdherents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            int i = dataGridAdherents.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridAdherents.Rows[i].Cells[0].Value.ToString());

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select *" +
                "from adherents " +
                "where id = @id;";
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cinTxt.Text = reader.GetString("CIN");
                nomTxt.Text = reader.GetString("nom").ToString();
                prenomTxt.Text = reader.GetString("prenom");
                numTelTxt.Text = reader.GetString("numero");
                adresseTxt.Text = reader.GetString("adresse");
            }
            connection.Close();

            supprimerBtn.Enabled = true;
            modifierBtn.Enabled = true;
            ajouterBtn.Enabled = false;
            blocBtn.Enabled = true;
            deblocBtn.Enabled = true;
        }

        private void afficherBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select * from adherents;";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridAdherents.DataSource = data;
        }

        private void effacerBtn_Click(object sender, EventArgs e)
        {
            nomTxt.Clear();
            cinTxt.Clear();
            prenomTxt.Clear();
            numTelTxt.Clear();
            adresseTxt.Clear();
            dataGridAdherents.DataSource = null;
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            String CIN = cinTxt.Text;
            String nom = nomTxt.Text;
            String prenom = prenomTxt.Text;
            String numTel = numTelTxt.Text;
            String adresse = adresseTxt.Text;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update adherents set CIN = @CIN, nom = @nom, prenom = @prenom, numero = @numero, adresse = @adresse where id = @id";
            cmd.Parameters.AddWithValue("@CIN", CIN);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@numero", numTel);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();

            id = 0;
            nomTxt.Clear();
            cinTxt.Clear();
            prenomTxt.Clear();
            numTelTxt.Clear();
            adresseTxt.Clear();
            supprimerBtn.Enabled = false;
            ajouterBtn.Enabled = true;
            modifierBtn.Enabled = false;
            MessageBox.Show("Adhérent modifié.");
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            connection.Open();

            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "delete from adherents where id = @id";
            cmd2.Parameters.AddWithValue("@id", id);
            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Adhérent supprimé.");
            }catch(Exception ex)
            {
                MessageBox.Show("Impossible de supprimer l'adhérent.");
            }           

            id = 0;
            nomTxt.Clear();
            cinTxt.Clear();
            prenomTxt.Clear();
            numTelTxt.Clear();
            adresseTxt.Clear();
            supprimerBtn.Enabled = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;
        }

        private void blocBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select adherents.id, adherents.nom, adherents.prenom, adherents.numero from adherents where etat like ('bloqué');";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridAdherents.DataSource = data;
        }

        private void deblocBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            DataTable data = new DataTable();

            connection.Open();
            String request = "select adherents.id, adherents.nom, adherents.prenom, adherents.numero from adherents where etat like ('debloqué');";
            MySqlCommand cmd = new MySqlCommand(request, connection);
            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dataGridAdherents.DataSource = data;
        }
    }
}
