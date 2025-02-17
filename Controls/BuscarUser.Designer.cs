namespace Controls
{
    partial class BuscarUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarUser));
            this.dgVer = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbofiltro = new System.Windows.Forms.ComboBox();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVer)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVer
            // 
            this.dgVer.AllowUserToAddRows = false;
            this.dgVer.AllowUserToDeleteRows = false;
            this.dgVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVer.BackgroundColor = System.Drawing.Color.White;
            this.dgVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVer.GridColor = System.Drawing.Color.White;
            this.dgVer.Location = new System.Drawing.Point(9, 183);
            this.dgVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVer.Name = "dgVer";
            this.dgVer.ReadOnly = true;
            this.dgVer.RowHeadersVisible = false;
            this.dgVer.RowHeadersWidth = 62;
            this.dgVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVer.Size = new System.Drawing.Size(526, 175);
            this.dgVer.TabIndex = 51;
            this.dgVer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVer_CellContentClick);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnsalir);
            this.Panel1.Location = new System.Drawing.Point(9, 365);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(526, 62);
            this.Panel1.TabIndex = 52;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(466, 0);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 62);
            this.btnsalir.TabIndex = 45;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.label4);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.cbofiltro);
            this.Panel3.Controls.Add(this.txtfiltro);
            this.Panel3.Location = new System.Drawing.Point(9, 8);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(526, 169);
            this.Panel3.TabIndex = 53;
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
            this.label4.Size = new System.Drawing.Size(526, 54);
            this.label4.TabIndex = 1139;
            this.label4.Text = "BUSCAR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(22, 121);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 24);
            this.Label2.TabIndex = 1107;
            this.Label2.Text = "Valor";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(22, 80);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 24);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Filtro";
            // 
            // cbofiltro
            // 
            this.cbofiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbofiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofiltro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofiltro.FormattingEnabled = true;
            this.cbofiltro.Location = new System.Drawing.Point(89, 76);
            this.cbofiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbofiltro.Name = "cbofiltro";
            this.cbofiltro.Size = new System.Drawing.Size(416, 31);
            this.cbofiltro.TabIndex = 8;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(89, 118);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(416, 30);
            this.txtfiltro.TabIndex = 7;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // BuscarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgVer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Name = "BuscarUser";
            this.Size = new System.Drawing.Size(548, 438);
            this.Load += new System.EventHandler(this.BuscarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVer)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgVer;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbofiltro;
        internal System.Windows.Forms.TextBox txtfiltro;
        internal System.Windows.Forms.Label label4;
    }
}

