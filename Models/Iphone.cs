namespace DesafioPOO.Models
{
    //  Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
       public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
       {

       }

        public override void InstalarAplicativo(string nomeApp)   // Sobrescrevendo o método do Smartphone.
         {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");   
         }
        
    }
}