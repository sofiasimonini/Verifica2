using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica2
{
    internal class Cerchio
    {
        public double Raggio { get; set; }
        public Cerchio() { }
        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }
        public override 

        public static Cerchio operator +(Cerchio C, Cerchio other)
        {
            return new Cerchio(Math.Sqrt(Math.Pow(C.Raggio, 2) + Math.Pow(other.Raggio, 2)));
        }
    } public static Cerchio operator -(Cerchio C, Cerchio other)
    {
        if (C.Raggio > other.Raggio)
        {
            return new Cerchio(C.Raggio - other.Raggio);

        }
        else if (C.Raggio == other.Raggio)
        {
            return null;
        }
        else
        {
            return new Cerchio(other.Raggio - C.Raggio);
        }
    }  
    public static bool operator ==(Cerchio C, Cerchio other)
    {
        if (object.ReferenceEquals(C, null))
            return object.ReferenceEquals(other, null);
        else if (object.ReferenceEquals(other, null))
            return false;
        else
            return C.Raggio == other.Raggio;
    }
    public static bool operator != (Cerchio C, Cerchio other)
    {
        return !(C == other);
    }
    public static Cerchio Parse(string str)
    {
        if (!double.TryParse(str, out double raggio))
        {
            throw new ArgumentException();
        }
        else 
        {
            return new Cerchio(double.Parse(str));
        }
    }
}
