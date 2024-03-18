using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDeNomes
{
    public partial class Resultado : Form
    {
        DataTable sorteadosTable;
        public Resultado(DataTable sorteadosTable)
        {
            InitializeComponent();
            resultGrid.DataSource = sorteadosTable;
            this.sorteadosTable = sorteadosTable;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog janelaSave = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx" })
            {
                if(janelaSave.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook excel = new XLWorkbook())
                        {
                            excel.Worksheets.Add(sorteadosTable, "Resultado_Sorteio");
                            excel.SaveAs(janelaSave.FileName);
                        }
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao salvar arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
