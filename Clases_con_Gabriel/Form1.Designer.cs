namespace Clases_con_Gabriel
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.pagar = new System.Windows.Forms.Button();
            this.cmbColectores = new System.Windows.Forms.ComboBox();
            this.MontoTotal = new System.Windows.Forms.Label();
            this.montoTotalValue = new System.Windows.Forms.NumericUpDown();
            this.MontoPagar = new System.Windows.Forms.Label();
            this.montoPagarValue = new System.Windows.Forms.NumericUpDown();
            this.FechaCorte = new System.Windows.Forms.Label();
            this.FechaPago = new System.Windows.Forms.Label();
            this.IdFactura = new System.Windows.Forms.Label();
            this.IdPago = new System.Windows.Forms.Label();
            this.dtFechaCorte = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPaga = new System.Windows.Forms.DateTimePicker();
            this.FacturaId = new System.Windows.Forms.TextBox();
            this.PagoId = new System.Windows.Forms.TextBox();
            this.Colector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.montoTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoPagarValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pagar
            // 
            this.pagar.Location = new System.Drawing.Point(116, 354);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(152, 43);
            this.pagar.TabIndex = 0;
            this.pagar.Text = "Pagar";
            this.pagar.UseVisualStyleBackColor = true;
            this.pagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbColectores
            // 
            this.cmbColectores.FormattingEnabled = true;
            this.cmbColectores.Items.AddRange(new object[] {
            "Ficohsa",
            "Movistar",
            "Kuiki"});
            this.cmbColectores.Location = new System.Drawing.Point(116, 12);
            this.cmbColectores.Name = "cmbColectores";
            this.cmbColectores.Size = new System.Drawing.Size(206, 21);
            this.cmbColectores.TabIndex = 1;
            // 
            // MontoTotal
            // 
            this.MontoTotal.AutoSize = true;
            this.MontoTotal.Location = new System.Drawing.Point(39, 61);
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.Size = new System.Drawing.Size(61, 13);
            this.MontoTotal.TabIndex = 2;
            this.MontoTotal.Text = "MontoTotal";
            // 
            // montoTotalValue
            // 
            this.montoTotalValue.Location = new System.Drawing.Point(116, 54);
            this.montoTotalValue.Name = "montoTotalValue";
            this.montoTotalValue.Size = new System.Drawing.Size(206, 20);
            this.montoTotalValue.TabIndex = 4;
            // 
            // MontoPagar
            // 
            this.MontoPagar.AutoSize = true;
            this.MontoPagar.Location = new System.Drawing.Point(39, 108);
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.Size = new System.Drawing.Size(65, 13);
            this.MontoPagar.TabIndex = 5;
            this.MontoPagar.Text = "MontoPagar";
            // 
            // montoPagarValue
            // 
            this.montoPagarValue.Location = new System.Drawing.Point(116, 108);
            this.montoPagarValue.Name = "montoPagarValue";
            this.montoPagarValue.Size = new System.Drawing.Size(206, 20);
            this.montoPagarValue.TabIndex = 6;
            // 
            // FechaCorte
            // 
            this.FechaCorte.AutoSize = true;
            this.FechaCorte.Location = new System.Drawing.Point(39, 151);
            this.FechaCorte.Name = "FechaCorte";
            this.FechaCorte.Size = new System.Drawing.Size(62, 13);
            this.FechaCorte.TabIndex = 7;
            this.FechaCorte.Text = "FechaCorte";
            // 
            // FechaPago
            // 
            this.FechaPago.AutoSize = true;
            this.FechaPago.Location = new System.Drawing.Point(39, 184);
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Size = new System.Drawing.Size(62, 13);
            this.FechaPago.TabIndex = 8;
            this.FechaPago.Text = "FechaPago";
            // 
            // IdFactura
            // 
            this.IdFactura.AutoSize = true;
            this.IdFactura.Location = new System.Drawing.Point(39, 228);
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Size = new System.Drawing.Size(52, 13);
            this.IdFactura.TabIndex = 9;
            this.IdFactura.Text = "IdFactura";
            // 
            // IdPago
            // 
            this.IdPago.AutoSize = true;
            this.IdPago.Location = new System.Drawing.Point(39, 277);
            this.IdPago.Name = "IdPago";
            this.IdPago.Size = new System.Drawing.Size(41, 13);
            this.IdPago.TabIndex = 10;
            this.IdPago.Text = "IdPago";
            // 
            // dtFechaCorte
            // 
            this.dtFechaCorte.Location = new System.Drawing.Point(116, 151);
            this.dtFechaCorte.Name = "dtFechaCorte";
            this.dtFechaCorte.Size = new System.Drawing.Size(206, 20);
            this.dtFechaCorte.TabIndex = 11;
            // 
            // dtFechaPaga
            // 
            this.dtFechaPaga.Location = new System.Drawing.Point(116, 184);
            this.dtFechaPaga.Name = "dtFechaPaga";
            this.dtFechaPaga.Size = new System.Drawing.Size(206, 20);
            this.dtFechaPaga.TabIndex = 12;
            // 
            // FacturaId
            // 
            this.FacturaId.Location = new System.Drawing.Point(116, 228);
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.Size = new System.Drawing.Size(206, 20);
            this.FacturaId.TabIndex = 13;
            // 
            // PagoId
            // 
            this.PagoId.Location = new System.Drawing.Point(116, 274);
            this.PagoId.Name = "PagoId";
            this.PagoId.Size = new System.Drawing.Size(206, 20);
            this.PagoId.TabIndex = 14;
            // 
            // Colector
            // 
            this.Colector.AutoSize = true;
            this.Colector.Location = new System.Drawing.Point(45, 20);
            this.Colector.Name = "Colector";
            this.Colector.Size = new System.Drawing.Size(46, 13);
            this.Colector.TabIndex = 15;
            this.Colector.Text = "Colector";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 469);
            this.Controls.Add(this.Colector);
            this.Controls.Add(this.PagoId);
            this.Controls.Add(this.FacturaId);
            this.Controls.Add(this.dtFechaPaga);
            this.Controls.Add(this.dtFechaCorte);
            this.Controls.Add(this.IdPago);
            this.Controls.Add(this.IdFactura);
            this.Controls.Add(this.FechaPago);
            this.Controls.Add(this.FechaCorte);
            this.Controls.Add(this.montoPagarValue);
            this.Controls.Add(this.MontoPagar);
            this.Controls.Add(this.montoTotalValue);
            this.Controls.Add(this.MontoTotal);
            this.Controls.Add(this.cmbColectores);
            this.Controls.Add(this.pagar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.montoTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoPagarValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pagar;
        private System.Windows.Forms.ComboBox cmbColectores;
        private System.Windows.Forms.Label MontoTotal;
        private System.Windows.Forms.NumericUpDown montoTotalValue;
        private System.Windows.Forms.Label MontoPagar;
        private System.Windows.Forms.NumericUpDown montoPagarValue;
        private System.Windows.Forms.Label FechaCorte;
        private System.Windows.Forms.Label FechaPago;
        private System.Windows.Forms.Label IdFactura;
        private System.Windows.Forms.Label IdPago;
        private System.Windows.Forms.DateTimePicker dtFechaCorte;
        private System.Windows.Forms.DateTimePicker dtFechaPaga;
        private System.Windows.Forms.TextBox FacturaId;
        private System.Windows.Forms.TextBox PagoId;
        private System.Windows.Forms.Label Colector;
    }
}

