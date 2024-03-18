using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SorteadorDeNomes.Tabs
{
    public partial class Historico : UserControl
    {
        DataTable history;
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucat\source\repos\SorteadorDeNomes\SorteadorDeNomes\Database.mdf;Integrated Security = True";

        public Historico()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT h.DateTime AS Data, h.Justification AS Justificativa, a.Email_OP AS 'Email do Usuário' FROM History h INNER JOIN Access a ON h.Access_id = a.Access_id;", sqlCon);
                    history = new DataTable();
                    sqlDa.Fill(history);

                    ExibeHistorico.DataSource = history;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar dados do histórico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog janelaSave = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (janelaSave.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook excel = new XLWorkbook())
                        {
                            excel.Worksheets.Add(history, "Histórico"); 
                            excel.SaveAs(janelaSave.FileName);
                        }
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
