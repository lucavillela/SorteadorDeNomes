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

namespace SorteadorDeNomes.Tabs
{
    public partial class Sorteio : UserControl
    {
        List<Pessoa> pessoasASortear = new List<Pessoa>();
        List<Pessoa> pessoasSorteadas = new List<Pessoa>();
        List<Pessoa> mulheres = new List<Pessoa>();
        Random random = new Random();
        DataTable dt = new DataTable();
        DataTable sorteadosTable = new DataTable("Sorteados");
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucat\source\repos\SorteadorDeNomes\SorteadorDeNomes\Database.mdf;Integrated Security = True";
        public Sorteio()
        {
            InitializeComponent();
            sorteadosTable.Columns.Add("Nome", typeof(string));
            sorteadosTable.Columns.Add("Sexo", typeof(string));
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name as Nome, Sex as Sexo FROM Person", sqlCon);
                sqlDa.Fill(dt);

                ExibePessoasSorteio.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.FillBy(this.databaseDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.FillBy1(this.databaseDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SorteioButton_Click(object sender, EventArgs e)
        {
            if ((int)NumPessoasSorteio.Value < 1)
            {
                MessageBox.Show("Escolha a quantidade de pessoas a serem sorteadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ExtraiDadosDaTabela();
                if (mulheres.Count < (int)Math.Floor(NumPessoasSorteio.Value / 2))
                {
                    MessageBox.Show("Não foi possível realizar o sorteio! Pelo menos 50% da lista precisa ser Mulher", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SorteiaMulheres();
                int valorFaltante = pessoasSorteadas.Count;
                SorteiaResto(valorFaltante);
                PovoaGridComSorteados(pessoasSorteadas);
                LimpaDados();
            }
        }

        private void Sorteio_Load(object sender, EventArgs e)
        {

        }

        private void ExtraiDadosDaTabela()
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string gridNomeValue = row.Field<string>(0);
                    string gridSexoValue = row.Field<string>(1);
                    if (gridNomeValue != null && gridSexoValue != null)
                    {
                        Pessoa pessoa = new Pessoa();
                        pessoa.SetNome(gridNomeValue);
                        pessoa.SetSexo(gridSexoValue);
                        pessoasASortear.Add(pessoa);
                    }
                }
                mulheres = pessoasASortear.Where(p => p.GetSexo().ToLower().Equals("feminino")).ToList();
            }
            else
            {
                MessageBox.Show("A tabela está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SorteiaMulheres()
        {
            for (int i = 0; i < NumPessoasSorteio.Value / 2; i++)
            {
                int randomIndex = random.Next(0, mulheres.Count);
                Pessoa pessoaSorteada = mulheres[randomIndex];

                pessoasSorteadas.Add(pessoaSorteada);

                mulheres.RemoveAt(randomIndex);
                pessoasASortear.Remove(pessoaSorteada);

            }
        }

        private void SorteiaResto(int valorFaltante)
        {
            for (int i = 0; i < NumPessoasSorteio.Value - valorFaltante; i++)
            {
                int randomIndex = random.Next(0, pessoasASortear.Count);
                Pessoa pessoaSorteada = pessoasASortear[randomIndex];

                pessoasASortear.Remove(pessoaSorteada);
                pessoasSorteadas.Add(pessoaSorteada);
            }
        }

        private void PovoaGridComSorteados(List<Pessoa> pessoasSorteadas)
        {
            sorteadosTable.Clear();

            foreach (Pessoa pessoa in pessoasSorteadas)
            {
                DataRow row = sorteadosTable.NewRow();
                row["Nome"] = pessoa.GetNome();
                row["Sexo"] = pessoa.GetSexo();
                sorteadosTable.Rows.Add(row);
            }

            Resultado form2 = new Resultado(sorteadosTable);
            form2.Show();
        }

        private void LimpaDados()
        {
            pessoasASortear.Clear();
            pessoasSorteadas.Clear();
            mulheres.Clear();
        }
    }
}
