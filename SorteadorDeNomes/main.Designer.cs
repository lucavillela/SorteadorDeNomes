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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SorteioTab = new System.Windows.Forms.Button();
            this.CadastrarTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.PanelCadastro = new System.Windows.Forms.Panel();
            this.PanelSorteio = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AccessButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputUser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelCadastro.SuspendLayout();
            this.PanelSorteio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SorteadorDeNomes.Properties.Resources.greenbgvert;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SorteioTab, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CadastrarTab, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 134);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // SorteioTab
            // 
            this.SorteioTab.BackColor = System.Drawing.SystemColors.Window;
            this.SorteioTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SorteioTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SorteioTab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SorteioTab.Location = new System.Drawing.Point(3, 70);
            this.SorteioTab.Name = "SorteioTab";
            this.SorteioTab.Size = new System.Drawing.Size(191, 61);
            this.SorteioTab.TabIndex = 1;
            this.SorteioTab.Text = "Sortear";
            this.SorteioTab.UseVisualStyleBackColor = false;
            this.SorteioTab.Click += new System.EventHandler(this.SorteioTab_Click);
            // 
            // CadastrarTab
            // 
            this.CadastrarTab.BackColor = System.Drawing.SystemColors.Window;
            this.CadastrarTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CadastrarTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarTab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarTab.Location = new System.Drawing.Point(3, 3);
            this.CadastrarTab.Name = "CadastrarTab";
            this.CadastrarTab.Size = new System.Drawing.Size(191, 61);
            this.CadastrarTab.TabIndex = 0;
            this.CadastrarTab.Text = "Cadastrar Pessoas";
            this.CadastrarTab.UseVisualStyleBackColor = false;
            this.CadastrarTab.Click += new System.EventHandler(this.CadastrarTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Auditoria Militar \r\ndo Estado da Bahia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(724, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(77, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // PanelCadastro
            // 
            this.PanelCadastro.Controls.Add(this.PanelSorteio);
            this.PanelCadastro.Controls.Add(this.AccessButton);
            this.PanelCadastro.Controls.Add(this.comboBox1);
            this.PanelCadastro.Controls.Add(this.label4);
            this.PanelCadastro.Controls.Add(this.label3);
            this.PanelCadastro.Controls.Add(this.InputUser);
            this.PanelCadastro.Controls.Add(this.dataGridView1);
            this.PanelCadastro.Controls.Add(this.label2);
            this.PanelCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelCadastro.Location = new System.Drawing.Point(196, 0);
            this.PanelCadastro.Name = "PanelCadastro";
            this.PanelCadastro.Size = new System.Drawing.Size(604, 450);
            this.PanelCadastro.TabIndex = 6;
            // 
            // PanelSorteio
            // 
            this.PanelSorteio.Controls.Add(this.button3);
            this.PanelSorteio.Controls.Add(this.label6);
            this.PanelSorteio.Controls.Add(this.numericUpDown1);
            this.PanelSorteio.Controls.Add(this.label5);
            this.PanelSorteio.Location = new System.Drawing.Point(3, 0);
            this.PanelSorteio.Name = "PanelSorteio";
            this.PanelSorteio.Size = new System.Drawing.Size(602, 450);
            this.PanelSorteio.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(434, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sortear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número de pessoas a sortear";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(26, 133);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(382, 31);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sortear";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AccessButton
            // 
            this.AccessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessButton.BackColor = System.Drawing.SystemColors.Menu;
            this.AccessButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.AccessButton.FlatAppearance.BorderSize = 0;
            this.AccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessButton.Location = new System.Drawing.Point(252, 193);
            this.AccessButton.Name = "AccessButton";
            this.AccessButton.Size = new System.Drawing.Size(110, 39);
            this.AccessButton.TabIndex = 11;
            this.AccessButton.Text = "Cadastrar";
            this.AccessButton.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox1.Location = new System.Drawing.Point(309, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 29);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // InputUser
            // 
            this.InputUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUser.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUser.Location = new System.Drawing.Point(29, 132);
            this.InputUser.Name = "InputUser";
            this.InputUser.Size = new System.Drawing.Size(255, 31);
            this.InputUser.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 168);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastrar Pessoas";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelCadastro.ResumeLayout(false);
            this.PanelCadastro.PerformLayout();
            this.PanelSorteio.ResumeLayout(false);
            this.PanelSorteio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SorteioTab;
        private System.Windows.Forms.Button CadastrarTab;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelCadastro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AccessButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelSorteio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}