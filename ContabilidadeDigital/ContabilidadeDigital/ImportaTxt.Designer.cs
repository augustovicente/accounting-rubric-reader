namespace ContabilidadeDigital
{
    partial class ImportaTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportaTxt));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArquivoSelecionado = new System.Windows.Forms.Label();
            this.btnGeraRelatorio = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionar.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelecionar.Location = new System.Drawing.Point(524, 32);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(138, 43);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o arquivo pra gerar o relatório:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do arquivo selecionado:";
            // 
            // lblArquivoSelecionado
            // 
            this.lblArquivoSelecionado.AutoSize = true;
            this.lblArquivoSelecionado.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoSelecionado.Location = new System.Drawing.Point(367, 139);
            this.lblArquivoSelecionado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblArquivoSelecionado.Name = "lblArquivoSelecionado";
            this.lblArquivoSelecionado.Size = new System.Drawing.Size(0, 20);
            this.lblArquivoSelecionado.TabIndex = 6;
            // 
            // btnGeraRelatorio
            // 
            this.btnGeraRelatorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGeraRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeraRelatorio.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraRelatorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGeraRelatorio.Location = new System.Drawing.Point(286, 265);
            this.btnGeraRelatorio.Name = "btnGeraRelatorio";
            this.btnGeraRelatorio.Size = new System.Drawing.Size(198, 43);
            this.btnGeraRelatorio.TabIndex = 7;
            this.btnGeraRelatorio.Text = "Gerar Relatório";
            this.btnGeraRelatorio.UseVisualStyleBackColor = false;
            this.btnGeraRelatorio.Click += new System.EventHandler(this.btnGeraRelatorio_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolta.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolta.Location = new System.Drawing.Point(34, 265);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(198, 43);
            this.btnVolta.TabIndex = 8;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.Filter = "\"Text|*.txt";
            // 
            // ImportaTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 379);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnGeraRelatorio);
            this.Controls.Add(this.lblArquivoSelecionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ImportaTxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo relatório";
            this.Leave += new System.EventHandler(this.ImportaTxt_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArquivoSelecionado;
        private System.Windows.Forms.Button btnGeraRelatorio;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}