using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
	public partial class FrmMetodos : Form
	{
		
		 Producto Requerido;
		MetodoService Model;
		public FrmMetodos(Producto requerido,MetodoService model)
		{

			this.Requerido = requerido;
			this.Model = model;
			Model.Comprar(Requerido);
			model.Ordenar();
			InitializeComponent();
		}

		private void FrmMetodos_Load(object sender, EventArgs e)
		{

			rtbProductos.Text = Requerido.TooString();
		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtUnidad.Text) && String.IsNullOrWhiteSpace(txtPrecio.Text))
			{
				MessageBox.Show("Tienes que llenar todo por favor");
				return;
			}

			Producto Productoo = new Producto
			{
				Id = Requerido.Id,
				Descripcion = Requerido.Descripcion,
				Existencia = int.Parse(txtUnidad.Text),
				FechaCompra = dtpFechaCompra.Value,
				FechaVencimiento = Requerido.FechaVencimiento,
				Nombre = Requerido.Nombre,
				Precio = decimal.Parse(txtPrecio.Text),
				UnidadMedida = Requerido.UnidadMedida

			};
			txtPrecio.Text = String.Empty;
			txtUnidad.Text = String.Empty;
			Model.Comprar(Productoo);
			rtbProductos.Text += Productoo.TooString();
			rtbProductos.Text += $"Costo de la compras: {Model.CostoCompra()}{Environment.NewLine}";
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("No se pueden letras");
			}
		}

		private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("No se pueden letras");
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				gbVentas.Visible = true;
				lblLotes.Text = $"Tienes {Model.Largo()} lotes";
				gbCompras.Visible = false;
					
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				gbCompras.Visible = true;
				gbVentas.Visible = false;

			}
		}

		private void rtbProductos_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtLotes_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("No se pueden letras.");
			}
		}

		private void btnLotes_Click(object sender, EventArgs e)
		{
			if (int.Parse(txtLotes.Text) > Model.Largo())
			{
				MessageBox.Show($"No tienes suficientes lotes. tienes {Model.Largo()} lotes");
			}
			else
			{
				Model.Vender(int.Parse(txtLotes.Text));
				rtbProductos.Text += $"Costo de la venta: {Model.CostoVenta()}{Environment.NewLine}";
				lblLotes.Text = $"Tienes {Model.Largo()} lotes";
				
			}
		}

		private void txtLotes_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblLotes_Click(object sender, EventArgs e)
		{

		}
	}
}
