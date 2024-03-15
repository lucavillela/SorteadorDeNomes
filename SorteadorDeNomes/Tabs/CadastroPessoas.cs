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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo FROM Person", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                ExibePessoasCadastro.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                cmd = new SqlCommand("INSERT INTO [dbo].[Person] ([Name], [Sex], [Email]) VALUES ('"+NomeInput.Text.ToString()+ "', '"+SexoComboBox.Text.ToString()+ "', '"+EmailInput.Text.ToString()+"')", sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo FROM Person", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                ExibePessoasCadastro.DataSource = dt;
                MessageBox.Show("Valor inserido");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
