namespace TransposicionPorFilas {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpAlgoritmo = new System.Windows.Forms.GroupBox();
            this.radDobleClave = new System.Windows.Forms.RadioButton();
            this.radDoble = new System.Windows.Forms.RadioButton();
            this.radSimpleClave = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.grpOpcion = new System.Windows.Forms.GroupBox();
            this.radDescifrar = new System.Windows.Forms.RadioButton();
            this.radCifrar = new System.Windows.Forms.RadioButton();
            this.lblMensajeClaro = new System.Windows.Forms.Label();
            this.txtMensajeClaro = new System.Windows.Forms.TextBox();
            this.lblNRenglones = new System.Windows.Forms.Label();
            this.numRenglones = new System.Windows.Forms.NumericUpDown();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAccionar = new System.Windows.Forms.Button();
            this.grpAlgoritmo.SuspendLayout();
            this.grpOpcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRenglones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(736, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Transposición Por Filas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAlgoritmo
            // 
            this.grpAlgoritmo.Controls.Add(this.radDobleClave);
            this.grpAlgoritmo.Controls.Add(this.radDoble);
            this.grpAlgoritmo.Controls.Add(this.radSimpleClave);
            this.grpAlgoritmo.Controls.Add(this.radSimple);
            this.grpAlgoritmo.Location = new System.Drawing.Point(12, 49);
            this.grpAlgoritmo.Name = "grpAlgoritmo";
            this.grpAlgoritmo.Size = new System.Drawing.Size(149, 124);
            this.grpAlgoritmo.TabIndex = 1;
            this.grpAlgoritmo.TabStop = false;
            this.grpAlgoritmo.Text = "Algoritmo";
            // 
            // radDobleClave
            // 
            this.radDobleClave.AutoSize = true;
            this.radDobleClave.Location = new System.Drawing.Point(6, 97);
            this.radDobleClave.Name = "radDobleClave";
            this.radDobleClave.Size = new System.Drawing.Size(99, 19);
            this.radDobleClave.TabIndex = 3;
            this.radDobleClave.TabStop = true;
            this.radDobleClave.Text = "Doble + Clave";
            this.radDobleClave.UseVisualStyleBackColor = true;
            this.radDobleClave.CheckedChanged += new System.EventHandler(this.cambiarAlgoritmo);
            // 
            // radDoble
            // 
            this.radDoble.AutoSize = true;
            this.radDoble.Location = new System.Drawing.Point(6, 72);
            this.radDoble.Name = "radDoble";
            this.radDoble.Size = new System.Drawing.Size(56, 19);
            this.radDoble.TabIndex = 2;
            this.radDoble.TabStop = true;
            this.radDoble.Text = "Doble";
            this.radDoble.UseVisualStyleBackColor = true;
            this.radDoble.CheckedChanged += new System.EventHandler(this.cambiarAlgoritmo);
            // 
            // radSimpleClave
            // 
            this.radSimpleClave.AutoSize = true;
            this.radSimpleClave.Location = new System.Drawing.Point(6, 47);
            this.radSimpleClave.Name = "radSimpleClave";
            this.radSimpleClave.Size = new System.Drawing.Size(104, 19);
            this.radSimpleClave.TabIndex = 1;
            this.radSimpleClave.TabStop = true;
            this.radSimpleClave.Text = "Simple + Clave";
            this.radSimpleClave.UseVisualStyleBackColor = true;
            this.radSimpleClave.CheckedChanged += new System.EventHandler(this.cambiarAlgoritmo);
            // 
            // radSimple
            // 
            this.radSimple.AutoSize = true;
            this.radSimple.Checked = true;
            this.radSimple.Location = new System.Drawing.Point(6, 22);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(61, 19);
            this.radSimple.TabIndex = 0;
            this.radSimple.TabStop = true;
            this.radSimple.Text = "Simple";
            this.radSimple.UseVisualStyleBackColor = true;
            this.radSimple.CheckedChanged += new System.EventHandler(this.cambiarAlgoritmo);
            // 
            // grpOpcion
            // 
            this.grpOpcion.Controls.Add(this.radDescifrar);
            this.grpOpcion.Controls.Add(this.radCifrar);
            this.grpOpcion.Location = new System.Drawing.Point(167, 49);
            this.grpOpcion.Name = "grpOpcion";
            this.grpOpcion.Size = new System.Drawing.Size(90, 124);
            this.grpOpcion.TabIndex = 2;
            this.grpOpcion.TabStop = false;
            this.grpOpcion.Text = "Opción";
            // 
            // radDescifrar
            // 
            this.radDescifrar.AutoSize = true;
            this.radDescifrar.Location = new System.Drawing.Point(6, 72);
            this.radDescifrar.Name = "radDescifrar";
            this.radDescifrar.Size = new System.Drawing.Size(71, 19);
            this.radDescifrar.TabIndex = 1;
            this.radDescifrar.Text = "Descifrar";
            this.radDescifrar.UseVisualStyleBackColor = true;
            this.radDescifrar.CheckedChanged += new System.EventHandler(this.cambiarAccion);
            // 
            // radCifrar
            // 
            this.radCifrar.AutoSize = true;
            this.radCifrar.Checked = true;
            this.radCifrar.Location = new System.Drawing.Point(6, 47);
            this.radCifrar.Name = "radCifrar";
            this.radCifrar.Size = new System.Drawing.Size(54, 19);
            this.radCifrar.TabIndex = 0;
            this.radCifrar.TabStop = true;
            this.radCifrar.Text = "Cifrar";
            this.radCifrar.UseVisualStyleBackColor = true;
            this.radCifrar.CheckedChanged += new System.EventHandler(this.cambiarAccion);
            // 
            // lblMensajeClaro
            // 
            this.lblMensajeClaro.AutoSize = true;
            this.lblMensajeClaro.Location = new System.Drawing.Point(271, 53);
            this.lblMensajeClaro.Name = "lblMensajeClaro";
            this.lblMensajeClaro.Size = new System.Drawing.Size(54, 15);
            this.lblMensajeClaro.TabIndex = 3;
            this.lblMensajeClaro.Text = "Mensaje:";
            // 
            // txtMensajeClaro
            // 
            this.txtMensajeClaro.Location = new System.Drawing.Point(339, 50);
            this.txtMensajeClaro.Name = "txtMensajeClaro";
            this.txtMensajeClaro.Size = new System.Drawing.Size(385, 23);
            this.txtMensajeClaro.TabIndex = 4;
            // 
            // lblNRenglones
            // 
            this.lblNRenglones.AutoSize = true;
            this.lblNRenglones.Location = new System.Drawing.Point(271, 82);
            this.lblNRenglones.Name = "lblNRenglones";
            this.lblNRenglones.Size = new System.Drawing.Size(111, 15);
            this.lblNRenglones.TabIndex = 5;
            this.lblNRenglones.Text = "Num. de renglones:";
            // 
            // numRenglones
            // 
            this.numRenglones.Location = new System.Drawing.Point(388, 80);
            this.numRenglones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRenglones.Name = "numRenglones";
            this.numRenglones.Size = new System.Drawing.Size(45, 23);
            this.numRenglones.TabIndex = 6;
            this.numRenglones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(451, 82);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(39, 15);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(496, 79);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(133, 23);
            this.txtClave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(339, 142);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(385, 23);
            this.txtResultado.TabIndex = 10;
            // 
            // btnAccionar
            // 
            this.btnAccionar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionar.Location = new System.Drawing.Point(635, 78);
            this.btnAccionar.Name = "btnAccionar";
            this.btnAccionar.Size = new System.Drawing.Size(89, 25);
            this.btnAccionar.TabIndex = 11;
            this.btnAccionar.Text = "Cifrar";
            this.btnAccionar.UseVisualStyleBackColor = false;
            this.btnAccionar.Click += new System.EventHandler(this.btnAccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(736, 178);
            this.Controls.Add(this.btnAccionar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.numRenglones);
            this.Controls.Add(this.lblNRenglones);
            this.Controls.Add(this.txtMensajeClaro);
            this.Controls.Add(this.lblMensajeClaro);
            this.Controls.Add(this.grpOpcion);
            this.Controls.Add(this.grpAlgoritmo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transposición Por Filas";
            this.grpAlgoritmo.ResumeLayout(false);
            this.grpAlgoritmo.PerformLayout();
            this.grpOpcion.ResumeLayout(false);
            this.grpOpcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRenglones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpAlgoritmo;
        private System.Windows.Forms.RadioButton radDobleClave;
        private System.Windows.Forms.RadioButton radDoble;
        private System.Windows.Forms.RadioButton radSimpleClave;
        private System.Windows.Forms.RadioButton radSimple;
        private System.Windows.Forms.GroupBox grpOpcion;
        private System.Windows.Forms.RadioButton radDescifrar;
        private System.Windows.Forms.RadioButton radCifrar;
        private System.Windows.Forms.Label lblMensajeClaro;
        private System.Windows.Forms.TextBox txtMensajeClaro;
        private System.Windows.Forms.Label lblNRenglones;
        private System.Windows.Forms.NumericUpDown numRenglones;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAccionar;
    }
}
