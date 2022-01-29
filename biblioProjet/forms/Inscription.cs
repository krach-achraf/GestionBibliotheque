using biblioProjet.securite;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace biblioProjet.forms
{
    public partial class Inscription : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";

        public Inscription()
        {
            InitializeComponent();
        }

        private void inscriptionBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);

            String matricule = matriculeTxt.Text;
            String nom = nomTxt.Text;
            String prenom = prenomTxt.Text;
            String email = emailTxt.Text;
            String password = Encrypt.EncodePassword(passwordTxt.Text);
            connection.Open();
            MySqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select count(*) from admins where email = @email;";
            cmd1.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetInt32(0) == 1)
                {
                    MessageBox.Show("Compte existe déja");
                    connection.Close();
                }
                else
                {
                    reader.Close();
                    MySqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = "insert into admins(matricule, nom, prenom, email, password) values(@matricule, @nom, @prenom, @email, @password)";
                    cmd2.Parameters.AddWithValue("@matricule", matricule);
                    cmd2.Parameters.AddWithValue("@nom", nom);
                    cmd2.Parameters.AddWithValue("@prenom", prenom);
                    cmd2.Parameters.AddWithValue("@email", email);
                    cmd2.Parameters.AddWithValue("@password", password);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Compte crée.");
                    Form1 loginF = new Form1();
                    this.Hide();
                    loginF.Show();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seConnecterBtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
