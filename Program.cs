using DesafioPOO.Models;

static void Main(string[] args)
{
    // Exemplo de uso das classes Nokia e iPhone
    Smartphone nokia = new Nokia("","","");
    nokia.InstalarAplicativo("WhatsApp");

    Smartphone iphone = new Iphone("", "", "");
    iphone.InstalarAplicativo("Instagram");
}