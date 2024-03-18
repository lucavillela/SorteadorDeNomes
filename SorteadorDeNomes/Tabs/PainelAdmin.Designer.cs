namespace SorteadorDeNomes
{
    partial class PainelAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeInputOp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SenhaInputOp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailInputOp = new System.Windows.Forms.TextBox();
            this.CadastroButtonOp = new System.Windows.Forms.Button();
            this.ExibeOperadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExibeOperadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Painel do Administrador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastrar Operadores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome do Operador";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NomeInputOp
            // 
            this.NomeInputOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeInputOp.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInputOp.Location = new System.Drawing.Point(35, 131);
            this.NomeInputOp.Name = "NomeInputOp";
            this.NomeInputOp.ShortcutsEnabled = false;
            this.NomeInputOp.Size = new System.Drawing.Size(302, 31);
            this.NomeInputOp.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SenhaInputOp
            // 
            this.SenhaInputOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SenhaInputOp.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaInputOp.Location = new System.Drawing.Point(367, 131);
            this.SenhaInputOp.Name = "SenhaInputOp";
            this.SenhaInputOp.ShortcutsEnabled = false;
            this.SenhaInputOp.Size = new System.Drawing.Size(277, 31);
            this.SenhaInputOp.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmailInputOp
            // 
            this.EmailInputOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInputOp.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInputOp.Location = new System.Drawing.Point(35, 198);
            this.EmailInputOp.Name = "EmailInputOp";
            this.EmailInputOp.Size = new System.Drawing.Size(302, 31);
            this.EmailInputOp.TabIndex = 19;
            this.EmailInputOp.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // CadastroButtonOp
            // 
            this.CadastroButtonOp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CadastroButtonOp.BackColor = System.Drawing.SystemColors.Menu;
            this.CadastroButtonOp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.CadastroButtonOp.FlatAppearance.BorderSize = 0;
            this.CadastroButtonOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastroButtonOp.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroButtonOp.Location = new System.Drawing.Point(419, 175);
            this.CadastroButtonOp.Name = "CadastroButtonOp";
            this.CadastroButtonOp.Size = new System.Drawing.Size(188, 54);
            this.CadastroButtonOp.TabIndex = 16;
            this.CadastroButtonOp.Text = "Cadastrar";
            this.CadastroButtonOp.UseVisualStyleBackColor = false;
            this.CadastroButtonOp.Click += new System.EventHandler(this.CadastroButtonOp_Click);
            // 
            // ExibeOperadores
            // 
            this.ExibeOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibeOperadores.Location = new System.Drawing.Point(35, 272);
            this.ExibeOperadores.Name = "ExibeOperadores";
            this.ExibeOperadores.RowHeadersWidth = 51;
            this.ExibeOperadores.RowTemplate.Height = 24;
            this.ExibeOperadores.Size = new System.Drawing.Size(609, 534);
            this.ExibeOperadores.TabIndex = 21;
            // 
            // PainelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ExibeOperadores);
            this.Controls.Add(this.CadastroButtonOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailInputOp);
            this.Controls.Add(this.SenhaInputOp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeInputOp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "PainelAdmin";
            this.Size = new System.Drawing.Size(682, 853);
            this.Load += new System.EventHandler(this.PainelAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExibeOperadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeInputOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenhaInputOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailInputOp;
        private System.Windows.Forms.Button CadastroButtonOp;
        private System.Windows.Forms.DataGridView ExibeOperadores;
    }
}
