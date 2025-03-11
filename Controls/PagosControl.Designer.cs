namespace Controls
{
    partial class PagosControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosControl));
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.rbtPagoParcial = new System.Windows.Forms.RadioButton();
            this.rbtPagoTotal = new System.Windows.Forms.RadioButton();
            this.txtCodigoMensualidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnDetallePago = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            this.dgvCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.fecha,
            this.pagototal,
            this.valor,
            this.Observacion});
            this.dgvCurso.Location = new System.Drawing.Point(14, 434);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersVisible = false;
            this.dgvCurso.RowHeadersWidth = 62;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(737, 268);
            this.dgvCurso.TabIndex = 1136;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Code";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "date";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // pagototal
            // 
            this.pagototal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pagototal.DataPropertyName = "IsTotalPay";
            this.pagototal.HeaderText = "Pago total/parcial";
            this.pagototal.MinimumWidth = 8;
            this.pagototal.Name = "pagototal";
            this.pagototal.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor.DataPropertyName = "Value";
            this.valor.HeaderText = "Valor a pagado";
            this.valor.MinimumWidth = 8;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observacion.DataPropertyName = "remark";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 8;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.txtCodigo);
            this.Panel1.Controls.Add(this.txtObservaciones);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.txtFecha);
            this.Panel1.Controls.Add(this.txtTotalPagar);
            this.Panel1.Controls.Add(this.rbtPagoParcial);
            this.Panel1.Controls.Add(this.rbtPagoTotal);
            this.Panel1.Controls.Add(this.txtCodigoMensualidad);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(14, 10);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(737, 351);
            this.Panel1.TabIndex = 1137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(105, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 1164;
            this.label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(191, 117);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 40;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(530, 30);
            this.txtCodigo.TabIndex = 1163;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(194, 239);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservaciones.MaxLength = 40;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(527, 78);
            this.txtObservaciones.TabIndex = 1161;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(34, 244);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(152, 24);
            this.Label3.TabIndex = 1162;
            this.Label3.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1160;
            this.label1.Text = "Mensualidad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(116, 162);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 24);
            this.Label2.TabIndex = 1159;
            this.Label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(193, 159);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(527, 30);
            this.txtFecha.TabIndex = 1158;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalPagar.Location = new System.Drawing.Point(388, 199);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPagar.MaxLength = 40;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(333, 30);
            this.txtTotalPagar.TabIndex = 1157;
            // 
            // rbtPagoParcial
            // 
            this.rbtPagoParcial.AutoSize = true;
            this.rbtPagoParcial.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPagoParcial.Location = new System.Drawing.Point(220, 203);
            this.rbtPagoParcial.Name = "rbtPagoParcial";
            this.rbtPagoParcial.Size = new System.Drawing.Size(152, 28);
            this.rbtPagoParcial.TabIndex = 1156;
            this.rbtPagoParcial.TabStop = true;
            this.rbtPagoParcial.Text = "Pago parcial";
            this.rbtPagoParcial.UseVisualStyleBackColor = true;
            this.rbtPagoParcial.CheckedChanged += new System.EventHandler(this.rbtPagoParcial_CheckedChanged);
            // 
            // rbtPagoTotal
            // 
            this.rbtPagoTotal.AutoSize = true;
            this.rbtPagoTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPagoTotal.Location = new System.Drawing.Point(59, 203);
            this.rbtPagoTotal.Name = "rbtPagoTotal";
            this.rbtPagoTotal.Size = new System.Drawing.Size(131, 28);
            this.rbtPagoTotal.TabIndex = 1155;
            this.rbtPagoTotal.TabStop = true;
            this.rbtPagoTotal.Text = "Pago total";
            this.rbtPagoTotal.UseVisualStyleBackColor = true;
            this.rbtPagoTotal.CheckedChanged += new System.EventHandler(this.rbtPagoTotal_CheckedChanged);
            // 
            // txtCodigoMensualidad
            // 
            this.txtCodigoMensualidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoMensualidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMensualidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigoMensualidad.Location = new System.Drawing.Point(191, 75);
            this.txtCodigoMensualidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoMensualidad.MaxLength = 40;
            this.txtCodigoMensualidad.Name = "txtCodigoMensualidad";
            this.txtCodigoMensualidad.ReadOnly = true;
            this.txtCodigoMensualidad.Size = new System.Drawing.Size(530, 30);
            this.txtCodigoMensualidad.TabIndex = 1143;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(737, 54);
            this.label4.TabIndex = 1139;
            this.label4.Text = "PAGOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnPdf);
            this.Panel3.Controls.Add(this.btnDetallePago);
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Controls.Add(this.btnEliminar);
            this.Panel3.Controls.Add(this.btnSalir);
            this.Panel3.Location = new System.Drawing.Point(14, 366);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(737, 62);
            this.Panel3.TabIndex = 1138;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Location = new System.Drawing.Point(437, 0);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(60, 62);
            this.btnPdf.TabIndex = 1101;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnDetallePago
            // 
            this.btnDetallePago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetallePago.BackgroundImage")));
            this.btnDetallePago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetallePago.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetallePago.FlatAppearance.BorderSize = 0;
            this.btnDetallePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallePago.Location = new System.Drawing.Point(497, 0);
            this.btnDetallePago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetallePago.Name = "btnDetallePago";
            this.btnDetallePago.Size = new System.Drawing.Size(60, 62);
            this.btnDetallePago.TabIndex = 1100;
            this.btnDetallePago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetallePago.UseVisualStyleBackColor = true;
            this.btnDetallePago.Click += new System.EventHandler(this.btnDetallePago_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(557, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1097;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(617, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 62);
            this.btnEliminar.TabIndex = 1098;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(677, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PagosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.Panel1);
            this.Name = "PagosControl";
            this.Size = new System.Drawing.Size(763, 712);
            this.Load += new System.EventHandler(this.PagosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCurso;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtCodigoMensualidad;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.RadioButton rbtPagoParcial;
        private System.Windows.Forms.RadioButton rbtPagoTotal;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker txtFecha;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtObservaciones;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnDetallePago;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnPdf;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}
