namespace VistaFinal
{
    partial class FacturasV
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
            this.labelIdEmpl = new System.Windows.Forms.Label();
            this.txtIdEmpl = new System.Windows.Forms.TextBox();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comOp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtGridFacturas = new System.Windows.Forms.DataGridView();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEmpl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdEmpl
            // 
            this.labelIdEmpl.AutoSize = true;
            this.labelIdEmpl.Location = new System.Drawing.Point(23, 19);
            this.labelIdEmpl.Name = "labelIdEmpl";
            this.labelIdEmpl.Size = new System.Drawing.Size(99, 20);
            this.labelIdEmpl.TabIndex = 0;
            this.labelIdEmpl.Text = "Id Empleado";
            // 
            // txtIdEmpl
            // 
            this.txtIdEmpl.Location = new System.Drawing.Point(27, 44);
            this.txtIdEmpl.Name = "txtIdEmpl";
            this.txtIdEmpl.Size = new System.Drawing.Size(138, 26);
            this.txtIdEmpl.TabIndex = 1;
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Location = new System.Drawing.Point(396, 124);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(82, 20);
            this.labelIdFactura.TabIndex = 2;
            this.labelIdFactura.Text = "Id Factura";
            this.labelIdFactura.Visible = false;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(400, 148);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(145, 26);
            this.txtIdFactura.TabIndex = 3;
            this.txtIdFactura.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIT Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(27, 149);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(138, 26);
            this.txtCliente.TabIndex = 6;
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Location = new System.Drawing.Point(208, 148);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(145, 26);
            this.txtNitCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // comOp
            // 
            this.comOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comOp.FormattingEnabled = true;
            this.comOp.Items.AddRange(new object[] {
            "Guardar",
            "Editar",
            "Eliminar",
            "Consultar"});
            this.comOp.Location = new System.Drawing.Point(703, 148);
            this.comOp.Name = "comOp";
            this.comOp.Size = new System.Drawing.Size(121, 28);
            this.comOp.TabIndex = 11;
            this.comOp.TextChanged += new System.EventHandler(this.comOp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Operación";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(856, 140);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(104, 42);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(27, 230);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(138, 26);
            this.txtProducto.TabIndex = 14;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(212, 229);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(141, 26);
            this.txtCantidad.TabIndex = 15;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(400, 230);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(144, 26);
            this.txtValor.TabIndex = 16;
            // 
            // dtGridFacturas
            // 
            this.dtGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFacturas.Location = new System.Drawing.Point(27, 319);
            this.dtGridFacturas.Name = "dtGridFacturas";
            this.dtGridFacturas.RowHeadersWidth = 62;
            this.dtGridFacturas.RowTemplate.Height = 28;
            this.dtGridFacturas.Size = new System.Drawing.Size(933, 150);
            this.dtGridFacturas.TabIndex = 17;
            this.dtGridFacturas.Visible = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(580, 37);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(178, 32);
            this.btnEmpleado.TabIndex = 18;
            this.btnEmpleado.Text = "Validar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre Empleado";
            // 
            // txtNombreEmpl
            // 
            this.txtNombreEmpl.Location = new System.Drawing.Point(233, 43);
            this.txtNombreEmpl.Name = "txtNombreEmpl";
            this.txtNombreEmpl.ReadOnly = true;
            this.txtNombreEmpl.Size = new System.Drawing.Size(285, 26);
            this.txtNombreEmpl.TabIndex = 20;
            // 
            // FacturasV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.ControlBox = false;
            this.Controls.Add(this.txtNombreEmpl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.dtGridFacturas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNitCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.labelIdFactura);
            this.Controls.Add(this.txtIdEmpl);
            this.Controls.Add(this.labelIdEmpl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturasV";
            this.Text = "Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacturasV_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdEmpl;
        private System.Windows.Forms.TextBox txtIdEmpl;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comOp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dtGridFacturas;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEmpl;
    }
}