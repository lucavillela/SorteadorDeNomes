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
    public partial class Form2 : Form
    {
        DataSet dataset;
        public Form2(DataSet dataset)
        {
            InitializeComponent();
            resultGrid.DataSource = dataset.Tables[1];
            this.dataset = dataset;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                            excel.Worksheets.Add(dataset.Tables[1], "Resultado_Sorteio");
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
    }
}
