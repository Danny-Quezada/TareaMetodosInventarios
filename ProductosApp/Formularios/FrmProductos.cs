using AppCore.Factories;
using AppCore.Interfaces;
using AppCore.Services;
using Domain.Enums;
using Infraestructure.Productos;
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
    public partial class FrmProductos : Form
    {
        private IProductoService productoService;
        public FrmProductos(IProductoService productoService)
        {
            this.productoService = productoService;
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PModel = productoService;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoService.GetProductosAsJson();
            txtIDProducto.Visible = true;
            btnComprobar.Visible = true;
            llbProductoMetodo.Visible = true;
        }

        private void CmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinderType.SelectedIndex)
            {
                case 0:
                    txtFinder.Visible = true;
                    cmbMeasureUnit.Visible = false;
                    break;
                case 3:
                    cmbMeasureUnit.Visible = true;
                    txtFinder.Visible = false;
                    break;                
            }
        }

		private void txtIDProducto_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar))
			{
                e.Handled = true;
                MessageBox.Show("No se puede letras","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtIDProducto_MouseClick(object sender, MouseEventArgs e)
		{
            txtIDProducto.Text = String.Empty;
            txtIDProducto.ForeColor = Color.Black;
            cmbMetodos.Visible = false;
		}

		private void btnComprobar_Click(object sender, EventArgs e)
		{
            int i = productoService.GetIndexById(int.Parse(txtIDProducto.Text));
            if (i <0)
            { 
                MessageBox.Show("No se encontro tu producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMetodos.Visible = false;
            }
			else
			{
                cmbMetodos.Visible = true;   
			}
        }

		private void cmbMetodos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbMetodos.SelectedIndex == 0)
			{
                FrmMetodos Metodo = new FrmMetodos(productoService.GetProductoById(int.Parse(txtIDProducto.Text)), new MetodoService(MetodosFactory.CreateInstace("UEPS")));
                Metodo.ShowDialog();
			}
            else if (cmbMetodos.SelectedIndex == 1)
			{
                FrmMetodos Metodo = new FrmMetodos(productoService.GetProductoById(int.Parse(txtIDProducto.Text)), new MetodoService(MetodosFactory.CreateInstace("PEPS")));
                Metodo.ShowDialog();
            }
            else if (cmbMetodos.SelectedIndex == 2)
			{

			}
            else if (cmbMetodos.SelectedIndex == 3)
			{
                FrmMetodos Metodo = new FrmMetodos(productoService.GetProductoById(int.Parse(txtIDProducto.Text)), new MetodoService(MetodosFactory.CreateInstace("Ponderado")));
                Metodo.ShowDialog();
            }
		}
	}
}
