using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoMayorOMenor_Forms
{
    class CartaDeTruco : Carta
    {//Modela una carta/naipe de truco

        //Atributos
        public enum Palos { Oro, Copa, Espada, Basto };

        //Constructor
        public CartaDeTruco(int numero, Palos palo)
        {//Retorna una carta de truco
            this.numero = numero;
            this.palo = palo.ToString();
            imagePath = "";
        }
        public CartaDeTruco(int numero, Palos palo, string imagePath)
        {//Retorna una carta de truco
            this.numero = numero;
            this.palo = palo.ToString();
            this.imagePath = imagePath;
        }
    }
}
