using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
	public interface IMetodoServices: IServicesModel<Producto>
	{
		decimal CostoCompra();
		decimal CostoVenta();

		void Ordenar();

		int Largo();
		Producto[] Find();

	}
}
