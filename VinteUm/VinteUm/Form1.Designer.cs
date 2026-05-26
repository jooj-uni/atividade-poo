namespace VinteUm
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
            lblJogador = new Label();
            lblBanca = new Label();
            btnNovaCarta = new Button();
            btnParar = new Button();
            btnNovoJogo = new Button();
            btnNovoBaralho = new Button();
            panelJogador = new Panel();
            panelBanca = new Panel();
            label1 = new Label();
            lblpontjog = new Label();
            lblpontbanca = new Label();
            lblVitoriasJogador = new Label();
            lblVitoriasBanca = new Label();
            btnTrapaca = new Button();
            SuspendLayout();
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.Location = new Point(373, 601);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(61, 15);
            lblJogador.TabIndex = 0;
            lblJogador.Text = "Jogador: 0";
            // 
            // lblBanca
            // 
            lblBanca.AutoSize = true;
            lblBanca.Location = new Point(373, 23);
            lblBanca.Name = "lblBanca";
            lblBanca.Size = new Size(51, 15);
            lblBanca.TabIndex = 1;
            lblBanca.Text = "Banca: 0";
            // 
            // btnNovaCarta
            // 
            btnNovaCarta.Location = new Point(12, 619);
            btnNovaCarta.Name = "btnNovaCarta";
            btnNovaCarta.Size = new Size(131, 57);
            btnNovaCarta.TabIndex = 2;
            btnNovaCarta.Text = "Nova Carta";
            btnNovaCarta.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(166, 619);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(131, 57);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(657, 619);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(131, 57);
            btnNovoJogo.TabIndex = 4;
            btnNovoJogo.Text = "Nova Rodada";
            btnNovoJogo.UseVisualStyleBackColor = true;
            // 
            // btnNovoBaralho
            // 
            btnNovoBaralho.Location = new Point(498, 619);
            btnNovoBaralho.Name = "btnNovoBaralho";
            btnNovoBaralho.Size = new Size(131, 57);
            btnNovoBaralho.TabIndex = 5;
            btnNovoBaralho.Text = "Novo Jogo";
            btnNovoBaralho.UseVisualStyleBackColor = true;
            // 
            // panelJogador
            // 
            panelJogador.Location = new Point(12, 428);
            panelJogador.Name = "panelJogador";
            panelJogador.Size = new Size(577, 170);
            panelJogador.TabIndex = 6;
            // 
            // panelBanca
            // 
            panelBanca.Location = new Point(12, 41);
            panelBanca.Name = "panelBanca";
            panelBanca.Size = new Size(577, 170);
            panelBanca.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 262);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Placar";
            // 
            // lblpontjog
            // 
            lblpontjog.AutoSize = true;
            lblpontjog.Location = new Point(657, 322);
            lblpontjog.Name = "lblpontjog";
            lblpontjog.Size = new Size(52, 15);
            lblpontjog.TabIndex = 9;
            lblpontjog.Text = "Jogador:";
            // 
            // lblpontbanca
            // 
            lblpontbanca.AutoSize = true;
            lblpontbanca.Location = new Point(657, 293);
            lblpontbanca.Name = "lblpontbanca";
            lblpontbanca.Size = new Size(42, 15);
            lblpontbanca.TabIndex = 10;
            lblpontbanca.Text = "Banca:";
            // 
            // lblVitoriasJogador
            // 
            lblVitoriasJogador.AutoSize = true;
            lblVitoriasJogador.Location = new Point(715, 322);
            lblVitoriasJogador.Name = "lblVitoriasJogador";
            lblVitoriasJogador.Size = new Size(13, 15);
            lblVitoriasJogador.TabIndex = 11;
            lblVitoriasJogador.Text = "0";
            // 
            // lblVitoriasBanca
            // 
            lblVitoriasBanca.AutoSize = true;
            lblVitoriasBanca.Location = new Point(715, 293);
            lblVitoriasBanca.Name = "lblVitoriasBanca";
            lblVitoriasBanca.Size = new Size(13, 15);
            lblVitoriasBanca.TabIndex = 12;
            lblVitoriasBanca.Text = "0";
            // 
            // btnTrapaca
            // 
            btnTrapaca.Location = new Point(332, 619);
            btnTrapaca.Name = "btnTrapaca";
            btnTrapaca.Size = new Size(131, 57);
            btnTrapaca.TabIndex = 13;
            btnTrapaca.Text = "Trapacear";
            btnTrapaca.UseVisualStyleBackColor = true;
            btnTrapaca.Click += btnTrapaca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 688);
            Controls.Add(btnTrapaca);
            Controls.Add(lblVitoriasBanca);
            Controls.Add(lblVitoriasJogador);
            Controls.Add(lblpontbanca);
            Controls.Add(lblpontjog);
            Controls.Add(label1);
            Controls.Add(panelBanca);
            Controls.Add(lblJogador);
            Controls.Add(btnNovoBaralho);
            Controls.Add(btnNovoJogo);
            Controls.Add(btnNovaCarta);
            Controls.Add(panelJogador);
            Controls.Add(btnParar);
            Controls.Add(lblBanca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJogador;
        private Label lblBanca;
        private Button btnNovaCarta;
        private Button btnParar;
        private Button btnNovoJogo;
        private Button btnNovoBaralho;
        private Panel panelJogador;
        private Panel panelBanca;
        private Label label1;
        private Label lblpontjog;
        private Label lblpontbanca;
        private Label lblVitoriasJogador;
        private Label lblVitoriasBanca;
        private Button btnTrapaca;
    }
}
