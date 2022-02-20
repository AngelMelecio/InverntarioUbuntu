namespace InverntarioUbuntu
{
    partial class frmAgregarA
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(19, 81);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacion.Location = new System.Drawing.Point(19, 107);
            this.lbUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(83, 20);
            this.lbUbicacion.TabIndex = 0;
            this.lbUbicacion.Text = "Ubicacion:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(8, 6);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(489, 26);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Ingresa Los Datos Para Agrega Una Nueva Area:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(115, 108);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(147, 20);
            this.txtUbicacion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(286, 81);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID: ";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(115, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 20);
            this.txtId.TabIndex = 4;
            // 
            // frmAgregarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 148);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.lbNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAgregarA";
            this.Text = "frmAgregarA";
            this.Load += new System.EventHandler(this.frmAgregarA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}