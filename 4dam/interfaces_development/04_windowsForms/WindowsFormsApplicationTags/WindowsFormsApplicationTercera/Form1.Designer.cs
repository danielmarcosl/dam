namespace WindowsFormsApplicationTercera
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
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.buttonSegundo = new System.Windows.Forms.Button();
            this.buttonTercero = new System.Windows.Forms.Button();
            this.buttonCuarto = new System.Windows.Forms.Button();
            this.buttonQuinto = new System.Windows.Forms.Button();
            this.labelTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Location = new System.Drawing.Point(12, 42);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(105, 43);
            this.buttonPrimero.TabIndex = 0;
            this.buttonPrimero.Tag = "1";
            this.buttonPrimero.Text = "B1";
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.button_Generica);
            // 
            // buttonSegundo
            // 
            this.buttonSegundo.Location = new System.Drawing.Point(123, 42);
            this.buttonSegundo.Name = "buttonSegundo";
            this.buttonSegundo.Size = new System.Drawing.Size(105, 43);
            this.buttonSegundo.TabIndex = 0;
            this.buttonSegundo.Tag = "2";
            this.buttonSegundo.Text = "B2";
            this.buttonSegundo.UseVisualStyleBackColor = true;
            this.buttonSegundo.Click += new System.EventHandler(this.button_Generica);
            // 
            // buttonTercero
            // 
            this.buttonTercero.Location = new System.Drawing.Point(234, 42);
            this.buttonTercero.Name = "buttonTercero";
            this.buttonTercero.Size = new System.Drawing.Size(105, 43);
            this.buttonTercero.TabIndex = 0;
            this.buttonTercero.Tag = "3";
            this.buttonTercero.Text = "B3";
            this.buttonTercero.UseVisualStyleBackColor = true;
            this.buttonTercero.Click += new System.EventHandler(this.button_Generica);
            // 
            // buttonCuarto
            // 
            this.buttonCuarto.Location = new System.Drawing.Point(345, 42);
            this.buttonCuarto.Name = "buttonCuarto";
            this.buttonCuarto.Size = new System.Drawing.Size(105, 43);
            this.buttonCuarto.TabIndex = 0;
            this.buttonCuarto.Tag = "4";
            this.buttonCuarto.Text = "B4";
            this.buttonCuarto.UseVisualStyleBackColor = true;
            this.buttonCuarto.Click += new System.EventHandler(this.button_Generica);
            // 
            // buttonQuinto
            // 
            this.buttonQuinto.Location = new System.Drawing.Point(456, 42);
            this.buttonQuinto.Name = "buttonQuinto";
            this.buttonQuinto.Size = new System.Drawing.Size(105, 43);
            this.buttonQuinto.TabIndex = 0;
            this.buttonQuinto.Tag = "5";
            this.buttonQuinto.Text = "B5";
            this.buttonQuinto.UseVisualStyleBackColor = true;
            this.buttonQuinto.Click += new System.EventHandler(this.button_Generica);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(212, 117);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(156, 25);
            this.labelTexto.TabIndex = 1;
            this.labelTexto.Text = "Pulsa un boton";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 184);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.buttonQuinto);
            this.Controls.Add(this.buttonCuarto);
            this.Controls.Add(this.buttonTercero);
            this.Controls.Add(this.buttonSegundo);
            this.Controls.Add(this.buttonPrimero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Pulsa botones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.Button buttonSegundo;
        private System.Windows.Forms.Button buttonTercero;
        private System.Windows.Forms.Button buttonCuarto;
        private System.Windows.Forms.Button buttonQuinto;
        private System.Windows.Forms.Label labelTexto;
    }
}

