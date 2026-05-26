using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        public bool TrapacaDetectada { get; private set; }

        public bool JogadorVenceu { get; private set; }

        private Random rnd = new Random(); 


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
            TrapacaDetectada = false;

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
            JogadorVenceu = false;

            if (TrapacaDetectada)
            {
                VitoriasBanca++;
                return "Rá viu a sua trapaça... você perdeu!";
            }

            if (RaioCosmico())
            {
                VitoriasBanca++;
                return "Um raio cósmico alterou alguns bits de memória. Infelizmente, você perdeu!";
            }

            if ((pJog > pBanca) && (pJog <= 21))
            {
                VitoriasJogador++;
                JogadorVenceu = true;
                return "Jogador venceu!";
            }
            else if (pJog > 21)
            {
                VitoriasBanca++;
                return "Jogador perdeu!";
            }
            else if (pBanca > 21)
            {
                VitoriasJogador++;
                JogadorVenceu = true;
                return "Jogador venceu!";
            }
            else if (pBanca >= pJog)
            {
                VitoriasBanca++;
                return "Banca venceu!";
            }

            return "O que aconteceu?? Não deveria chegar aqui...";
        }

        public void ReiniciarRodada()
        {
            Jogador = new Jogador("Jogador");
            Banca = new Banca(Baralho);
            TrapacaDetectada = false;
        }

        private bool RaioCosmico()
        {
            double raio = rnd.NextDouble();
            if (raio < 0.6)
            {
                return false;
            }
            else { return true; }
        }

        public Carta TrapacearJogador()
        { 
            if (rnd.NextDouble() < 0.4)
            {
                TrapacaDetectada = true;

                return null;
            }

            List<Carta> cartas = Baralho.Get_Cartas();

            List<Carta> cartasSeguras =
                new List<Carta>();

            foreach (Carta carta in cartas)
            {
                int valorTeste =
                    Jogador.Pontuacao + carta.Peso;

                if (carta.Valor == "A" &&
                    valorTeste > 21)
                {
                    valorTeste -= 10;
                }

                if (valorTeste <= 21)
                {
                    cartasSeguras.Add(carta);
                }
            }

            if (cartasSeguras.Count == 0)
            {
                return null;
            }

            Carta escolhida =
                cartasSeguras[
                    rnd.Next(cartasSeguras.Count)
                ];

            cartas.Remove(escolhida);

            Jogador.PegaCarta(escolhida);

            return escolhida;
        }

        public int CurseOfRa()
        {
            var idxcarta = new Random();

            if (rnd.NextDouble() < 0.5)
            {
                MessageBox.Show("A maldição de Rá caiu sobre você. Uma carta retornará ao pó. Mas você ainda uma chance... retire mais uma carta");
                VitoriasJogador--;
                int idx = idxcarta.Next(Jogador.Cartas.Count());

                Carta carta = Jogador.Cartas[idx];
                Jogador.Cartas.RemoveAt(idx);
                Jogador.Pontuacao -= carta.Peso;
                return idx;
            }
            return -1;
        }


    }
}