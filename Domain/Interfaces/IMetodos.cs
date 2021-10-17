using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
	public interface IMetodos: ImodelMetodos<Producto>
	{
		decimal CostoCompra();
		decimal CostoVenta();

		void Ordenar();

		int Largo();
		Producto[] Find();
		
	}
}
