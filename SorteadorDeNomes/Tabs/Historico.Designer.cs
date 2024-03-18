namespace SorteadorDeNomes.Tabs
{
    partial class Historico
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
            this.label2 = new System.Windows.Forms.Label();
            this.ExibeHistorico = new System.Windows.Forms.DataGridView();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExibeHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Histórico de Sorteios";
            // 
            // ExibeHistorico
            // 
            this.ExibeHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibeHistorico.Location = new System.Drawing.Point(43, 103);
            this.ExibeHistorico.Name = "ExibeHistorico";
            this.ExibeHistorico.RowHeadersWidth = 51;
            this.ExibeHistorico.RowTemplate.Height = 24;
            this.ExibeHistorico.Size = new System.Drawing.Size(597, 629);
            this.ExibeHistorico.TabIndex = 5;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(236, 761);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(200, 54);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "Exportar";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ExibeHistorico);
            this.Controls.Add(this.label2);
            this.Name = "Historico";
            this.Size = new System.Drawing.Size(682, 853);
            ((System.ComponentModel.ISupportInitialize)(this.ExibeHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ExibeHistorico;
        private System.Windows.Forms.Button ExportButton;
    }
}
