using biblioProjet.forms;
using biblioProjet.securite;
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

namespace biblioProjet
{
    public partial class Form1 : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seConnecterBtn_Click(object sender, EventArgs e)
        {
            /*  MySqlConnection connection = new MySqlConnection(parametres);
              connection.Open();

              string email = emailTxt.Text;
              string password = passwordTxt.Text;
              erreurUsername.Visible = false;
              erreurMdp.Visible = false;
              MySqlCommand cmd1 = connection.CreateCommand();
              cmd1.CommandText = "select * from admins where email =  @email ";
              cmd1.Parameters.AddWithValue("@email", email);
              MySqlDataReader reader = cmd1.ExecuteReader();

              if (!reader.Read())
              {
                  connection.Close();
                  erreurUsername.Visible = true;
                  emailTxt.Clear();
              }
              else
              {
                  if (password.Equals(Encrypt.DecodePassword(reader.GetString("password"))))
                  {
                      connection.Close();
                      Home home = new Home();
                      this.Hide();
                      home.Show();
                  }
                  else
                  {
                      connection.Close();
                      erreurMdp.Visible = true;
                      passwordTxt.Clear();
                  }
              }*/
            string login = loginTxt.Text;
            string password = passwordTxt.Text;
            if (login == "achrafKr" && password == "123456")
            {
                
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                passwordTxt.Clear();
                erreurMdp.Visible = true;
                loginTxt.Clear();
                erreurUsername.Visible = true;
            }                      
        }       
    }
}
