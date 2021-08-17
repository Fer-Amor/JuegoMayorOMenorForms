using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoMayorOMenor_Forms
{
    class JuegoMayorOMenor
    {//Modela al juego mayor o menor, con cartas de truco

        //Atributos
        MazoDeCartas cartas;
        protected int errores;
        protected int aciertos;
        protected int nroErroresPermitidos;
        protected Estados estado;
        public enum TiposDeEleccion { Mayor, Menor}
        public enum Estados { jugando, perdio}

        //Propiedades
        public Estados Estado
        {
            get
            {
                return estado;
            }
        }

        //Constructor
        public JuegoMayorOMenor(int nroErroresPermitidos)
        {//Retorna un juego de mayor o menor.
            this.cartas = new(MazoDeCartas.Tipos.Truco);
            this.nroErroresPermitidos = nroErroresPermitidos;
            //this.Resetear();
        }

        //Métodos
        public void Resetear()
        {
            cartas.Mezclar();
            this.errores = 0;
            this.aciertos = 0;
            estado = Estados.jugando;
        }
        public Carta DameUltimaCarta()
        {//Retorna la última carta jugada en la mesa, sacando una del mazo si es necesario
            if (cartas.CantidadDeCartasEnLaMesa() == 0)
                cartas.SacarUnaCarta();
            return cartas.UltimaCartaSacada();
        }
        public bool Apostar(TiposDeEleccion unTipoDeEleccion)
        {//Ejecuta el turno con la apuesta, anotando el acierto o error y retornando si acertó.
            Carta cartaEnLaMesa = cartas.UltimaCartaSacada();
            Carta cartaSacada = cartas.SacarUnaCarta();
            bool acierto = false;
            switch (Enum.GetName(unTipoDeEleccion))
            {
                case "Mayor":
                    {
                        if (cartaSacada.EsMayorQue(cartaEnLaMesa))
                        {
                            acierto = true;
                            aciertos++;
                        } 
                        else
                            errores++;
                        break;
                    }
                case "Menor":
                    {
                        if (cartaSacada.EsMayorQue(cartaEnLaMesa))
                        {
                            errores++;
                        }
                        else
                            acierto = true;
                            aciertos++;
                        break;
                    }     
            }
            if (GameOver())
            {
                estado = Estados.perdio;
            }
            return acierto;
        }
        public bool GameOver()
        {//Retorna si se perdió en el juego.
            return (errores >= nroErroresPermitidos);
        }
        public int Puntuacion()
        {//Retorna el número de aciertos.
            return aciertos;
        }
        public int ChancesRestantes()
        {//Retorna la cantidad de erorres restante para terminar el juego.
            return (nroErroresPermitidos - errores);
        }
    }

    class JuegoMayorOMenorEventos:JuegoMayorOMenor
    {//Modela los manejadores de eventos para un juego de mayor o menor.

        public event EventHandler CambioDeEstado;

        //Constructor
        public JuegoMayorOMenorEventos(int nroErrorespermitido) : base(nroErrorespermitido)
        {
            //
            //Resetear();
        }

        //Métodos
        public new void Resetear()
        {//Actualiza el método de la clase progenitora
            base.Resetear();
            CambioDeEstado(this, null);
        }
        public new void Apostar(TiposDeEleccion unTipoDeApuesta)
        {//Actualiza el método de la clase progenitora
            Estados estadoAnterior = this.estado;
            base.Apostar(unTipoDeApuesta);
            if(this.estado != estadoAnterior)
            {
                CambioDeEstado(this, null);
            }
        }
    }
}
