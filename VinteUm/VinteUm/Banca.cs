using System;
using System.Collections.Generic;
using System.Text;

namespace VinteUm
{
    internal class Banca : Jogador
    {
        private String nome;
        private int pontuacao = 0;
        private List<Carta> cartas;
        private Baralho baralho;
        bool trapaça = false;


        public Banca(Baralho Baralho, bool trapaca)
            :base("Banca")
        {
            this.baralho = Baralho;
            this.trapaça = trapaca;
        }

        public Banca(Baralho Baralho)
            :base("Banca")
        {
            this.baralho = Baralho;
        }

        public Baralho Baralho
        {
            get { return baralho; }
            set
            {
                baralho = Baralho;
            }
        }

        public Carta joga_sem_trapaça()
        {
            if (this.pontuacao < 18)
            {
                {
                    Carta carta = baralho.Retira_Carta_Aleatoria();

                    if (carta == null)
                    {
                        return null;
                    }

                    PegaCarta(carta);

                    return carta;
                }
            }
            else
                return null;
        }

        public Carta joga_com_trapaça()
        {
            Carta carta = new Carta();
            List<Carta> aux = this.baralho.Get_Cartas();

            carta = this.baralho.Retira_Carta_Aleatoria();
            if (this.pontuacao + carta.Peso > 21)
            {
                aux.Add(carta);
                this.baralho.Set_Cartas(aux.ToArray());
                return null;
            }
            else
            {
                this.PegaCarta(carta);
                return carta;
            }
        }

        public Carta joga_jogador()
        {
            return this.baralho.Retira_Carta_Aleatoria();
        }

        public Carta Jogar()
        {
            if (Pontuacao >= 17)
            {
                return null;
            }

            if (trapaça)
            {
                return joga_com_trapaça();
            }
            else
            {
                return joga_sem_trapaça();
            }
        }

    }

}