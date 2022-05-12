using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp
{
    internal class Suelto : Producto
    {
        private float medida;

        public Suelto(): base() 
        {
            medida = 0;
        }

        public Suelto(int codigo, string marca, float precioUnitario, float medida) : base(codigo, marca, precioUnitario)
        {
            this.medida = medida;
        }
       
        public float Medida
        {
            get { return medida; }
            set { medida = value; }
        }
        //sobreescribiendo un comportamieento heredado para especializar
        public override string ToString()
        {
            return base.ToString() + " |Medida: " + medida;
        }


        public override 0.. GetPrecio()
        {
            return medida * PrecioUnitario;
        }


    }
}
