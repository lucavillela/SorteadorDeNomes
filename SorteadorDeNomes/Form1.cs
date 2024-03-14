using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDeNomes
{
    public partial class Form1 : Form
    {
        public DataSet dataset = new DataSet();
        List<Pessoa> pessoasASortear = new List<Pessoa>();
        List<Pessoa> pessoasSorteadas = new List<Pessoa>();
        List<Pessoa> mulheres = new List<Pessoa>();
        Random random = new Random();
        DataTable pessoaTable = new DataTable("Pessoa");
        FileStream fileStream;

        public Form1()
        {
            InitializeComponent();
            pessoaTable.Columns.Add("Nome", typeof(string));
            pessoaTable.Columns.Add("Sexo", typeof(string));
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            //ImportaExcel();
            //if (dataset != null && dataset.Tables.Count < 2)
            //{
            //    dataset.Tables.Add(pessoaTable);
            //}
        }

        private void ImportaExcel()
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
                    dataset = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    baseTableGrid.DataSource = dataset.Tables[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataset.Tables.Count < 1)
            {
                MessageBox.Show("É preciso importar uma planilha para fazer o sorteio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((int)numPessoasSortear.Value < 1)
            {
                MessageBox.Show("Escolha a quantidade de pessoas a serem sorteadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ExtraiDadosDaTabela();

                fileStream.Close();

                if (mulheres.Count < numPessoasSortear.Value/2)
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

        private void ExtraiDadosDaTabela() 
        {
            if (dataset.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
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
            for (int i = 0; i < numPessoasSortear.Value / 2; i++)
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
            for (int i = 0; i < numPessoasSortear.Value - valorFaltante; i++)
            {
                int randomIndex = random.Next(0, pessoasASortear.Count);
                Pessoa pessoaSorteada = pessoasASortear[randomIndex];

                pessoasASortear.Remove(pessoaSorteada);
                pessoasSorteadas.Add(pessoaSorteada);
            }
        }

        private void PovoaGridComSorteados(List<Pessoa> pessoasSorteadas)
        {
            pessoaTable.Clear();

            foreach (Pessoa pessoa in pessoasSorteadas)
            {
                DataRow row = pessoaTable.NewRow();
                row["Nome"] = pessoa.GetNome();
                row["Sexo"] = pessoa.GetSexo();
                pessoaTable.Rows.Add(row);
            }

            Form2 form2 = new Form2(dataset);
            form2.Show();
            //baseTableGrid.DataSource = dataset.Tables[1];
        }

        private void LimpaDados()
        {
            pessoasASortear.Clear();
            pessoasSorteadas.Clear();
            mulheres.Clear();
        }
    }
}
