namespace JuegoMayorOMenor_Forms
{
    abstract class Carta
    {//Modela a una carta tipo naipe

        //Atributos
        protected int numero;
        protected string palo;
        protected string imagePath;

        //Propiedades
        public int Numero { get { return numero; } }
        public string Palo { get { return palo; } }
        public string ImagePath { get { return imagePath; } }

        //Métodos
        public bool EsMayorQue(Carta otraCarta)
        {//Retorna true si la carta instancia es estrictamente mayor que la carta parámetro
            return (this.numero > otraCarta.Numero);
        }
    }
}