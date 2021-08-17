using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using JuegoMayorOMenor_Forms;

namespace JuegoMayorOMenor_Forms
{
    class MazoDeCartas
    {//Modela a un mazo de cartas y su interacción con una mesa de juego

        //Atributos
        private List<Carta> CartasEnElMazo;
        private List<Carta> CartasEnLaMesa;
        public enum Tipos { Truco, Poker}

        //Constructor
        public MazoDeCartas(Tipos unTipo)
        {//Retorna un mazo de cartas del tipo elegido
            CartasEnElMazo = new List<Carta>();
            CartasEnLaMesa = new List<Carta>();

            switch (unTipo)
            {
                case Tipos.Truco:
                    {
                        List<int> nros = new List<int> {1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

                        //Itero hasta llegar al directorio de la solución
                        string imagePath = Path.GetFullPath(".");
                        int i;
                        for (i = 1; i < 4; i++)
                        {
                            imagePath = System.IO.Path.GetDirectoryName(imagePath);
                        }
                        imagePath += "\\ImagenesCartasDeTruco";


                        foreach (int nro in nros)
                        {
                            CartasEnElMazo.Add(new CartaDeTruco(nro, CartaDeTruco.Palos.Oro, (imagePath + "\\" +nro.ToString() +" de " +Enum.GetName(CartaDeTruco.Palos.Oro) +".png")));
                            CartasEnElMazo.Add(new CartaDeTruco(nro, CartaDeTruco.Palos.Basto, (imagePath + "\\" + nro.ToString() + " de " + Enum.GetName(CartaDeTruco.Palos.Basto) + ".png")));
                            CartasEnElMazo.Add(new CartaDeTruco(nro, CartaDeTruco.Palos.Espada, (imagePath + "\\" + nro.ToString() + " de " + Enum.GetName(CartaDeTruco.Palos.Espada) + ".png")));
                            CartasEnElMazo.Add(new CartaDeTruco(nro, CartaDeTruco.Palos.Copa, (imagePath + "\\" + nro.ToString() + " de " + Enum.GetName(CartaDeTruco.Palos.Copa) + ".png")));
                        }
                        break;
                    }
            }
        }

        //Métodos
        public void Mezclar()
        {//Toma todas las cartas de la mesa, y mezcla el mazo
            Carta cPick;
            while (CantidadDeCartasEnElMazo() > 0)
            {//Tira todas las cartas en la mesa
                cPick = CartasEnElMazo.ElementAt(0);
                CartasEnLaMesa.Add(cPick);
                CartasEnElMazo.Remove(cPick);
            }
            Random randPick = new Random();
            while(CantidadDeCartasEnLaMesa() > 0)
            {//Toma de a una al azar para formar el mazo
                cPick = CartasEnLaMesa.ElementAt(randPick.Next(0, CantidadDeCartasEnLaMesa()));
                CartasEnLaMesa.Remove(cPick);
                CartasEnElMazo.Add(cPick);
            }
        }
        public int CantidadDeCartasEnLaMesa()
        {//...
            return CartasEnLaMesa.Count;
        }
        public int CantidadDeCartasEnElMazo()
        {//...
            return CartasEnElMazo.Count;
        }
        /*public Carta SacarUnaCarta()
        {//...
            if (CartasEnElMazo.Count == 0)
                return null;
            Carta c = CartasEnElMazo.ElementAt(0);
            CartasEnElMazo.Remove(c);
            CartasEnLaMesa.Add(c);
            return c;
        }*/
        public Carta SacarUnaCarta()
        {//...
            if (CartasEnElMazo.Count == 0)
                Mezclar();
            Carta c = CartasEnElMazo.ElementAt(0);
            CartasEnElMazo.Remove(c);
            CartasEnLaMesa.Add(c);
            return c;
        }
        public Carta UltimaCartaSacada()
        {//Retorna la última carta sacada del mazo. Debe haber al menos una carta en la mesa.
            return CartasEnLaMesa.Last();
        }
    }
}
