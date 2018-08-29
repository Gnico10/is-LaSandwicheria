namespace La_Sandwicheria.Vistas
{
    partial class VistaTerminarVenta
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnAcabarVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeYNombre = new System.Windows.Forms.TextBox();
            this.bindingSourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCondTributariaCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCondTributariaEmpresa = new System.Windows.Forms.ComboBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSourcePtoDeVenta = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPuntoDeVenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePtoDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "_________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "FINALIZAR VENTA";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(343, 455);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(188, 41);
            this.btnCancelarVenta.TabIndex = 16;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnAcabarVenta
            // 
            this.btnAcabarVenta.Location = new System.Drawing.Point(96, 455);
            this.btnAcabarVenta.Name = "btnAcabarVenta";
            this.btnAcabarVenta.Size = new System.Drawing.Size(188, 41);
            this.btnAcabarVenta.TabIndex = 15;
            this.btnAcabarVenta.Text = "Acabar venta";
            this.btnAcabarVenta.UseVisualStyleBackColor = true;
            this.btnAcabarVenta.Click += new System.EventHandler(this.btnAcabarVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido y Nombre:";
            // 
            // txtApeYNombre
            // 
            this.txtApeYNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCliente, "NombreYApe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtApeYNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeYNombre.Location = new System.Drawing.Point(162, 46);
            this.txtApeYNombre.Name = "txtApeYNombre";
            this.txtApeYNombre.Size = new System.Drawing.Size(353, 22);
            this.txtApeYNombre.TabIndex = 18;
            // 
            // bindingSourceCliente
            // 
            this.bindingSourceCliente.DataSource = typeof(La_Sandwicheria.Modelo.Dominio.Cliente);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Condición Tributaria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCliente, "Cuil", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.Location = new System.Drawing.Point(162, 86);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(215, 22);
            this.txtCuil.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCondTributariaCliente);
            this.groupBox1.Controls.Add(this.txtCuil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApeYNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cbxCondTributariaCliente
            // 
            this.cbxCondTributariaCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCliente, "CondTributaria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxCondTributariaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondTributariaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCondTributariaCliente.FormattingEnabled = true;
            this.cbxCondTributariaCliente.Location = new System.Drawing.Point(161, 127);
            this.cbxCondTributariaCliente.Name = "cbxCondTributariaCliente";
            this.cbxCondTributariaCliente.Size = new System.Drawing.Size(166, 24);
            this.cbxCondTributariaCliente.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCondTributariaEmpresa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombreEmpresa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa";
            // 
            // cbxCondTributariaEmpresa
            // 
            this.cbxCondTributariaEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceEmpresa, "CondTributaria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxCondTributariaEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondTributariaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCondTributariaEmpresa.FormattingEnabled = true;
            this.cbxCondTributariaEmpresa.Location = new System.Drawing.Point(162, 87);
            this.cbxCondTributariaEmpresa.Name = "cbxCondTributariaEmpresa";
            this.cbxCondTributariaEmpresa.Size = new System.Drawing.Size(166, 24);
            this.cbxCondTributariaEmpresa.TabIndex = 20;
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(La_Sandwicheria.Modelo.Dominio.Empresa);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Condición Tributaria:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(162, 43);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.ReadOnly = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(353, 22);
            this.txtNombreEmpresa.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre:";
            // 
            // bindingSourcePtoDeVenta
            // 
            this.bindingSourcePtoDeVenta.DataSource = typeof(La_Sandwicheria.Modelo.Dominio.PuntoDeVenta);
            // 
            // cbxPuntoDeVenta
            // 
            this.cbxPuntoDeVenta.DataSource = this.bindingSourcePtoDeVenta;
            this.cbxPuntoDeVenta.DisplayMember = "NombreDelPunto";
            this.cbxPuntoDeVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPuntoDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuntoDeVenta.FormattingEnabled = true;
            this.cbxPuntoDeVenta.Location = new System.Drawing.Point(243, 70);
            this.cbxPuntoDeVenta.Name = "cbxPuntoDeVenta";
            this.cbxPuntoDeVenta.Size = new System.Drawing.Size(245, 24);
            this.cbxPuntoDeVenta.TabIndex = 22;
            this.cbxPuntoDeVenta.ValueMember = "NroPuntoDeVenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Punto de Venta::";
            // 
            // VistaTerminarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 508);
            this.Controls.Add(this.cbxPuntoDeVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnAcabarVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistaTerminarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerminarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePtoDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnAcabarVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeYNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCondTributariaEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSourcePtoDeVenta;
        private System.Windows.Forms.ComboBox cbxPuntoDeVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.BindingSource bindingSourceCliente;
        private System.Windows.Forms.ComboBox cbxCondTributariaCliente;
    }
}