using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades da classe Smartphone
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Construtor da classe Smartphone
        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }

        // Métodos da classe Smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
