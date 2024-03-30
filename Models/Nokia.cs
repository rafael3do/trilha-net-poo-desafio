namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string marca, string modelo) : base(numero, marca, modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }


        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} na loja de aplicativos da Nokia...");
        }
    }
}