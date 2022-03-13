namespace MediaNota
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNomeFilme = new System.Windows.Forms.Label();
            this.lblDataL = new System.Windows.Forms.Label();
            this.lblDataD = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularValor = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtDataL = new System.Windows.Forms.DateTimePicker();
            this.txtDataD = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeFilme
            // 
            this.lblNomeFilme.AutoSize = true;
            this.lblNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFilme.Location = new System.Drawing.Point(21, 122);
            this.lblNomeFilme.Name = "lblNomeFilme";
            this.lblNomeFilme.Size = new System.Drawing.Size(156, 25);
            this.lblNomeFilme.TabIndex = 1;
            this.lblNomeFilme.Text = "Nome do Filme";
            // 
            // lblDataL
            // 
            this.lblDataL.AutoSize = true;
            this.lblDataL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataL.Location = new System.Drawing.Point(12, 177);
            this.lblDataL.Name = "lblDataL";
            this.lblDataL.Size = new System.Drawing.Size(175, 25);
            this.lblDataL.TabIndex = 2;
            this.lblDataL.Text = "Data de Locação";
            // 
            // lblDataD
            // 
            this.lblDataD.AutoSize = true;
            this.lblDataD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataD.Location = new System.Drawing.Point(12, 221);
            this.lblDataD.Name = "lblDataD";
            this.lblDataD.Size = new System.Drawing.Size(195, 25);
            this.lblDataD.TabIndex = 3;
            this.lblDataD.Text = "Data de Devolução";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCpf.Location = new System.Drawing.Point(81, 78);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(46, 26);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(199, 78);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(125, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 20);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOCADORA";
            // 
            // btnCalcularValor
            // 
            this.btnCalcularValor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCalcularValor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcularValor.Location = new System.Drawing.Point(47, 355);
            this.btnCalcularValor.Name = "btnCalcularValor";
            this.btnCalcularValor.Size = new System.Drawing.Size(140, 42);
            this.btnCalcularValor.TabIndex = 11;
            this.btnCalcularValor.Text = "Calcular Valor";
            this.btnCalcularValor.UseVisualStyleBackColor = false;
            this.btnCalcularValor.Click += new System.EventHandler(this.BtnCalcularValor_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(222, 355);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(178, 42);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar Locação";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // txtDataL
            // 
            this.txtDataL.Location = new System.Drawing.Point(222, 177);
            this.txtDataL.Name = "txtDataL";
            this.txtDataL.Size = new System.Drawing.Size(226, 20);
            this.txtDataL.TabIndex = 13;
            // 
            // txtDataD
            // 
            this.txtDataD.Location = new System.Drawing.Point(222, 221);
            this.txtDataD.Name = "txtDataD";
            this.txtDataD.Size = new System.Drawing.Size(226, 20);
            this.txtDataD.TabIndex = 14;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(64, 275);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(63, 25);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 452);
            this.Controls.Add(this.txtDataD);
            this.Controls.Add(this.txtDataL);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCalcularValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataD);
            this.Controls.Add(this.lblDataL);
            this.Controls.Add(this.lblNomeFilme);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeFilme;
        private System.Windows.Forms.Label lblDataL;
        private System.Windows.Forms.Label lblDataD;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularValor;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DateTimePicker txtDataL;
        private System.Windows.Forms.DateTimePicker txtDataD;
        private System.Windows.Forms.Label lblValor;
    }
}

