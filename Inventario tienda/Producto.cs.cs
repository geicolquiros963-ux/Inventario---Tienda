using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_tienda
{
    internal class Producto
    {
        public string Nombre = "";
        public string Categoria = "";
        public decimal Precio;
        public int Existencias;
        public nodoMovimiento? PrimerMovimiento;

    }



}
