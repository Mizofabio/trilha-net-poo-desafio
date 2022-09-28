namespace DesafioPOO.Models
{
    public class Nokia : Smartphone  //Herdar da classe "Smartphone"
    {
         
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)  
        {

        }

    
         public override void InstalarAplicativo(string nomeApp)     // Sobrescrevendo o método do Smartphone.
         {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");   
         }
      
    }
}

