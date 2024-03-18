using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SorteadorDeNomes
{
    public partial class login : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucat\source\repos\SorteadorDeNomes\SorteadorDeNomes\Database.mdf;Integrated Security = True";
        public login()
        {
            InitializeComponent();
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            string username = InputUser.Text;
            string password = InputPassword.Text;
            string userType = "";
            int userID = 0;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Access_id, [type] FROM [dbo].[Access] WHERE [user] = @Username AND [password] = @Password", sqlCon);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userID = Convert.ToInt32(reader["Access_id"]);
                            userType = reader["type"].ToString();
                        }

                        main main = new main(userType, userID.ToString());
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
