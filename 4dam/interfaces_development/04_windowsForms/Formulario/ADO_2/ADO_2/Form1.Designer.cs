namespace ADO_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSeleccionarTabla = new System.Windows.Forms.Label();
            this.comboBoxSeleccionarTabla = new System.Windows.Forms.ComboBox();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.columnHeaderED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDomicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeleccionarTabla
            // 
            this.labelSeleccionarTabla.AutoSize = true;
            this.labelSeleccionarTabla.Location = new System.Drawing.Point(13, 14);
            this.labelSeleccionarTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeleccionarTabla.Name = "labelSeleccionarTabla";
            this.labelSeleccionarTabla.Size = new System.Drawing.Size(111, 14);
            this.labelSeleccionarTabla.TabIndex = 0;
            this.labelSeleccionarTabla.Text = "Seleccionar Tabla";
            // 
            // comboBoxSeleccionarTabla
            // 
            this.comboBoxSeleccionarTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeleccionarTabla.FormattingEnabled = true;
            this.comboBoxSeleccionarTabla.Location = new System.Drawing.Point(132, 11);
            this.comboBoxSeleccionarTabla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSeleccionarTabla.Name = "comboBoxSeleccionarTabla";
            this.comboBoxSeleccionarTabla.Size = new System.Drawing.Size(160, 22);
            this.comboBoxSeleccionarTabla.TabIndex = 1;
            // 
            // listViewEmpleados
            // 
            this.listViewEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderED,
            this.columnHeaderNombre,
            this.columnHeaderEdad,
            this.columnHeaderDomicilio});
            this.listViewEmpleados.Location = new System.Drawing.Point(16, 56);
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(276, 112);
            this.listViewEmpleados.TabIndex = 2;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderED
            // 
            this.columnHeaderED.Text = "ED#";
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 87;
            // 
            // columnHeaderEdad
            // 
            this.columnHeaderEdad.Text = "Edad";
            // 
            // columnHeaderDomicilio
            // 
            this.columnHeaderDomicilio.Text = "Domicilio";
            this.columnHeaderDomicilio.Width = 65;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(319, 10);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(97, 23);
            this.buttonCargarDatos.TabIndex = 3;
            this.buttonCargarDatos.Text = "Cargar Datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 194);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.listViewEmpleados);
            this.Controls.Add(this.comboBoxSeleccionarTabla);
            this.Controls.Add(this.labelSeleccionarTabla);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccionarTabla;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarTabla;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeaderED;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderEdad;
        private System.Windows.Forms.ColumnHeader columnHeaderDomicilio;
        private System.Windows.Forms.Button buttonCargarDatos;
    }
}

