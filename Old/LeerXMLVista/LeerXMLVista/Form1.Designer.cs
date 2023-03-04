namespace LeerXMLVista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(37, 27);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(562, 73);
            this.txtCadena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "string de conexion";
            // 
            // btnCadena
            // 
            this.btnCadena.Location = new System.Drawing.Point(37, 106);
            this.btnCadena.Name = "btnCadena";
            this.btnCadena.Size = new System.Drawing.Size(75, 23);
            this.btnCadena.TabIndex = 2;
            this.btnCadena.Text = "Generate";
            this.btnCadena.UseVisualStyleBackColor = true;
            this.btnCadena.Click += new System.EventHandler(this.btnCadena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 158);
            this.Controls.Add(this.btnCadena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "string Conexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCadena;
        private Label label1;
        private Button btnCadena;
    }
}