namespace Controls
{
    partial class MensualidadControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensualidadControl));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnPreView = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnNuevo);
            this.Panel3.Controls.Add(this.btnPreView);
            this.Panel3.Controls.Add(this.btnSalir);
            this.Panel3.Location = new System.Drawing.Point(14, 188);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(746, 62);
            this.Panel3.TabIndex = 1135;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(566, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 62);
            this.btnNuevo.TabIndex = 1099;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnPreView
            // 
            this.btnPreView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreView.BackgroundImage")));
            this.btnPreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPreView.FlatAppearance.BorderSize = 0;
            this.btnPreView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreView.Location = new System.Drawing.Point(626, 0);
            this.btnPreView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(60, 62);
            this.btnPreView.TabIndex = 1098;
            this.btnPreView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreView.UseVisualStyleBackColor = true;
            this.btnPreView.Click += new System.EventHandler(this.btnPreView_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(686, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.mensualidad,
            this.valor,
            this.Descripcion,
            this.pago,
            this.pagar});
            this.dgvCurso.Location = new System.Drawing.Point(14, 255);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersVisible = false;
            this.dgvCurso.RowHeadersWidth = 62;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(746, 390);
            this.dgvCurso.TabIndex = 1133;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnMatricula);
            this.Panel1.Controls.Add(this.txtEstado);
            this.Panel1.Controls.Add(this.txtCodigo);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(14, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(746, 172);
            this.Panel1.TabIndex = 1134;
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.Transparent;
            this.btnMatricula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMatricula.BackgroundImage")));
            this.btnMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.Color.Black;
            this.btnMatricula.Location = new System.Drawing.Point(94, 91);
            this.btnMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(54, 31);
            this.btnMatricula.TabIndex = 1154;
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEstado.Location = new System.Drawing.Point(352, 91);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.MaxLength = 40;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(368, 30);
            this.txtEstado.TabIndex = 1145;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(156, 91);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 40;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(192, 30);
            this.txtCodigo.TabIndex = 1143;
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
            this.label4.Size = new System.Drawing.Size(746, 54);
            this.label4.TabIndex = 1139;
            this.label4.Text = "MENSUALIDAD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // mensualidad
            // 
            this.mensualidad.DataPropertyName = "Monthly";
            this.mensualidad.HeaderText = "Mensualidad";
            this.mensualidad.MinimumWidth = 8;
            this.mensualidad.Name = "mensualidad";
            this.mensualidad.ReadOnly = true;
            this.mensualidad.Width = 150;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor.DataPropertyName = "Value";
            this.valor.HeaderText = "Valor a pagar";
            this.valor.MinimumWidth = 8;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Detail";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pago.DataPropertyName = "IsConfirmed";
            this.pago.HeaderText = "Pago confirmado";
            this.pago.MinimumWidth = 8;
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // pagar
            // 
            this.pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagar.HeaderText = "";
            this.pagar.MinimumWidth = 8;
            this.pagar.Name = "pagar";
            this.pagar.ReadOnly = true;
            this.pagar.Text = "Pagar";
            this.pagar.UseColumnTextForButtonValue = true;
            this.pagar.Width = 150;
            // 
            // MensualidadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.Panel1);
            this.Name = "MensualidadControl";
            this.Size = new System.Drawing.Size(771, 655);
            this.Load += new System.EventHandler(this.MensualidadControl_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnPreView;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCurso;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewButtonColumn pagar;
    }
}
