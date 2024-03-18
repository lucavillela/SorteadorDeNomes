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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(682, 473);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SorteadorDeNomes.Properties.Resources.greenbgvert;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 473);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AdminButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CadastroButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SorteioButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.Window;
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(3, 93);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(194, 41);
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
            this.CadastroButton.Size = new System.Drawing.Size(194, 39);
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
            this.SorteioButton.Location = new System.Drawing.Point(3, 48);
            this.SorteioButton.Name = "SorteioButton";
            this.SorteioButton.Size = new System.Drawing.Size(194, 39);
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
            this.ClientSize = new System.Drawing.Size(882, 473);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador do Conselho de Justiça";
            this.panel1.ResumeLayout(false);
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
    }
}