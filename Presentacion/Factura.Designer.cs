namespace Presentacion
{
    partial class Factura
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            textBoxProducto = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxSubtotal = new TextBox();
            textBoxIVA = new TextBox();
            textBoxTotal = new TextBox();
            buttonFacturar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio U.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 197);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 4;
            label5.Text = "IVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 263);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonFacturar);
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(textBoxIVA);
            groupBox1.Controls.Add(textBoxSubtotal);
            groupBox1.Controls.Add(textBoxCantidad);
            groupBox1.Controls.Add(textBoxPrecio);
            groupBox1.Controls.Add(textBoxProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 294);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBoxProducto
            // 
            textBoxProducto.Location = new Point(108, 26);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.Size = new Size(227, 27);
            textBoxProducto.TabIndex = 6;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(108, 59);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(227, 27);
            textBoxPrecio.TabIndex = 7;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(108, 92);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(227, 27);
            textBoxCantidad.TabIndex = 8;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(108, 190);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(227, 27);
            textBoxSubtotal.TabIndex = 9;
            // 
            // textBoxIVA
            // 
            textBoxIVA.Location = new Point(108, 223);
            textBoxIVA.Name = "textBoxIVA";
            textBoxIVA.Size = new Size(227, 27);
            textBoxIVA.TabIndex = 10;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(108, 256);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(227, 27);
            textBoxTotal.TabIndex = 11;
            // 
            // buttonFacturar
            // 
            buttonFacturar.Location = new Point(171, 142);
            buttonFacturar.Name = "buttonFacturar";
            buttonFacturar.Size = new Size(94, 29);
            buttonFacturar.TabIndex = 12;
            buttonFacturar.Text = "Facturar";
            buttonFacturar.UseVisualStyleBackColor = true;
            buttonFacturar.Click += buttonFacturar_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 314);
            Controls.Add(groupBox1);
            Name = "Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBoxTotal;
        private TextBox textBoxIVA;
        private TextBox textBoxSubtotal;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecio;
        private TextBox textBoxProducto;
        private Button buttonFacturar;
    }
}
