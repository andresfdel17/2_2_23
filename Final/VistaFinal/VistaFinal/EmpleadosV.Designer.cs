namespace VistaFinal
{
    partial class EmpleadosV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comProcess = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dtGridEmpl = new System.Windows.Forms.DataGridView();
            this.pgBarEmpl = new System.Windows.Forms.ProgressBar();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(208, 75);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(556, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(158, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(380, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // comProcess
            // 
            this.comProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProcess.FormattingEnabled = true;
            this.comProcess.Items.AddRange(new object[] {
            "Guardar",
            "Editar",
            "Eliminar",
            "Consultar"});
            this.comProcess.Location = new System.Drawing.Point(32, 131);
            this.comProcess.Name = "comProcess";
            this.comProcess.Size = new System.Drawing.Size(121, 21);
            this.comProcess.TabIndex = 8;
            this.comProcess.TextChanged += new System.EventHandler(this.ComProcess_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operación";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(179, 129);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dtGridEmpl
            // 
            this.dtGridEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmpl.Location = new System.Drawing.Point(93, 168);
            this.dtGridEmpl.Name = "dtGridEmpl";
            this.dtGridEmpl.Size = new System.Drawing.Size(570, 219);
            this.dtGridEmpl.TabIndex = 11;
            this.dtGridEmpl.Visible = false;
            // 
            // pgBarEmpl
            // 
            this.pgBarEmpl.Location = new System.Drawing.Point(284, 129);
            this.pgBarEmpl.Name = "pgBarEmpl";
            this.pgBarEmpl.Size = new System.Drawing.Size(430, 23);
            this.pgBarEmpl.TabIndex = 12;
            this.pgBarEmpl.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(29, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(40, 13);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Código";
            this.labelId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // EmpleadosV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.pgBarEmpl);
            this.Controls.Add(this.dtGridEmpl);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comProcess);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "EmpleadosV";
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpleadosV_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dtGridEmpl;
        private System.Windows.Forms.ProgressBar pgBarEmpl;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
    }
}