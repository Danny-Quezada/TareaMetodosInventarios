using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Metodos
{
	public class PromedioPonderado : IMetodos
	{
		public class ProductoOrderByPrecio : IComparer<Producto>
		{
			public int Compare(Producto x, Producto y)
			{
				if (x.FechaCompra < y.FechaCompra)
				{
					return -1;
				}
				else if (x.FechaCompra > y.FechaCompra)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}

		}
		Producto[] ProductoEspecifico;
		private decimal CostoDeCompra;
		private decimal CostoDeVenta;
		private decimal CostoPromedio;
		private decimal numeroDeUnidades;
		private decimal CompraIndividual;

		public void Comprar(Producto t)
		{
			if (ProductoEspecifico == null)
			{
				ProductoEspecifico = new Producto[1];
				ProductoEspecifico[0] = t;
				CostoDeCompra = t.Precio * t.Existencia;
				numeroDeUnidades++;
				CostoPromedio += t.Precio;
				return;
			}
			Producto[] Tmp = new Producto[ProductoEspecifico.Length + 1];
			Array.Copy(ProductoEspecifico, Tmp, ProductoEspecifico.Length);
			Tmp[Tmp.Length - 1] = t;
			ProductoEspecifico = Tmp;
			numeroDeUnidades++;
			CostoPromedio += t.Precio;
			decimal Promedio = CostoPromedio / numeroDeUnidades;
			CostoPromedio = Promedio;
			CostoDeCompra += t.Precio * t.Existencia;
			CompraIndividual = t.Precio * t.Existencia;
			Ordenar();

		}
		public decimal CoostoPromedio()
		{
			return CostoPromedio;
		}
		public decimal CostoCompra()
		{
			return CompraIndividual;
		}

		public decimal CostoVenta()
		{
			return CostoDeVenta;
		}

		public void Eliminar()
		{
			int contador = 0;
			for (int i = 0; i < ProductoEspecifico.Length; i++)
			{
				if (ProductoEspecifico[i].Existencia <= 1)
				{
					contador++;
				}

			}
			Producto[] Temp = new Producto[ProductoEspecifico.Length - contador];
			for (int i = 0; i < ProductoEspecifico.Length; i++)
			{
				if (ProductoEspecifico[i].Existencia > 0)
				{
					if (i > Temp.Length)
					{
						break;
					}
					else
					{
						Temp[i - 1] = ProductoEspecifico[i];
					}
				}
			}
			ProductoEspecifico = Temp;
			Ordenar();
		}

		public Producto[] Find()
		{
			return ProductoEspecifico;
		}

		public int Largo()
		{
			return ProductoEspecifico.Length;
		}

		public void Ordenar()
		{
			Array.Sort(ProductoEspecifico, new PromedioPonderado.ProductoOrderByPrecio());
		}

		public void Vender(int i)
		{


			for (int a = 0; a <= (i - 1); a++)
			{
				if (ProductoEspecifico.Length == 0)
				{
					break;
				}
				if (ProductoEspecifico[a].Existencia != 0)
				{
					CostoDeVenta += ProductoEspecifico[a].Existencia * CostoPromedio;
					ProductoEspecifico[a].Existencia = 0;
				}

			}
			Eliminar();
		 }

        public decimal CostoTotal(int i)
        {
			decimal costo = 0;
			for (int a = 0; a < i; a++)
			{
				if (ProductoEspecifico[a].Existencia != 0)
				{
					costo += ProductoEspecifico[a].Existencia * ProductoEspecifico[a].Precio;
				}

			}
			return costo;
		}

        public decimal CostoTotal()
        {
			CostoDeCompra = CostoDeCompra - CostoDeVenta;
			CostoDeVenta = 0;
			return CostoDeCompra;
		}
    }
}
