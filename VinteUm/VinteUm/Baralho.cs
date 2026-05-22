using System;
using System.Collections.Generic;
using System.Text;

namespace VinteUm
{
    internal class Baralho
    {
        private List<string> valores_validos = null;
        private List<string> naipes_validos = null;
        private List<Carta> cartas = null;
        private Random rnd = new Random();

        public void Set_ValoresValidos(string[] _valores_validos)
        {
            foreach (var valor in _valores_validos)
            {
                this.Get_ValoresValidos().Add(valor);
            }
        }
        public List<string> Get_ValoresValidos()
        {
            return this.valores_validos;
        }

        public List<string> Get_NaipesValidos()
        {
            return this.naipes_validos;
        }

        public void Set_NaipesValidos(string[] _naipes_validos)
        {
            foreach (var naipe in _naipes_validos)
            {
                this.Get_NaipesValidos().Add(naipe);
            }
        }

        public void Set_Cartas(Carta[] _cartas)
        {
            this.cartas = new List<Carta>();
            foreach (var item in _cartas)
            {
                this.cartas.Add(item);
            }
        }

        public List<Carta> Get_Cartas()
        {
            return this.cartas;
        }

        public void Constroi_Baralho()
        {
            foreach (var valor in this.Get_ValoresValidos())
            {
                foreach (var naipe in this.Get_NaipesValidos())
                {
                    Carta carta = new Carta(valor, naipe);
                    this.Get_Cartas().Add(carta);
                }
            }
        }

        public Baralho(string[] valores_validos,
            string[] naipes_validos)
        {
            this.valores_validos = new List<string>();
            this.naipes_validos = new List<string>();
            this.cartas = new List<Carta>();

            this.Set_ValoresValidos(valores_validos);
            this.Set_NaipesValidos(naipes_validos);
            this.Constroi_Baralho();
        }

        public Carta Retira_Carta_Aleatoria()
        {
            if (this.Get_Cartas().Count == 0)
            {
                return null;
            }

            int indice_sorteado = rnd.Next(0, this.Get_Cartas().Count());

            Carta carta = this.Get_Cartas()[indice_sorteado];

            Carta[] cartas_intermed = new Carta[this.Get_Cartas().Count() - 1];

            int i = 0;
            for (int k = 0; k < this.Get_Cartas().Count(); k++)
            {
                if (indice_sorteado != k)
                {
                    cartas_intermed[i++] = this.Get_Cartas()[k];
                }

            }
            this.Set_Cartas(cartas_intermed);

            return carta;
        }

        public void Embaralha()
        {
            List<Carta> baralho_vazio = new List<Carta>();

            int tamanho_deck = this.Get_Cartas().Count();

            for (int i = 0; i < tamanho_deck; i++)
            {
                Carta c = this.Retira_Carta_Aleatoria();
                baralho_vazio.Add(c);
            }

            this.Set_Cartas(baralho_vazio.ToArray());
        }

        public void mostra_cartas()
        {
            foreach (var carta in this.Get_Cartas())
            {
                Console.WriteLine($"{carta.Valor} de {carta.Naipe}, peso = {carta.Peso}");
            }
        }


    }
}
