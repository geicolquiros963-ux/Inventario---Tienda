namespace Inventario_tienda
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProductoSeleccionado = new Label();
            lblCantidad = new Label();
            lblMovimientos = new Label();
            lstMovimientos = new ListBox();
            txtCantidad = new TextBox();
            btnCerrar = new Button();
            btnSalida = new Button();
            btnEntrada = new Button();
            btnEliminarMovimiento = new Button();
            btnBuscarMovimiento = new Button();
            txtBuscarMovimiento = new TextBox();
            SuspendLayout();
            // 
            // lblProductoSeleccionado
            // 
            lblProductoSeleccionado.AutoSize = true;
            lblProductoSeleccionado.Location = new Point(12, 52);
            lblProductoSeleccionado.Name = "lblProductoSeleccionado";
            lblProductoSeleccionado.Size = new Size(163, 20);
            lblProductoSeleccionado.TabIndex = 0;
            lblProductoSeleccionado.Text = "Producto seleccionado:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 99);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(76, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = " Cantidad:";
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(12, 197);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(172, 20);
            lblMovimientos.TabIndex = 2;
            lblMovimientos.Text = "Historial de movimentos";
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(12, 220);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(646, 104);
            lstMovimientos.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(94, 96);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(81, 27);
            txtCantidad.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(278, 159);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(158, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(278, 99);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(158, 29);
            btnSalida.TabIndex = 7;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(278, 48);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(158, 29);
            btnEntrada.TabIndex = 8;
            btnEntrada.Text = "Registrar entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnEliminarMovimiento
            // 
            btnEliminarMovimiento.Location = new Point(389, 354);
            btnEliminarMovimiento.Name = "btnEliminarMovimiento";
            btnEliminarMovimiento.Size = new Size(163, 29);
            btnEliminarMovimiento.TabIndex = 9;
            btnEliminarMovimiento.Text = "Eliminar del historial";
            btnEliminarMovimiento.UseVisualStyleBackColor = true;
            btnEliminarMovimiento.Click += btnEliminarMovimiento_Click;
            // 
            // btnBuscarMovimiento
            // 
            btnBuscarMovimiento.Location = new Point(12, 354);
            btnBuscarMovimiento.Name = "btnBuscarMovimiento";
            btnBuscarMovimiento.Size = new Size(158, 29);
            btnBuscarMovimiento.TabIndex = 10;
            btnBuscarMovimiento.Text = "Buscar movimiento";
            btnBuscarMovimiento.UseVisualStyleBackColor = true;
            btnBuscarMovimiento.Click += btnBuscarMovimiento_Click;
            // 
            // txtBuscarMovimiento
            // 
            txtBuscarMovimiento.Location = new Point(197, 356);
            txtBuscarMovimiento.Name = "txtBuscarMovimiento";
            txtBuscarMovimiento.Size = new Size(93, 27);
            txtBuscarMovimiento.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarMovimiento);
            Controls.Add(btnBuscarMovimiento);
            Controls.Add(btnEliminarMovimiento);
            Controls.Add(btnEntrada);
            Controls.Add(btnSalida);
            Controls.Add(btnCerrar);
            Controls.Add(txtCantidad);
            Controls.Add(lstMovimientos);
            Controls.Add(lblMovimientos);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductoSeleccionado);
            Name = "Form2";
            Text = "Movimentos de inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductoSeleccionado;
        private Label lblCantidad;
        private Label lblMovimientos;
        private ListBox lstMovimientos;
        private TextBox txtCantidad;
        private Button btnCerrar;
        private Button btnSalida;
        private Button btnEntrada;
        private Button btnEliminarMovimiento;
        private Button btnBuscarMovimiento;
        private TextBox txtBuscarMovimiento;
    }
}