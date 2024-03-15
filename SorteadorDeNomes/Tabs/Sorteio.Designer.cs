namespace SorteadorDeNomes.Tabs
{
    partial class Sorteio
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
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SorteadorDeNomes.DatabaseDataSet();
            this.SorteioButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessTableAdapter = new SorteadorDeNomes.DatabaseDataSetTableAdapters.AccessTableAdapter();
            this.personTableAdapter = new SorteadorDeNomes.DatabaseDataSetTableAdapters.PersonTableAdapter();
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SorteadorDeNomes.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ExibePessoasSorteio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExibePessoasSorteio)).BeginInit();
            this.SuspendLayout();
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SorteioButton
            // 
            this.SorteioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SorteioButton.BackColor = System.Drawing.SystemColors.Menu;
            this.SorteioButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.SorteioButton.FlatAppearance.BorderSize = 0;
            this.SorteioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SorteioButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SorteioButton.Location = new System.Drawing.Point(422, 356);
            this.SorteioButton.Name = "SorteioButton";
            this.SorteioButton.Size = new System.Drawing.Size(148, 44);
            this.SorteioButton.TabIndex = 15;
            this.SorteioButton.Text = "Sortear";
            this.SorteioButton.UseVisualStyleBackColor = false;
            this.SorteioButton.Click += new System.EventHandler(this.SorteioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pessoas a sortear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sorteio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(37, 356);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 31);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Número de sorteados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // accessBindingSource
            // 
            this.accessBindingSource.DataMember = "Access";
            this.accessBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "Person";
            this.personBindingSource1.DataSource = this.databaseDataSetBindingSource;
            // 
            // accessBindingSource1
            // 
            this.accessBindingSource1.DataMember = "Access";
            this.accessBindingSource1.DataSource = this.databaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = this.accessTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = SorteadorDeNomes.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataMember = "Person";
            this.personBindingSource2.DataSource = this.databaseDataSet;
            // 
            // ExibePessoasSorteio
            // 
            this.ExibePessoasSorteio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibePessoasSorteio.Location = new System.Drawing.Point(37, 93);
            this.ExibePessoasSorteio.Name = "ExibePessoasSorteio";
            this.ExibePessoasSorteio.RowHeadersWidth = 51;
            this.ExibePessoasSorteio.RowTemplate.Height = 24;
            this.ExibePessoasSorteio.Size = new System.Drawing.Size(533, 222);
            this.ExibePessoasSorteio.TabIndex = 23;
            // 
            // Sorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ExibePessoasSorteio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SorteioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Sorteio";
            this.Size = new System.Drawing.Size(600, 432);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExibePessoasSorteio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SorteioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private DatabaseDataSetTableAdapters.AccessTableAdapter accessTableAdapter;
        private DatabaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.BindingSource accessBindingSource1;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private System.Windows.Forms.DataGridView ExibePessoasSorteio;
    }
}
