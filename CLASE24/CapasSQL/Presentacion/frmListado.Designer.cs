namespace Presentacion
{
    partial class frmListado
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
            this.rbtnServiciosCliente = new System.Windows.Forms.RadioButton();
            this.rbtnServicios = new System.Windows.Forms.RadioButton();
            this.rbtnClientes = new System.Windows.Forms.RadioButton();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.txtServicioCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnServiciosCliente
            // 
            this.rbtnServiciosCliente.AutoSize = true;
            this.rbtnServiciosCliente.Location = new System.Drawing.Point(216, 0);
            this.rbtnServiciosCliente.Name = "rbtnServiciosCliente";
            this.rbtnServiciosCliente.Size = new System.Drawing.Size(124, 17);
            this.rbtnServiciosCliente.TabIndex = 8;
            this.rbtnServiciosCliente.TabStop = true;
            this.rbtnServiciosCliente.Text = "Servicios por Cliente:";
            this.rbtnServiciosCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnServicios
            // 
            this.rbtnServicios.AutoSize = true;
            this.rbtnServicios.Location = new System.Drawing.Point(115, 0);
            this.rbtnServicios.Name = "rbtnServicios";
            this.rbtnServicios.Size = new System.Drawing.Size(68, 17);
            this.rbtnServicios.TabIndex = 7;
            this.rbtnServicios.TabStop = true;
            this.rbtnServicios.Text = "Servicios";
            this.rbtnServicios.UseVisualStyleBackColor = true;
            // 
            // rbtnClientes
            // 
            this.rbtnClientes.AutoSize = true;
            this.rbtnClientes.Location = new System.Drawing.Point(14, 0);
            this.rbtnClientes.Name = "rbtnClientes";
            this.rbtnClientes.Size = new System.Drawing.Size(62, 17);
            this.rbtnClientes.TabIndex = 6;
            this.rbtnClientes.TabStop = true;
            this.rbtnClientes.Text = "Clientes";
            this.rbtnClientes.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(1, 23);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(600, 415);
            this.dgvResultados.TabIndex = 5;
            // 
            // txtServicioCliente
            // 
            this.txtServicioCliente.Location = new System.Drawing.Point(346, 0);
            this.txtServicioCliente.Name = "txtServicioCliente";
            this.txtServicioCliente.Size = new System.Drawing.Size(255, 20);
            this.txtServicioCliente.TabIndex = 9;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 439);
            this.Controls.Add(this.txtServicioCliente);
            this.Controls.Add(this.rbtnServiciosCliente);
            this.Controls.Add(this.rbtnServicios);
            this.Controls.Add(this.rbtnClientes);
            this.Controls.Add(this.dgvResultados);
            this.Name = "frmListado";
            this.Text = "frmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnServiciosCliente;
        private System.Windows.Forms.RadioButton rbtnServicios;
        private System.Windows.Forms.RadioButton rbtnClientes;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtServicioCliente;
    }
}