using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Metodos
{
    public class MetodoSimple : IMetodos
    {
        public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y) 
            {
                if (x.FechaCompra < y.FechaCompra)
                {
                    return 1;
                }
                if (x.FechaCompra > y.FechaCompra)
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
        private decimal CostoDelTotal;
        private decimal[] PrecioDeVenta;
        

        public void Comprar(Producto t)
        {
            if (ProductoEspecifico == null)
            {
                ProductoEspecifico = new Producto[1];
                ProductoEspecifico[0] = t;
                PrecioVenta(t.Precio);
                CostoDelTotal = t.Precio * t.Existencia;
                CostoDelTotal = CostoDeCompra;
                return;
            }
            Producto[] Tmp = new Producto[ProductoEspecifico.Length + 1];
            Array.Copy(ProductoEspecifico, Tmp, ProductoEspecifico.Length);
            Tmp[Tmp.Length - 1] = t;
            ProductoEspecifico = Tmp;
            PrecioVenta(t.Precio);
            CostoDelTotal += t.Precio * t.Existencia;
            CostoDeCompra = t.Precio * t.Existencia;
            Ordenar();
        }
        public decimal CostoCompra()
        {
            return CostoDeCompra;
        }
        public decimal CostoTotal()
        {
            CostoDeCompra = CostoDeCompra - CostoDeVenta;
            CostoDeVenta = 0;
            return CostoDeCompra;
        }

        public decimal CostoVenta()
        {
            return CostoDeVenta;
        }

        public void Eliminar()
        {
            Producto[] temp = new Producto[ProductoEspecifico.Length - 1];
            Array.Copy(ProductoEspecifico, 1, temp, 0, ProductoEspecifico.Length - 1);
            ProductoEspecifico = temp;
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
            decimal venta = ValorPrecioVenta();
            PrecioVenta(venta);
            for (int j = 0; j < i; j++)
            {
                CostoDeVenta += ProductoEspecifico[j].Existencia * venta;
                CostoDelTotal = CostoDelTotal - (ProductoEspecifico[j].Existencia * ProductoEspecifico[i].Precio);
            }
            while (i != 0)
            {
                Eliminar();
                i--;
            }
        }
        public void PrecioVenta(decimal t)
        {
            if (PrecioDeVenta == null)
            {
                PrecioDeVenta = new decimal[1];
                PrecioDeVenta[0] = t;
                return;
            }
            decimal[] Tmp = new decimal[PrecioDeVenta.Length + 1];
            Array.Copy(PrecioDeVenta, Tmp, PrecioDeVenta.Length);
            Tmp[Tmp.Length - 1] = t;
            PrecioDeVenta = Tmp;
        }
        public decimal ValorPrecioVenta()
        {
            if(PrecioDeVenta.Length >= 2)
            {
                return ((PrecioDeVenta[PrecioDeVenta.Length - 1] + PrecioDeVenta[PrecioDeVenta.Length - 2]) / 2);
            }
            return PrecioDeVenta[0];
        }
    }
}
