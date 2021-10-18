using Domain.Entities.Metodos;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Factories
{
	public static class MetodosFactory
	{

		public static IMetodos CreateInstace(string metodo)
		{
			if (metodo is null)
			{
				throw new ArgumentNullException(nameof(metodo));
			}

			if (metodo == "UEPS")
			{
				return new UEPS();
			}
			else if (metodo == "PEPS")
			{
				return new PEPS();
			}
			else if (metodo == "Ponderado")
			{
				return new PromedioPonderado();
			}
			else if (metodo == "Simple")
            {
				return new MetodoSimple();
			}
			else
			{
				 throw new Exception(nameof(metodo));
			}
		}





	}
}
