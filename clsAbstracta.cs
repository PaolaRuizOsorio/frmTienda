using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTienda
{
    /// <summary>
    /// Nombre: Jhonatan Mosquera- Paola Ruiz 
    /// Fecha: 19/08/2023
    /// Descripcion: Facturacion de productos
    /// </summary>
    internal abstract class clsAbstracta
    {
        public string strNombre { get; set; }
        public double douPrecio { get; set; }
        public double douIVA { get; set; }
        public int intTipo { get; set; }

        public clsAbstracta(string strNombre, double douPrecio, double douIVA, int intTipo)
        {
            this.strNombre = strNombre;
            this.douPrecio = douPrecio;
            this.douIVA = douIVA;
            this.intTipo = intTipo;
        }
        public clsAbstracta()
        {
           
        }

        public abstract double aplicarDescuento();
       

        public abstract double aplicarIVA();


        public abstract double precioTotal();


    }

}
