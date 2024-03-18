using SorteadorDeNomes.Tabs;
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
    public partial class main : Form
    {
         private string userID, userType;

        public main(string userType, string userID)
        {
            InitializeComponent();
            this.userType = userType;
            this.userID = userID;

            if (userType == "admin")
            {
                AdminButton.Visible = true;
                HistButton.Visible = true;
            }
            else if (userType == "op")
            {
                AdminButton.Visible = false;
                HistButton.Visible = false;
            }

            Sorteio sorteio = new Sorteio(userID);
            addUserControl(sorteio);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroPessoas cadastroPessoas = new CadastroPessoas();
            addUserControl(cadastroPessoas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorteio sorteio = new Sorteio(userID);
            addUserControl(sorteio);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            PainelAdmin painelAdmin = new PainelAdmin();
            addUserControl(painelAdmin);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HistButton_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            addUserControl(historico);
        }
    }
}
