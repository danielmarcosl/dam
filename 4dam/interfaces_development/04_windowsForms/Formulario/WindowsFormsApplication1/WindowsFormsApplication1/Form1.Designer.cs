namespace WindowsFormsApplication1
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.checkBoxEstudia = new System.Windows.Forms.CheckBox();
            this.labelTipoEstudia = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.checkBoxCarnet = new System.Windows.Forms.CheckBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(12, 58);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(73, 20);
            this.labelApellidos.TabIndex = 1;
            this.labelApellidos.Text = "Apellidos";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(103, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(178, 26);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(103, 52);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(178, 26);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // checkBoxEstudia
            // 
            this.checkBoxEstudia.AutoSize = true;
            this.checkBoxEstudia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstudia.Location = new System.Drawing.Point(24, 98);
            this.checkBoxEstudia.Name = "checkBoxEstudia";
            this.checkBoxEstudia.Size = new System.Drawing.Size(82, 24);
            this.checkBoxEstudia.TabIndex = 3;
            this.checkBoxEstudia.Text = "Estudia";
            this.checkBoxEstudia.UseVisualStyleBackColor = true;
            // 
            // labelTipoEstudia
            // 
            this.labelTipoEstudia.AutoSize = true;
            this.labelTipoEstudia.Location = new System.Drawing.Point(46, 135);
            this.labelTipoEstudia.Name = "labelTipoEstudia";
            this.labelTipoEstudia.Size = new System.Drawing.Size(39, 20);
            this.labelTipoEstudia.TabIndex = 4;
            this.labelTipoEstudia.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "E.S.O.",
            "Bachiller",
            "Grado Medio",
            "Grado Superior"});
            this.comboBoxTipo.Location = new System.Drawing.Point(91, 132);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(136, 28);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // checkBoxCarnet
            // 
            this.checkBoxCarnet.AutoSize = true;
            this.checkBoxCarnet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCarnet.Location = new System.Drawing.Point(16, 178);
            this.checkBoxCarnet.Name = "checkBoxCarnet";
            this.checkBoxCarnet.Size = new System.Drawing.Size(162, 24);
            this.checkBoxCarnet.TabIndex = 6;
            this.checkBoxCarnet.Text = "Carnet de conducir";
            this.checkBoxCarnet.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(39, 219);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(90, 30);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(161, 219);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(12, 276);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(115, 20);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "labelResultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 337);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.checkBoxCarnet);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTipoEstudia);
            this.Controls.Add(this.checkBoxEstudia);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.CheckBox checkBoxEstudia;
        private System.Windows.Forms.Label labelTipoEstudia;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.CheckBox checkBoxCarnet;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelResultado;
    }
}

