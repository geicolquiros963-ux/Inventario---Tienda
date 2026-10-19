using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventario_tienda
{
    public partial class Form2 : Form
    {
        Producto producto;

        internal Form2(Producto seleccionado)
        {
            InitializeComponent();
            producto = seleccionado;
            MostrarMovimientos();
            lblProductoSeleccionado.Text = "Producto seleccionado : " + producto.Nombre;
        }

        private void MostrarMovimientos()
        {
            lstMovimientos.Items.Clear();

            nodoMovimiento? actual = producto.PrimerMovimiento;

            while (actual != null)
            {
                lstMovimientos.Items.Add(actual.Detalle);
                actual = actual.Siguiente;
            }
        }
        private void AgregarMovimiento(string detalle)
        {
            nodoMovimiento nuevo = new nodoMovimiento();
            nuevo.Detalle = detalle;
            nuevo.Siguiente = producto.PrimerMovimiento;
            producto.PrimerMovimiento = nuevo;

            MostrarMovimientos();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad entera mayor que cero.");
                txtCantidad.Focus();
                return;
            }

            if (cantidad > int.MaxValue - producto.Existencias)
            {
                MessageBox.Show("La cantidad es demasiado grande.");
                return;
            }

            producto.Existencias += cantidad;

            AgregarMovimiento("Entrada: " + cantidad
                + " | Existencias: " + producto.Existencias);

            lblProductoSeleccionado.Text = "Producto: " + producto.Nombre
                + "\nExistencias actuales: " + producto.Existencias;

            txtCantidad.Clear();
            txtCantidad.Focus();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad entera mayor que cero.");
                txtCantidad.Focus();
                return;
            }

            if (cantidad > producto.Existencias)
            {
                MessageBox.Show("No hay suficientes existencias.");
                return;
            }

            producto.Existencias -= cantidad;

            AgregarMovimiento(" Salida : " + cantidad
                + " | Existencias: " + producto.Existencias);

            lblProductoSeleccionado.Text = " Producto : " + producto.Nombre
                + "\nExistencias actuales : " + producto.Existencias;

            txtCantidad.Clear();
            txtCantidad.Focus();
        }

        private void btnBuscarMovimiento_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarMovimiento.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Escriba qué movimiento desea buscar.");
                return;
            }

            nodoMovimiento? actual = producto.PrimerMovimiento;
            int posicion = 0;

            while (actual != null)
            {
                if (actual.Detalle.IndexOf(texto,
                     StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    lstMovimientos.SelectedIndex = posicion;
                    MessageBox.Show("Movimiento encontrado.");
                    return;
                }

                actual = actual.Siguiente;
                posicion++;
            }

            MessageBox.Show("No se encontró el movimiento.");
        }

        private void btnEliminarMovimiento_Click(object sender, EventArgs e)
        {
            int posicion = lstMovimientos.SelectedIndex ;

            if (posicion == -1 )
            {
                MessageBox.Show(" Seleccione un movimiento del historial." );
                return;
            }

            nodoMovimiento? actual = producto.PrimerMovimiento ;
            nodoMovimiento? anterior = null ;
            int indice =  0 ;

            while (actual != null )
            {  
                if (indice == posicion )
                {
                  
                    
                    if (anterior == null )
                    {
                        producto.PrimerMovimiento = actual.Siguiente ;
                    }


                    else
                    {


                        anterior.Siguiente = actual.Siguiente;
                    }

                    MostrarMovimientos () ;
                    MessageBox.Show("Movimiento eliminado del historial.");
                    return;
                }

                anterior = actual ;
                actual = actual.Siguiente ;
                indice ++;
            }
        }
    }
}
