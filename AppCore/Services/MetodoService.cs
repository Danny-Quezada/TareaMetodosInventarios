using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
	public class MetodoService: IMetodoServices
	{
		IMetodos Model;
		public MetodoService( IMetodos model)
		{
			this.Model = model;
		}

		public void Comprar(Producto t)
		{
			 Model.Comprar(t);
		}

		

		public decimal CostoCompra()
		{
			return Model.CostoCompra();
		}

		public decimal CostoVenta()
		{
			return Model.CostoVenta();
		}

		public void Eliminar()
		{
			Model.Eliminar();
		}

		public Producto[] Find()
		{
			return Model.Find();
		}

		public int Largo()
		{
			return Model.Largo();
		}

		public void Ordenar()
		{
			Model.Ordenar();
		}

		public void Vender(int i)
		{
			Model.Vender(i);
		}
	}
}
