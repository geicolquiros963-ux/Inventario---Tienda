namespace Inventario_tienda
{
    partial class frmInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            lblNombre = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            lblTitulo = new Label();
            txtPrecio = new TextBox();
            txtCategoria = new TextBox();
            txtNombre = new TextBox();
            txtExistencias = new TextBox();
            lblExistencias = new Label();
            btnOrdenar = new Button();
            btnEliminar = new Button();
            lstProductos = new ListBox();
            btnMovimiento = new Button();
            btnResumen = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(496, 148);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(626, 53);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(496, 192);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(496, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(69, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(258, 31);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre del Producto :";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(69, 94);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(123, 31);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(69, 150);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(87, 31);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(297, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 31);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "inventario de tienda";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(181, 150);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(198, 100);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(333, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(248, 219);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(125, 27);
            txtExistencias.TabIndex = 12;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(12, 215);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(230, 31);
            lblExistencias.TabIndex = 13;
            lblExistencias.Text = "Existencias iniciales:";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(614, 148);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(158, 29);
            btnOrdenar.TabIndex = 14;
            btnOrdenar.Text = "Ordenar por nombre";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(496, 94);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(12, 252);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(622, 124);
            lstProductos.TabIndex = 16;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnMovimiento
            // 
            btnMovimiento.Location = new Point(626, 100);
            btnMovimiento.Name = "btnMovimiento";
            btnMovimiento.Size = new Size(110, 29);
            btnMovimiento.TabIndex = 17;
            btnMovimiento.Text = "Movimientos";
            btnMovimiento.UseVisualStyleBackColor = true;
            btnMovimiento.Click += btnMovimiento_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(613, 192);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(175, 29);
            btnResumen.TabIndex = 18;
            btnResumen.Text = "Resumen de existencias";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResumen);
            Controls.Add(btnMovimiento);
            Controls.Add(lstProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnOrdenar);
            Controls.Add(lblExistencias);
            Controls.Add(txtExistencias);
            Controls.Add(txtNombre);
            Controls.Add(txtCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventario de tienda";
            Load += frmInventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Label lblNombre;
        private Label lblCategoria;
        private Label lblPrecio;
        private Label lblTitulo;
        private TextBox txtPrecio;
        private TextBox txtCategoria;
        private TextBox txtNombre;
        private TextBox txtExistencias;
        private Label lblExistencias;
        private Button btnOrdenar;
        private Button btnEliminar;
        private ListBox lstProductos;
        private Button btnMovimiento;
        private Button btnResumen;
    }
}
