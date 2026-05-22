using System;
using System.Collections.Generic;
using System.Text;

namespace VinteUm
{
    internal class Jogador
    {
        private string nome;
        private int pontuacao;
        private List<Carta> cartas;

        public Jogador(string nome)
        {
            this.nome = nome;
            cartas = new List<Carta>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Pontuacao
        {
            get { return pontuacao; }
            set { pontuacao = value; }
        }

        public List<Carta> Cartas
        {
            get { return cartas; }
        }

        public void PegaCarta(Carta carta)
        {
            cartas.Add(carta);

            pontuacao += carta.Peso;

            // Ajuste do Ás
            if (pontuacao > 21 && carta.Valor == "A")
            {
                pontuacao -= 10;
            }
        }

        public void Limpar()
        {
            cartas.Clear();
            pontuacao = 0;
        }
    }
}