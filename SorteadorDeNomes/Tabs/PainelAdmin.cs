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

namespace SorteadorDeNomes
{
    public partial class PainelAdmin : UserControl
    {
        private string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucat\source\repos\SorteadorDeNomes\SorteadorDeNomes\Database.mdf;Integrated Security=True";

        public PainelAdmin()
        {
            InitializeComponent();
            PopulateOperatorsGrid();
        }

        private void CadastroButtonOp_Click(object sender, EventArgs e)
        {
            string user = NomeInputOp.Text.Trim();
            string password = SenhaInputOp.Text.Trim();
            string email = EmailInputOp.Text.Trim();

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM [dbo].[Access] WHERE [user] = @User";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@User", user);
                    int existingRecordsCount = (int)cmd.ExecuteScalar();

                    if (existingRecordsCount > 0)
                    {
                        MessageBox.Show("Este operador já está cadastrado.");
                        return;
                    }
                    query = "INSERT INTO [dbo].[Access] ([user], [password], [Email_OP], [Type]) VALUES (@User, @Password, @Email, 'op')";
                    cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@User", user);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Operador cadastrado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar dados do Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateOperatorsGrid()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    string query = "SELECT [user] as Usuario, [Email_OP] as Email FROM [dbo].[Access] WHERE [Type] = 'op'";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    ExibeOperadores.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar dados do Banco de Dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PainelAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
