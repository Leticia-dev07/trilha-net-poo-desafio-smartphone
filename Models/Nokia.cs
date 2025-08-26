namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Realizando a Instalação do aplicativo {nomeApp} no Nokia 110 4G");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}