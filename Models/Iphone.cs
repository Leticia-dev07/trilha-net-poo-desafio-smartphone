namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Realizando a Instalação do aplicativo {nomeApp} no Iphone 13 pro max");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}