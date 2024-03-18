using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDeNomes.Tabs
{
    public partial class CadastroPessoas : UserControl
    {
        SqlCommand cmd;
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucat\source\repos\SorteadorDeNomes\SorteadorDeNomes\Database.mdf;Integrated Security = True";
        public CadastroPessoas()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo, Email FROM Person", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                ExibePessoasCadastro.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeInput.Text) || string.IsNullOrWhiteSpace(SexoComboBox.Text) || string.IsNullOrWhiteSpace(EmailInput.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(*) FROM [dbo].[Person] WHERE [Name] = @Name AND [Sex] = @Sex AND [Email] = @Email";
                cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@Name", NomeInput.Text);
                cmd.Parameters.AddWithValue("@Sex", SexoComboBox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailInput.Text);
                int existingRecordsCount = (int)cmd.ExecuteScalar();

                if (existingRecordsCount > 0)
                {
                    MessageBox.Show("Pessoa já cadastrada.");
                    return;
                }

                cmd = new SqlCommand("INSERT INTO [dbo].[Person] ([Name], [Sex], [Email]) VALUES (@Name, @Sex, @Email)", sqlCon);
                cmd.Parameters.AddWithValue("@Name", NomeInput.Text);
                cmd.Parameters.AddWithValue("@Sex", SexoComboBox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailInput.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo, Email FROM Person", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                ExibePessoasCadastro.DataSource = dt;
                MessageBox.Show("Valor inserido com sucesso.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
