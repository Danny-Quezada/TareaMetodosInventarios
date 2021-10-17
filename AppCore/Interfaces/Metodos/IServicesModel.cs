using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
	public interface IServicesModel<T>
	{

		void Comprar(T t);
		void Vender(int i);

		void Eliminar();


	}
}
