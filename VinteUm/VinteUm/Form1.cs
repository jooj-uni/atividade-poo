using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VinteUm
{
    public partial class Form1 : Form
    {
        private Jogo jogo;

        private List<PictureBox> cartasNaTela = new();

        private int posXJogador = 50;
        private int posXBanca = 50;

        private bool jogoEncerrado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new Jogo();

            // Eventos dos BOTÕES (agora são Buttons)
            btnNovaCarta.Click += btnNovaCarta_Click;
            btnParar.Click += btnParar_Click;
            btnNovoJogo.Click += btnNovoJogo_Click;
            btnNovoBaralho.Click += btnNovoBaralho_Click;

            AtualizarPontuacao();
        }

        private void btnNovaCarta_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado)
                return;

            Carta carta = jogo.PedirCartaJogador();

            if (carta == null)
            {
                MessageBox.Show(
                    "O baralho acabou! Inicie um novo baralho."
                );

                jogoEncerrado = true;

                return;
            }

            MostrarCartaJogador(carta);

            AtualizarPontuacao();

            if (jogo.Jogador.Pontuacao > 21)
            {
                MessageBox.Show("Você perdeu!");
                jogoEncerrado = true;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado)
                return;

            List<Carta> cartasBanca = jogo.JogadaBanca();

            foreach (Carta carta in cartasBanca)
            {
                MostrarCartaBanca(carta);
            }

            AtualizarPontuacao();

            MessageBox.Show(jogo.VerificarResultado());

            jogoEncerrado = true;
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            jogoEncerrado = false;

            jogo.ReiniciarRodada();

            LimparMesa();

            AtualizarPontuacao();

        }


        private void btnNovoBaralho_Click(object sender, EventArgs e)
        {
            jogoEncerrado = false;

            jogo.IniciarNovoJogo();

            LimparMesa();

            AtualizarPontuacao();
        }

        private void MostrarCartaJogador(Carta carta)
        {
            PictureBox pb = new PictureBox();

            pb.Parent = panelJogador;
            pb.Size = new Size(90, 130);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = Image.FromFile(carta.Path);
            pb.Location = new Point(posXJogador, 10);

            panelJogador.Controls.Add(pb);

            cartasNaTela.Add(pb);

            pb.BringToFront();

            posXJogador += 30;
        }

        private void MostrarCartaBanca(Carta carta)
        {
            PictureBox pb = new PictureBox();

            pb.Parent = panelBanca;
            pb.Size = new Size(90, 130);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = Image.FromFile(carta.Path);
            pb.Location = new Point(posXBanca, 10);

            panelBanca.Controls.Add(pb);

            cartasNaTela.Add(pb);

            pb.BringToFront();

            posXBanca += 30;
        }
        private void AtualizarPontuacao()
        {
            lblJogador.Text = $"Jogador: {jogo.Jogador.Pontuacao}";
            lblBanca.Text = $"Banca: {jogo.Banca.Pontuacao}";
        }

        private void LimparMesa()
        {
            foreach (PictureBox pb in cartasNaTela)
            {
                panelJogador.Controls.Remove(pb);
                panelBanca.Controls.Remove(pb);
                pb.Dispose();
            }

            cartasNaTela.Clear();

            posXJogador = 50;
            posXBanca = 50;
        }
    }
}