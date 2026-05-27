using System;
using System.Collections.Generic;
using System.Text;

namespace prybebidafria
{
    internal class bebidas
    {
        protected float precioBebida;
        protected string nombreBebida;
        protected string tamañoBebida;
        public float Precio
        {
            get { return precioBebida; }
            set
            {
                if (value > 0) { precioBebida = value; }
                else { precioBebida = -1; }
            }
        }

        public string Tamaño
        {
            get { return tamañoBebida; }
            set { tamañoBebida = value; }
        }

        public string Nombre
        {
            get { return nombreBebida; }
            set { nombreBebida = value; }
        }
        public bebidas()
        {
            nombreBebida = "";
            tamañoBebida = "";
            precioBebida = 0;
        }
        public bebidas(string _nombre, string _tamaño, float _precio)
        {
            this.nombreBebida = _nombre;
            this.tamañoBebida = _tamaño;
            this.precioBebida = _precio;
        }
        public virtual string Prepararbebida()
        {
            return "Estamos preparando un : " + nombreBebida + " De tamaño : " + tamañoBebida;
        }

        public void Descuentobebida(float descuento)
        {
            precioBebida = precioBebida * (1 - (descuento / 100));
        }
    }
}
