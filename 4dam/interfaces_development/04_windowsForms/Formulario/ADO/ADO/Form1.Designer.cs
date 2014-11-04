namespace ADO
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
            this.labelAutor = new System.Windows.Forms.Label();
            this.comboBoxAutor = new System.Windows.Forms.ComboBox();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.listViewEmpleado = new System.Windows.Forms.ListView();
            this.columnHeaderEM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDomicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEM = new System.Windows.Forms.Label();
            this.textBoxEM = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(13, 19);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(61, 25);
            this.labelAutor.TabIndex = 0;
            this.labelAutor.Text = "Autor";
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(82, 16);
            this.comboBoxAutor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(160, 33);
            this.comboBoxAutor.TabIndex = 1;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(253, 13);
            this.buttonCargarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(159, 37);
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
            this.listViewEmpleado.Location = new System.Drawing.Point(18, 75);
            this.listViewEmpleado.Name = "listViewEmpleado";
            this.listViewEmpleado.Size = new System.Drawing.Size(394, 166);
            this.listViewEmpleado.TabIndex = 3;
            this.listViewEmpleado.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleado.View = System.Windows.Forms.View.Details;
            this.listViewEmpleado.SelectedIndexChanged += new System.EventHandler(this.listViewEmpleado_SelectedIndexChanged);
            // 
            // columnHeaderEM
            // 
            this.columnHeaderEM.Text = "EM#";
            this.columnHeaderEM.Width = 69;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 136;
            // 
            // columnHeaderEdad
            // 
            this.columnHeaderEdad.Text = "Edad";
            // 
            // columnHeaderDomicilio
            // 
            this.columnHeaderDomicilio.Text = "Domicilio";
            this.columnHeaderDomicilio.Width = 125;
            // 
            // labelEM
            // 
            this.labelEM.AutoSize = true;
            this.labelEM.Location = new System.Drawing.Point(458, 104);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(60, 25);
            this.labelEM.TabIndex = 4;
            this.labelEM.Text = "EM#";
            // 
            // textBoxEM
            // 
            this.textBoxEM.Location = new System.Drawing.Point(520, 101);
            this.textBoxEM.Name = "textBoxEM";
            this.textBoxEM.Size = new System.Drawing.Size(157, 31);
            this.textBoxEM.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(442, 138);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(76, 25);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(520, 135);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(157, 31);
            this.textBoxNombre.TabIndex = 5;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(462, 172);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(56, 25);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(520, 169);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(157, 31);
            this.textBoxEdad.TabIndex = 5;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(426, 203);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(92, 25);
            this.labelDomicilio.TabIndex = 4;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(520, 200);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(157, 31);
            this.textBoxDomicilio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 269);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxEM);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelEM);
            this.Controls.Add(this.listViewEmpleado);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.labelAutor);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.ComboBox comboBoxAutor;
        private System.Windows.Forms.Button buttonCargarDatos;
        private System.Windows.Forms.ListView listViewEmpleado;
        private System.Windows.Forms.ColumnHeader columnHeaderEM;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderEdad;
        private System.Windows.Forms.ColumnHeader columnHeaderDomicilio;
        private System.Windows.Forms.Label labelEM;
        private System.Windows.Forms.TextBox textBoxEM;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.TextBox textBoxDomicilio;

    }
}

