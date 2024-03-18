namespace SorteadorDeNomes
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HistButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.CadastroButton = new System.Windows.Forms.Button();
            this.SorteioButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(682, 853);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SorteadorDeNomes.Properties.Resources.greenbgvert;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 853);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sair";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HistButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CadastroButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SorteioButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 195);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HistButton
            // 
            this.HistButton.BackColor = System.Drawing.SystemColors.Window;
            this.HistButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistButton.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistButton.Location = new System.Drawing.Point(3, 147);
            this.HistButton.Name = "HistButton";
            this.HistButton.Size = new System.Drawing.Size(194, 45);
            this.HistButton.TabIndex = 3;
            this.HistButton.Text = "Histórico";
            this.HistButton.UseVisualStyleBackColor = false;
            this.HistButton.Click += new System.EventHandler(this.HistButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.Window;
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(3, 99);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(194, 42);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Painel Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // CadastroButton
            // 
            this.CadastroButton.BackColor = System.Drawing.SystemColors.Window;
            this.CadastroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CadastroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastroButton.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroButton.Location = new System.Drawing.Point(3, 3);
            this.CadastroButton.Name = "CadastroButton";
            this.CadastroButton.Size = new System.Drawing.Size(194, 42);
            this.CadastroButton.TabIndex = 0;
            this.CadastroButton.Text = "Cadastrar Pessoas";
            this.CadastroButton.UseVisualStyleBackColor = false;
            this.CadastroButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SorteioButton
            // 
            this.SorteioButton.BackColor = System.Drawing.SystemColors.Window;
            this.SorteioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SorteioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SorteioButton.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SorteioButton.Location = new System.Drawing.Point(3, 51);
            this.SorteioButton.Name = "SorteioButton";
            this.SorteioButton.Size = new System.Drawing.Size(194, 42);
            this.SorteioButton.TabIndex = 1;
            this.SorteioButton.Text = "Sortear";
            this.SorteioButton.UseVisualStyleBackColor = false;
            this.SorteioButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador do Conselho de Justiça";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CadastroButton;
        private System.Windows.Forms.Button SorteioButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button HistButton;
        private System.Windows.Forms.Label label1;
    }
}