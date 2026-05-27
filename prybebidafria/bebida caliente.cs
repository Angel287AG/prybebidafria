using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prybebidafria
{
    internal class bebida_caliente: bebidas
    {
        private float Temperatura; 
        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        public bebida_caliente(string _nombre, string _tamaño, float _Temperatura, float _precio) : base(_nombre, _tamaño, _precio)
        {
            Temperatura = _Temperatura;
        }

        public override string Prepararbebida()
        {
            return "Estamos preparando un " + Nombre + " con temperatura de:" + Temperatura+"c" + " tamaño:"+ Tamaño;
        }
    }
}
