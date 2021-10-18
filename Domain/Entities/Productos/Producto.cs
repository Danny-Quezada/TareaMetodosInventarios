using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public DateTime FechaCompra { get; set; }
       public String  TooString()
		{
            return $" Fecha de Comprar: {FechaCompra}, Producto: {Nombre}, Precio: {Precio}, Existencia {Existencia}, Costo de la compra: {Precio*Existencia}";
		}
        public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if(x.Precio < y.Precio)
                {
                    return -1;
                }else if(x.Precio > y.Precio)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            
        }
		public class ProductoOrderByFecha : IComparer<Producto>
		{
			public int Compare(Producto x, Producto y)
			{
				if (x.FechaCompra < y.FechaCompra)
				{
                    return -1;
				}
				else if(x.FechaCompra > y.FechaCompra){
                    return 1;
				}
				else
				{
                    return 0;
				}
			}
		}
	}
}
