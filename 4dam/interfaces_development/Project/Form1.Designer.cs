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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAutor = new System.Windows.Forms.TabPage();
            this.tabPageEmpleado = new System.Windows.Forms.TabPage();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.imageListAplicacion = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAutor.SuspendLayout();
            this.tabPageEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(6, 21);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(60, 26);
            this.labelAutor.TabIndex = 0;
            this.labelAutor.Text = "Autor";
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(70, 18);
            this.comboBoxAutor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(147, 34);
            this.comboBoxAutor.TabIndex = 1;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(12, 14);
            this.buttonCargarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(146, 38);
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
            this.listViewEmpleado.Location = new System.Drawing.Point(6, 6);
            this.listViewEmpleado.Name = "listViewEmpleado";
            this.listViewEmpleado.Size = new System.Drawing.Size(413, 172);
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
            this.labelEM.Location = new System.Drawing.Point(450, 12);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(50, 26);
            this.labelEM.TabIndex = 4;
            this.labelEM.Text = "EM#";
            // 
            // textBoxEM
            // 
            this.textBoxEM.Location = new System.Drawing.Point(507, 9);
            this.textBoxEM.Name = "textBoxEM";
            this.textBoxEM.Size = new System.Drawing.Size(144, 33);
            this.textBoxEM.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(435, 48);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(82, 26);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(507, 45);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(144, 33);
            this.textBoxNombre.TabIndex = 5;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(454, 83);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(54, 26);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(507, 80);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(144, 33);
            this.textBoxEdad.TabIndex = 5;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(421, 115);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(93, 26);
            this.labelDomicilio.TabIndex = 4;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(507, 112);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(144, 33);
            this.textBoxDomicilio.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAutor);
            this.tabControl1.Controls.Add(this.tabPageEmpleado);
            this.tabControl1.ImageList = this.imageListAplicacion;
            this.tabControl1.Location = new System.Drawing.Point(17, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 387);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageAutor
            // 
            this.tabPageAutor.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAutor.Controls.Add(this.labelAutor);
            this.tabPageAutor.Controls.Add(this.comboBoxAutor);
            this.tabPageAutor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAutor.ImageIndex = 1;
            this.tabPageAutor.Location = new System.Drawing.Point(4, 39);
            this.tabPageAutor.Name = "tabPageAutor";
            this.tabPageAutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutor.Size = new System.Drawing.Size(656, 344);
            this.tabPageAutor.TabIndex = 0;
            this.tabPageAutor.Text = "Autor";
            // 
            // tabPageEmpleado
            // 
            this.tabPageEmpleado.Controls.Add(this.buttonActualizar);
            this.tabPageEmpleado.Controls.Add(this.listViewEmpleado);
            this.tabPageEmpleado.Controls.Add(this.textBoxDomicilio);
            this.tabPageEmpleado.Controls.Add(this.textBoxNombre);
            this.tabPageEmpleado.Controls.Add(this.textBoxEdad);
            this.tabPageEmpleado.Controls.Add(this.labelEM);
            this.tabPageEmpleado.Controls.Add(this.labelNombre);
            this.tabPageEmpleado.Controls.Add(this.textBoxEM);
            this.tabPageEmpleado.Controls.Add(this.labelEdad);
            this.tabPageEmpleado.Controls.Add(this.labelDomicilio);
            this.tabPageEmpleado.ImageIndex = 0;
            this.tabPageEmpleado.Location = new System.Drawing.Point(4, 39);
            this.tabPageEmpleado.Name = "tabPageEmpleado";
            this.tabPageEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmpleado.Size = new System.Drawing.Size(656, 344);
            this.tabPageEmpleado.TabIndex = 1;
            this.tabPageEmpleado.Text = "Empleado";
            this.tabPageEmpleado.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(521, 163);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(113, 34);
            this.buttonActualizar.TabIndex = 6;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // imageListAplicacion
            // 
            this.imageListAplicacion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAplicacion.ImageStream")));
            this.imageListAplicacion.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAplicacion.Images.SetKeyName(0, "30868.png");
            this.imageListAplicacion.Images.SetKeyName(1, "writer_male_light_256.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(691, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCargarDatos);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplicacion de Base de Datos";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAutor.ResumeLayout(false);
            this.tabPageAutor.PerformLayout();
            this.tabPageEmpleado.ResumeLayout(false);
            this.tabPageEmpleado.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAutor;
        private System.Windows.Forms.TabPage tabPageEmpleado;
        private System.Windows.Forms.ImageList imageListAplicacion;
        private System.Windows.Forms.Button buttonActualizar;

    }
}

