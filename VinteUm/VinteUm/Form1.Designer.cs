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
            SuspendLayout();
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.Location = new Point(362, 508);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(61, 15);
            lblJogador.TabIndex = 0;
            lblJogador.Text = "Jogador: 0";
            // 
            // lblBanca
            // 
            lblBanca.AutoSize = true;
            lblBanca.Location = new Point(362, 23);
            lblBanca.Name = "lblBanca";
            lblBanca.Size = new Size(51, 15);
            lblBanca.TabIndex = 1;
            lblBanca.Text = "Banca: 0";
            // 
            // btnNovaCarta
            // 
            btnNovaCarta.Location = new Point(12, 529);
            btnNovaCarta.Name = "btnNovaCarta";
            btnNovaCarta.Size = new Size(131, 57);
            btnNovaCarta.TabIndex = 2;
            btnNovaCarta.Text = "Nova Carta";
            btnNovaCarta.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(220, 529);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(131, 57);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(657, 529);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(131, 57);
            btnNovoJogo.TabIndex = 4;
            btnNovoJogo.Text = "Novo Jogo";
            btnNovoJogo.UseVisualStyleBackColor = true;
            // 
            // btnNovoBaralho
            // 
            btnNovoBaralho.Location = new Point(429, 529);
            btnNovoBaralho.Name = "btnNovoBaralho";
            btnNovoBaralho.Size = new Size(131, 57);
            btnNovoBaralho.TabIndex = 5;
            btnNovoBaralho.Text = "Novo Baralho";
            btnNovoBaralho.UseVisualStyleBackColor = true;
            // 
            // panelJogador
            // 
            panelJogador.Location = new Point(12, 335);
            panelJogador.Name = "panelJogador";
            panelJogador.Size = new Size(776, 170);
            panelJogador.TabIndex = 6;
            // 
            // panelBanca
            // 
            panelBanca.Location = new Point(12, 41);
            panelBanca.Name = "panelBanca";
            panelBanca.Size = new Size(776, 170);
            panelBanca.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
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
    }
}
