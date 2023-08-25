using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTienda
{
    internal class clsTipo4 :clsAbstracta
    {


        public override double aplicarDescuento()
        {
            double descuento = douPrecio * 0.04;
            return descuento;
       
    }
        public override double aplicarIVA()
        {
            double douSacarIva = douIVA / 100;
            double precioConIVA = douPrecio * douSacarIva;
            return precioConIVA;
        }

        public override double precioTotal()
        {
            double precioIVA = aplicarIVA();
            double precioDescuento = aplicarDescuento();
            double precioTotal = douPrecio - precioDescuento ;
            return precioTotal;
        }

        

    }
}
