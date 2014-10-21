namespace WindowsFormsApplicationPrimera
{
    partial class FormPersonas
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.textBoxNacimiento = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.labelResultado1 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelResultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(50, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxNombre.Location = new System.Drawing.Point(100, 10);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.Location = new System.Drawing.Point(12, 50);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(82, 13);
            this.labelNacimiento.TabIndex = 2;
            this.labelNacimiento.Text = "Año Nacimiento";
            // 
            // textBoxNacimiento
            // 
            this.textBoxNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNacimiento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxNacimiento.Location = new System.Drawing.Point(100, 47);
            this.textBoxNacimiento.Name = "textBoxNacimiento";
            this.textBoxNacimiento.Size = new System.Drawing.Size(172, 20);
            this.textBoxNacimiento.TabIndex = 2;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(42, 89);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxdireccion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxdireccion.Location = new System.Drawing.Point(100, 86);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(172, 20);
            this.textBoxdireccion.TabIndex = 3;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(100, 131);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 4;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // labelResultado1
            // 
            this.labelResultado1.AutoSize = true;
            this.labelResultado1.Location = new System.Drawing.Point(39, 175);
            this.labelResultado1.Name = "labelResultado1";
            this.labelResultado1.Size = new System.Drawing.Size(61, 13);
            this.labelResultado1.TabIndex = 5;
            this.labelResultado1.Text = "Resultado1";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(197, 131);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // labelResultado2
            // 
            this.labelResultado2.AutoSize = true;
            this.labelResultado2.Location = new System.Drawing.Point(39, 202);
            this.labelResultado2.Name = "labelResultado2";
            this.labelResultado2.Size = new System.Drawing.Size(61, 13);
            this.labelResultado2.TabIndex = 5;
            this.labelResultado2.Text = "Resultado2";
            // 
            // FormPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplicationPrimera.Properties.Resources.a0126590_22305352;
            this.ClientSize = new System.Drawing.Size(500, 374);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelResultado2);
            this.Controls.Add(this.labelResultado1);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxNacimiento);
            this.Controls.Add(this.labelNacimiento);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormPersonas";
            this.Text = "Formulario para personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.TextBox textBoxNacimiento;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelResultado1;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelResultado2;
    }
}

