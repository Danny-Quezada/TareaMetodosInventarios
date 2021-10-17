using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
	public interface ImodelMetodos<T>
	{

		void Comprar(T t);
		void Vender(int i);

		void Eliminar();





	}
}
