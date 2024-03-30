using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
       
        
        public Iphone(string numero, string marca, string modelo) : base(numero, marca, modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na loja da App Store...");
        }
    }
}
