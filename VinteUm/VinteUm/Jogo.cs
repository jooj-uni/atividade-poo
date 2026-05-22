using System;
using System.Collections.Generic;
using System.Text;

namespace VinteUm
{
    internal class Jogo
    {
        public Baralho Baralho { get; private set; }

        public Jogador Jogador { get; private set; }

        public Banca Banca { get; private set; }

        public bool JogoFinalizado { get; private set; }

        public int VitoriasBanca { get; private set; }

        public int VitoriasJogador { get; private set; }


        public Jogo()
        {
            IniciarNovoJogo();
        }

        public void IniciarNovoJogo()
        {
            Carta c = new Carta();

            Baralho = new Baralho(c.ValoresValidos, c.NaipesValidos);

            Jogador = new Jogador("Jogador");

            Banca = new Banca(Baralho);

            JogoFinalizado = false;

            VitoriasBanca = 0;
            VitoriasJogador = 0;
        }

        public Carta PedirCartaJogador()
        {
            Carta carta = Baralho.Retira_Carta_Aleatoria();

            if (carta == null)
            {
                return null;
            }

            Jogador.PegaCarta(carta);

            return carta;
        }

        public List<Carta> JogadaBanca()
        {
            List<Carta> cartasCompradas = new List<Carta>();

            while (Banca.Pontuacao < 17)
            {
                Carta carta = Banca.Jogar();

                if (carta == null)
                {
                    break;
                }

                cartasCompradas.Add(carta);
            }

            return cartasCompradas;
        }

        public string VerificarResultado()
        {
            int pJog = Jogador.Pontuacao;
            int pBanca = Banca.Pontuacao;

            if (pJog > 21)
            {
                VitoriasBanca++;
                return "Jogador perdeu!";
            }

            else if (pBanca > 21)
            {
                VitoriasJogador++;
                return "Jogador venceu!";
            }

            else if (pBanca >= pJog)
            {
                VitoriasBanca++;
                return "Banca venceu!";
            }

            VitoriasJogador++;
            return "Jogador venceu!";
        }

        public void ReiniciarRodada()
        {
            Jogador = new Jogador("Jogador");
            Banca = new Banca(Baralho);
        }
    }
}