using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventario_tienda
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        List<Producto> productos = new List<Producto>();
        int[] resumenExistencias = new int[3];

        private void MostrarProductos()
        {
            lstProductos.Items.Clear();

            foreach (Producto producto in productos)
            {
                lstProductos.Items.Add(
                    producto.Nombre + "|" +
                    producto.Categoria + "|" +
                    producto.Precio.ToString("N2") + "|" +
                    producto.Existencias);
            }

        }
        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string categoria = txtCategoria.Text.Trim();
            decimal precio;
            int existencias;

            if (nombre == "" || categoria == "")
            {
                MessageBox.Show("Complete el nombre y la categoria.");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio numerico mayor que cero.");
                txtPrecio.Focus();
                txtPrecio.Focus();
                return;

            }
            if (!int.TryParse(txtExistencias.Text, out existencias) || existencias < 0)
            {
                MessageBox.Show("Ingrese existencias enteras de cero o más.");
                txtExistencias.Focus();
                return;
            }


            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ya existe un producto con ese nombre.");
                    return;
                }

            }
            Producto nuevo = new Producto();
            nuevo.Nombre = nombre;
            nuevo.Categoria = categoria;
            nuevo.Precio = precio;
            nuevo.Existencias = existencias;
            productos.Add(nuevo);
            MostrarProductos();
            MessageBox.Show("Producto agregado correctamente .");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtExistencias.Clear();
            lstProductos.ClearSelected();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = lstProductos.SelectedIndex;
            if (posicion == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;

            }
            productos.RemoveAt(posicion);
            MostrarProductos();

            MessageBox.Show(" Producto eliminado correctamente");
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicion = lstProductos.SelectedIndex;
            if (posicion == -1)
            {
                return;
            }
            Producto producto = productos[posicion];

            txtNombre.Text = producto.Nombre;
            txtCategoria.Text = producto.Categoria;
            txtPrecio.Text = producto.Precio.ToString();
            txtExistencias.Text = producto.Existencias.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int posicion = lstProductos.SelectedIndex;

            if (posicion == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string categoria = txtCategoria.Text.Trim();
            decimal precio;
            int existencias;

            if (nombre == "" || categoria == "")
            {
                MessageBox.Show("Complete el nombre y la categoría.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio numérico mayor que cero.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtExistencias.Text, out existencias) || existencias < 0)
            {
                MessageBox.Show("Ingrese existencias enteras de cero o más.");
                txtExistencias.Focus();
                return;
            }

            for (int i = 0; i < productos.Count; i++)
            {
                if (i != posicion &&
                   productos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(" Ya existe otro producto con ese nombre.");
                    return;
                }
            }

            productos[posicion].Nombre = nombre;
            productos[posicion].Categoria = categoria;
            productos[posicion].Precio = precio;
            productos[posicion].Existencias = existencias;

            MostrarProductos();
            lstProductos.SelectedIndex = posicion;

            MessageBox.Show("Producto modificado correctamente.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Escriba el nombre del producto que desea buscar.");
                txtNombre.Focus();
                return;
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.");
                return;
            }

            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    lstProductos.SelectedIndex = i;
                    MessageBox.Show("Producto encontrado. ");
                    return;
                }
            }

            MessageBox.Show(" No se encontró el producto.");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos para ordenar");
                return;


            }
            for (int i = 0; i < productos.Count - 1; i++)
            {
                for (int j = i + 1; j < productos.Count; j++)
                {
                    if (string.Compare(productos[i].Nombre,
                        productos[j].Nombre, true) > 0)
                    {
                        Producto auxiliar = productos[i];
                        productos[i] = productos[j];
                        productos[j] = auxiliar;


                    }
                }
                MostrarProductos();
                MessageBox.Show("Productos ordenados por nombre.");
            }
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            int posicion = lstProductos.SelectedIndex;

            if (posicion == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            Form2 ventana = new Form2(productos[posicion]);
            ventana.ShowDialog();
            MostrarProductos();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < resumenExistencias.Length ; i++)
            {
                resumenExistencias [i] = 0 ;
            }

            foreach (Producto producto in productos )
            {
                
                if  ( producto.Existencias == 0 )
                {
                 
                    
                    resumenExistencias[0]++;
                }

                else if (producto.Existencias <= 5)
                {
                 
                    
                    resumenExistencias [1] ++;
                }

                else
                {


                    resumenExistencias [2] ++ ;
                }
            }

            MessageBox.Show(
                " Productos sin existencias: " + resumenExistencias[0 ] +
                "\nProductos con 1 a 5 unidades: " + resumenExistencias[1 ] +
                "\nProductos con más de 5 unidades : " + resumenExistencias[2] ) ;
        }
    }

}


          
        
