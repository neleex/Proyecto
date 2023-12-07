namespace ProyectoTarea
{
    partial class frmTarea
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
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(125, 12);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(157, 20);
            this.txtTarjeta.TabIndex = 6;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(9, 12);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(110, 15);
            this.lblTarjeta.TabIndex = 5;
            this.lblTarjeta.Text = "Numero de Tarjeta";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(298, 10);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(162, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecuta Validaciones";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 50);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(523, 219);
            this.txtLog.TabIndex = 7;
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 286);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.btnEjecutar);
            this.MaximizeBox = false;
            this.Name = "frmTarea";
            this.Text = "Tarea: Validar Tarjeta Ver.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtLog;
    }
}

