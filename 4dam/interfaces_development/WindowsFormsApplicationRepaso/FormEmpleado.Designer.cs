namespace WindowsFormsApplicationRepaso
{
    partial class FormEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.listViewEmpleado = new System.Windows.Forms.ListView();
            this.columnHeaderEM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDomicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(125, 15);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(227, 32);
            this.comboBoxEmpleado.TabIndex = 1;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(69, 270);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(185, 55);
            this.buttonCargarDatos.TabIndex = 2;
            this.buttonCargarDatos.Text = "Cargar Datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // listViewEmpleado
            // 
            this.listViewEmpleado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEM,
            this.columnHeaderNombre,
            this.columnHeaderEdad,
            this.columnHeaderDomicilio});
            this.listViewEmpleado.FullRowSelect = true;
            this.listViewEmpleado.Location = new System.Drawing.Point(17, 74);
            this.listViewEmpleado.Name = "listViewEmpleado";
            this.listViewEmpleado.Size = new System.Drawing.Size(459, 165);
            this.listViewEmpleado.TabIndex = 3;
            this.listViewEmpleado.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleado.View = System.Windows.Forms.View.Details;
            this.listViewEmpleado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewEmpleado_MouseDoubleClick);
            // 
            // columnHeaderEM
            // 
            this.columnHeaderEM.Text = "EM#";
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 135;
            // 
            // columnHeaderEdad
            // 
            this.columnHeaderEdad.Text = "Edad";
            this.columnHeaderEdad.Width = 81;
            // 
            // columnHeaderDomicilio
            // 
            this.columnHeaderDomicilio.Text = "Domicilio";
            this.columnHeaderDomicilio.Width = 157;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 337);
            this.Controls.Add(this.listViewEmpleado);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.Button buttonCargarDatos;
        private System.Windows.Forms.ListView listViewEmpleado;
        private System.Windows.Forms.ColumnHeader columnHeaderEM;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderEdad;
        private System.Windows.Forms.ColumnHeader columnHeaderDomicilio;
    }
}

