using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_24._9
{
    internal class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Vector Somma(Vector v2)
        {
            float X=this.X+v2.X;
            float Y=this.Y+v2.Y;
            return new Vector(X, Y);
        }
        public static Vector parse(string componenti)
        {
            string[] Componente = componenti.Split(';');
            float X = float.Parse(Componente[0]);
            float Y = float.Parse(Componente[1]);
            return new Vector(X, Y);
        }
    }
}
