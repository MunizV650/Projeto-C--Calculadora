namespace Projeto_Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnIgual;
            this.label1 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            btnIgual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIgual
            // 
            btnIgual.BackColor = System.Drawing.Color.Silver;
            btnIgual.Location = new System.Drawing.Point(192, 226);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new System.Drawing.Size(90, 50);
            btnIgual.TabIndex = 4;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textResultado.Location = new System.Drawing.Point(12, 38);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(358, 43);
            this.textResultado.TabIndex = 1;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.Location = new System.Drawing.Point(12, 132);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(90, 50);
            this.btnQuatro.TabIndex = 2;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.Location = new System.Drawing.Point(192, 132);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(90, 50);
            this.btnSeis.TabIndex = 3;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Silver;
            this.btnSoma.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(280, 132);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(90, 50);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.Location = new System.Drawing.Point(12, 179);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(90, 50);
            this.btnUm.TabIndex = 6;
            this.btnUm.Text = "1";
            this.btnUm.UseMnemonic = false;
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.Location = new System.Drawing.Point(103, 179);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(90, 50);
            this.btnDois.TabIndex = 7;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btntres
            // 
            this.btntres.BackColor = System.Drawing.SystemColors.GrayText;
            this.btntres.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btntres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntres.Location = new System.Drawing.Point(192, 179);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(90, 50);
            this.btntres.TabIndex = 8;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = false;
            this.btntres.Click += new System.EventHandler(this.btntres_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.Location = new System.Drawing.Point(103, 132);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(90, 50);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSete.Location = new System.Drawing.Point(12, 87);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(90, 50);
            this.btnSete.TabIndex = 10;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOito.Location = new System.Drawing.Point(101, 87);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(90, 50);
            this.btnOito.TabIndex = 11;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNove.Location = new System.Drawing.Point(192, 87);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(90, 50);
            this.btnNove.TabIndex = 12;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.Silver;
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.Location = new System.Drawing.Point(280, 179);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(90, 50);
            this.btnSubtracao.TabIndex = 13;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.Silver;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicacao.Location = new System.Drawing.Point(280, 87);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(90, 50);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Silver;
            this.btnDivisao.Location = new System.Drawing.Point(280, 226);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(90, 50);
            this.btnDivisao.TabIndex = 15;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(12, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(103, 226);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(90, 50);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSubtracao);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btntres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDois);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUm);
            this.panel1.Controls.Add(this.textResultado);
            this.panel1.Controls.Add(this.btnDivisao);
            this.panel1.Controls.Add(this.btnMultiplicacao);
            this.panel1.Controls.Add(this.btnSete);
            this.panel1.Controls.Add(this.btnCinco);
            this.panel1.Controls.Add(this.btnOito);
            this.panel1.Controls.Add(btnIgual);
            this.panel1.Controls.Add(this.btnNove);
            this.panel1.Controls.Add(this.btnSoma);
            this.panel1.Controls.Add(this.btnQuatro);
            this.panel1.Controls.Add(this.btnSeis);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 314);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "by Marcelo Muniz Júnior @Insted";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcuadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textResultado;
        private Button btnQuatro;
        private Button btnSeis;
        private Button btnSoma;
        private Button btnUm;
        private Button btnDois;
        private Button btntres;
        private Button btnCinco;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnClear;
        private Button btnZero;
        private Panel panel1;
        private Label label2;
    }
}