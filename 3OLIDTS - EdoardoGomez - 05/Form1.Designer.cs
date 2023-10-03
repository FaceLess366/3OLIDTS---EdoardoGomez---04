namespace _3OLIDTS___EdoardoGomez___05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.gpbxgenero = new System.Windows.Forms.GroupBox();
            this.rbnonormal = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btn1guardar = new System.Windows.Forms.Button();
            this.btn2limpiar = new System.Windows.Forms.Button();
            this.gpbxgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(33, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre :";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Location = new System.Drawing.Point(33, 42);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(55, 13);
            this.lblapellidos.TabIndex = 1;
            this.lblapellidos.Text = "Apellidos :";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(33, 74);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(55, 13);
            this.lbltelefono.TabIndex = 2;
            this.lbltelefono.Text = "Telefono :";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(33, 109);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(52, 13);
            this.lblestatura.TabIndex = 3;
            this.lblestatura.Text = "Estatura :";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(33, 164);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(38, 13);
            this.lbledad.TabIndex = 4;
            this.lbledad.Text = "Edad :";
            // 
            // gpbxgenero
            // 
            this.gpbxgenero.Controls.Add(this.rbnonormal);
            this.gpbxgenero.Controls.Add(this.rbnormal);
            this.gpbxgenero.Location = new System.Drawing.Point(161, 193);
            this.gpbxgenero.Name = "gpbxgenero";
            this.gpbxgenero.Size = new System.Drawing.Size(200, 100);
            this.gpbxgenero.TabIndex = 5;
            this.gpbxgenero.TabStop = false;
            this.gpbxgenero.Text = "Genero";
            // 
            // rbnonormal
            // 
            this.rbnonormal.AutoSize = true;
            this.rbnonormal.Location = new System.Drawing.Point(3, 58);
            this.rbnonormal.Name = "rbnonormal";
            this.rbnonormal.Size = new System.Drawing.Size(51, 17);
            this.rbnonormal.TabIndex = 1;
            this.rbnonormal.TabStop = true;
            this.rbnonormal.Text = "Mujer";
            this.rbnonormal.UseVisualStyleBackColor = true;
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Location = new System.Drawing.Point(3, 16);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(62, 17);
            this.rbnormal.TabIndex = 0;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Hombre";
            this.rbnormal.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 9);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(94, 42);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(94, 74);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 8;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(89, 106);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 9;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(89, 157);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 10;
            // 
            // btn1guardar
            // 
            this.btn1guardar.Location = new System.Drawing.Point(329, 69);
            this.btn1guardar.Name = "btn1guardar";
            this.btn1guardar.Size = new System.Drawing.Size(75, 23);
            this.btn1guardar.TabIndex = 11;
            this.btn1guardar.Text = "Guardar";
            this.btn1guardar.UseVisualStyleBackColor = true;
            this.btn1guardar.Click += new System.EventHandler(this.btn1guardar_Click);
            // 
            // btn2limpiar
            // 
            this.btn2limpiar.Location = new System.Drawing.Point(523, 72);
            this.btn2limpiar.Name = "btn2limpiar";
            this.btn2limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn2limpiar.TabIndex = 12;
            this.btn2limpiar.Text = "Cancelar";
            this.btn2limpiar.UseVisualStyleBackColor = true;
            this.btn2limpiar.Click += new System.EventHandler(this.btn2limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2limpiar);
            this.Controls.Add(this.btn1guardar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.gpbxgenero);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblapellidos);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbxgenero.ResumeLayout(false);
            this.gpbxgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.GroupBox gpbxgenero;
        private System.Windows.Forms.RadioButton rbnonormal;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btn1guardar;
        private System.Windows.Forms.Button btn2limpiar;
    }
}

