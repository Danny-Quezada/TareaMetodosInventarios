using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Metodos
{
	public class UEPS : IMetodos
	{

		public class ProductoOrderByPrecio : IComparer<Producto>
		{
			public int Compare(Producto x, Producto y)
			{
				if (x.FechaCompra < y.FechaCompra)
				{
					return 1;
				}
				else if (x.FechaCompra > y.FechaCompra)
				{
					return -1;
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
		private decimal CostoaVender;
		public void Comprar(Producto t)
		{


			if (ProductoEspecifico == null)
			{
				ProductoEspecifico = new Producto[1];
				ProductoEspecifico[0] = t;
				CostoDeCompra = t.Precio*t.Existencia;
				return;
			}
			Producto[] Tmp = new Producto[ProductoEspecifico.Length + 1];
			Array.Copy(ProductoEspecifico, Tmp, ProductoEspecifico.Length);
			Tmp[Tmp.Length - 1] = t;
			ProductoEspecifico = Tmp;
			CostoDeCompra += t.Precio * t.Existencia;
			Ordenar();
		}

		public decimal CostoCompra()
		{
			
			return CostoDeCompra;
		}

		public decimal CostoVenta()
		{
			Ordenar();
			return CostoDeVenta;
		}

		public void Eliminar()
		{
			int contador = 0;
			for (int i=0; i<ProductoEspecifico.Length; i++)
			{
				if (ProductoEspecifico[i].Existencia <= 1)
				{
					
					contador++;
				}
				
			}
			Producto[] Temp = new Producto[ProductoEspecifico.Length - contador];
			for(int i=0; i < ProductoEspecifico.Length; i++)
			{
				if (ProductoEspecifico[i].Existencia > 0)
				{
					if (i> Temp.Length)
					{
						break;
					}
					else
					{
						Temp[i-1] = ProductoEspecifico[i];

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
			Array.Sort(ProductoEspecifico,new UEPS.ProductoOrderByPrecio() );
		}

		public void Vender(int i)
		{
			
			for (int a = 0; a<=(i-1); a++)
			{
				if (ProductoEspecifico.Length == 0)
				{
					break;
				}	
				if (ProductoEspecifico[a].Existencia != 0)
				{
					CostoDeVenta += ProductoEspecifico[a].Existencia * ProductoEspecifico[a].Precio;
					ProductoEspecifico[a].Existencia = 0;
					
				}
				
			}
			Eliminar();
		}

		public decimal CostoAVender()
		{
			return CostoaVender;
		}
	}

	}
