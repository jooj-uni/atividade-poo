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
            lblVitoriasJogador = new Label();
            lblVitoriasBanca = new Label();
            btnTrapaca = new Button();
            SuspendLayout();
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.BackColor = Color.Transparent;
            lblJogador.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJogador.ForeColor = Color.MistyRose;
            lblJogador.Location = new Point(373, 601);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(98, 14);
            lblJogador.TabIndex = 0;
            lblJogador.Text = "Jogador: 0";
            // 
            // lblBanca
            // 
            lblBanca.AutoSize = true;
            lblBanca.BackColor = Color.Transparent;
            lblBanca.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanca.ForeColor = Color.MistyRose;
            lblBanca.Location = new Point(373, 23);
            lblBanca.Name = "lblBanca";
            lblBanca.Size = new Size(79, 14);
            lblBanca.TabIndex = 1;
            lblBanca.Text = "Banca: 0";
            // 
            // btnNovaCarta
            // 
            btnNovaCarta.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaCarta.Location = new Point(76, 620);
            btnNovaCarta.Name = "btnNovaCarta";
            btnNovaCarta.Size = new Size(119, 57);
            btnNovaCarta.TabIndex = 2;
            btnNovaCarta.Text = "Nova Carta";
            btnNovaCarta.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            btnParar.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParar.Location = new Point(201, 620);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(119, 57);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoJogo.Location = new Point(626, 617);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(119, 57);
            btnNovoJogo.TabIndex = 4;
            btnNovoJogo.Text = "Nova Rodada";
            btnNovoJogo.UseVisualStyleBackColor = true;
            // 
            // btnNovoBaralho
            // 
            btnNovoBaralho.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoBaralho.Location = new Point(501, 617);
            btnNovoBaralho.Name = "btnNovoBaralho";
            btnNovoBaralho.Size = new Size(119, 57);
            btnNovoBaralho.TabIndex = 5;
            btnNovoBaralho.Text = "Novo Jogo";
            btnNovoBaralho.UseVisualStyleBackColor = true;
            // 
            // panelJogador
            // 
            panelJogador.BackColor = Color.Transparent;
            panelJogador.Location = new Point(41, 428);
            panelJogador.Name = "panelJogador";
            panelJogador.Size = new Size(577, 170);
            panelJogador.TabIndex = 6;
            // 
            // panelBanca
            // 
            panelBanca.BackColor = Color.Transparent;
            panelBanca.Location = new Point(41, 40);
            panelBanca.Name = "panelBanca";
            panelBanca.Size = new Size(577, 170);
            panelBanca.TabIndex = 7;
            // 
            // lblVitoriasJogador
            // 
            lblVitoriasJogador.AutoSize = true;
            lblVitoriasJogador.BackColor = Color.Transparent;
            lblVitoriasJogador.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitoriasJogador.ForeColor = Color.FromArgb(0, 0, 192);
            lblVitoriasJogador.Location = new Point(644, 409);
            lblVitoriasJogador.Name = "lblVitoriasJogador";
            lblVitoriasJogador.Size = new Size(28, 25);
            lblVitoriasJogador.TabIndex = 11;
            lblVitoriasJogador.Text = "0";
            // 
            // lblVitoriasBanca
            // 
            lblVitoriasBanca.AutoSize = true;
            lblVitoriasBanca.BackColor = Color.Transparent;
            lblVitoriasBanca.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitoriasBanca.ForeColor = Color.FromArgb(128, 64, 0);
            lblVitoriasBanca.Location = new Point(644, 355);
            lblVitoriasBanca.Name = "lblVitoriasBanca";
            lblVitoriasBanca.Size = new Size(28, 25);
            lblVitoriasBanca.TabIndex = 12;
            lblVitoriasBanca.Text = "0";
            // 
            // btnTrapaca
            // 
            btnTrapaca.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrapaca.Location = new Point(326, 618);
            btnTrapaca.Name = "btnTrapaca";
            btnTrapaca.Size = new Size(119, 57);
            btnTrapaca.TabIndex = 13;
            btnTrapaca.Text = "Trapacear";
            btnTrapaca.UseVisualStyleBackColor = true;
            btnTrapaca.Click += btnTrapaca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.madeira1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(804, 688);
            Controls.Add(btnNovoJogo);
            Controls.Add(btnNovoBaralho);
            Controls.Add(btnTrapaca);
            Controls.Add(btnNovaCarta);
            Controls.Add(lblVitoriasBanca);
            Controls.Add(lblVitoriasJogador);
            Controls.Add(panelBanca);
            Controls.Add(lblJogador);
            Controls.Add(panelJogador);
            Controls.Add(btnParar);
            Controls.Add(lblBanca);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
        private Label lblVitoriasJogador;
        private Label lblVitoriasBanca;
        private Button btnTrapaca;
    }
}
