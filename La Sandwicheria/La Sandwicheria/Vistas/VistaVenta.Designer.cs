namespace La_Sandwicheria.Vistas
{
    partial class VistaVenta
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevaLineaVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarLineaVenta = new System.Windows.Forms.Button();
            this.btnEliminarLineaVenta = new System.Windows.Forms.Button();
            this.btnAcabarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.bindingSourceLineasDeVenta = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLineasDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUEVA VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "_________________";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 264);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnNuevaLineaVenta
            // 
            this.btnNuevaLineaVenta.Location = new System.Drawing.Point(419, 74);
            this.btnNuevaLineaVenta.Name = "btnNuevaLineaVenta";
            this.btnNuevaLineaVenta.Size = new System.Drawing.Size(188, 41);
            this.btnNuevaLineaVenta.TabIndex = 9;
            this.btnNuevaLineaVenta.Text = "Nueva linea de venta";
            this.btnNuevaLineaVenta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 355);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lineas de Venta";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(240, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(131, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // btnModificarLineaVenta
            // 
            this.btnModificarLineaVenta.Location = new System.Drawing.Point(419, 121);
            this.btnModificarLineaVenta.Name = "btnModificarLineaVenta";
            this.btnModificarLineaVenta.Size = new System.Drawing.Size(188, 41);
            this.btnModificarLineaVenta.TabIndex = 11;
            this.btnModificarLineaVenta.Text = "Modificar linea de venta";
            this.btnModificarLineaVenta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLineaVenta
            // 
            this.btnEliminarLineaVenta.Location = new System.Drawing.Point(419, 168);
            this.btnEliminarLineaVenta.Name = "btnEliminarLineaVenta";
            this.btnEliminarLineaVenta.Size = new System.Drawing.Size(188, 41);
            this.btnEliminarLineaVenta.TabIndex = 12;
            this.btnEliminarLineaVenta.Text = "Eliminar linea de venta";
            this.btnEliminarLineaVenta.UseVisualStyleBackColor = true;
            // 
            // btnAcabarVenta
            // 
            this.btnAcabarVenta.Location = new System.Drawing.Point(419, 321);
            this.btnAcabarVenta.Name = "btnAcabarVenta";
            this.btnAcabarVenta.Size = new System.Drawing.Size(188, 41);
            this.btnAcabarVenta.TabIndex = 13;
            this.btnAcabarVenta.Text = "Acabar venta";
            this.btnAcabarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(419, 374);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(188, 41);
            this.btnCancelarVenta.TabIndex = 14;
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // VistaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnAcabarVenta);
            this.Controls.Add(this.btnEliminarLineaVenta);
            this.Controls.Add(this.btnModificarLineaVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevaLineaVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistaVenta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLineasDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevaLineaVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarLineaVenta;
        private System.Windows.Forms.Button btnEliminarLineaVenta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcabarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.BindingSource bindingSourceLineasDeVenta;
    }
}