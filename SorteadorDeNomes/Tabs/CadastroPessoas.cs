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
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo, Email FROM Person", sqlCon);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);

                    ExibePessoasCadastro.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeInput.Text) || string.IsNullOrWhiteSpace(SexoComboBox.Text) || string.IsNullOrWhiteSpace(EmailInput.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM [dbo].[Person] WHERE [Email] = @Email";
                    cmd = new SqlCommand(query, sqlCon);
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
                    MessageBox.Show("Pessoa cadastrada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ExibePessoasCadastro.SelectedRows.Count > 0)
            {
                string email = ExibePessoasCadastro.SelectedRows[0].Cells["Email"].Value.ToString();

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connection))
                    {
                        sqlCon.Open();
                        string deleteQuery = "DELETE FROM [dbo].[Person] WHERE [Email] = @Email";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon);
                        deleteCommand.Parameters.AddWithValue("@Email", email);
                        deleteCommand.ExecuteNonQuery();

                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo, Email FROM Person", sqlCon);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                        ExibePessoasCadastro.DataSource = dt;

                        MessageBox.Show("Pessoa apagada com sucesso.");
                    }
                }
                catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para apagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
