namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Smartphone \n{Modelo} ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Smartphone \n{Modelo} recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
