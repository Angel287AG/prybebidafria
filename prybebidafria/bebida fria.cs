using System;
using System.Collections.Generic;
using System.Text;

namespace prybebidafria
{
    internal class bebidafria:bebidas
    {
        private int Hielo;
        public int hielo
        {
            get { return Hielo; }
            set { Hielo = value; }
        }
        public bebidafria(string _nombre, string _tamaño, int _Hielo, float _precio) : base(_nombre, _tamaño, _precio)
        {
            Hielo = _Hielo;
        }

        public override string Prepararbebida()
        {
            return "Estamos preparando un " + Nombre + "con  cantidade de hielos:" + Hielo + "  tamaño:" + Tamaño;
        }
    }
}
