namespace SorteadorDeNomes.Tabs
{
    partial class CadastroPessoas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.ExibePessoasCadastro = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SorteadorDeNomes.DatabaseDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.personTableAdapter = new SorteadorDeNomes.DatabaseDataSetTableAdapters.PersonTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExibePessoasCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastrar Pessoas";
            // 
            // NomeInput
            // 
            this.NomeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeInput.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInput.Location = new System.Drawing.Point(32, 102);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.ShortcutsEnabled = false;
            this.NomeInput.Size = new System.Drawing.Size(277, 31);
            this.NomeInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.SexoComboBox.Location = new System.Drawing.Point(349, 104);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(302, 29);
            this.SexoComboBox.Sorted = true;
            this.SexoComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sexo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CadastrarButton.BackColor = System.Drawing.SystemColors.Menu;
            this.CadastrarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.CadastrarButton.FlatAppearance.BorderSize = 0;
            this.CadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarButton.Location = new System.Drawing.Point(411, 145);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(201, 54);
            this.CadastrarButton.TabIndex = 9;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = false;
            this.CadastrarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExibePessoasCadastro
            // 
            this.ExibePessoasCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibePessoasCadastro.Location = new System.Drawing.Point(32, 222);
            this.ExibePessoasCadastro.Name = "ExibePessoasCadastro";
            this.ExibePessoasCadastro.RowHeadersWidth = 51;
            this.ExibePessoasCadastro.RowTemplate.Height = 24;
            this.ExibePessoasCadastro.Size = new System.Drawing.Size(619, 228);
            this.ExibePessoasCadastro.TabIndex = 13;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInput.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(32, 168);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(277, 31);
            this.EmailInput.TabIndex = 14;
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.ExibePessoasCadastro);
            this.Controls.Add(this.CadastrarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeInput);
            this.Name = "CadastroPessoas";
            this.Size = new System.Drawing.Size(682, 473);
            ((System.ComponentModel.ISupportInitialize)(this.ExibePessoasCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.DataGridView ExibePessoasCadastro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailInput;
    }
}
