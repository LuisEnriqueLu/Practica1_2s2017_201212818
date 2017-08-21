namespace Practica1
{
    partial class RespuestasMensajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespuestasMensajes));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAntiguos = new ns1.BunifuThinButton2();
            this.btnRecientes = new ns1.BunifuThinButton2();
            this.btnRegresar = new ns1.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 693);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 43);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMinimizar);
            this.panel2.Controls.Add(this.lblSalir);
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 41);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Respuesta de Mensajes";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(1020, 5);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(24, 33);
            this.lblMinimizar.TabIndex = 11;
            this.lblMinimizar.Text = "-";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(1055, 7);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(26, 29);
            this.lblSalir.TabIndex = 10;
            this.lblSalir.Text = "x";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.IP,
            this.Inorden,
            this.Postorden,
            this.Resultado});
            this.dgvDatos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDatos.Location = new System.Drawing.Point(39, 70);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 80;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1026, 446);
            this.dgvDatos.TabIndex = 13;
            // 
            // Carnet
            // 
            this.Carnet.Frozen = true;
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            this.Carnet.ReadOnly = true;
            this.Carnet.Width = 132;
            // 
            // IP
            // 
            this.IP.Frozen = true;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 72;
            // 
            // Inorden
            // 
            this.Inorden.Frozen = true;
            this.Inorden.HeaderText = "Inorden";
            this.Inorden.Name = "Inorden";
            this.Inorden.ReadOnly = true;
            this.Inorden.Width = 143;
            // 
            // Postorden
            // 
            this.Postorden.Frozen = true;
            this.Postorden.HeaderText = "Postorden";
            this.Postorden.Name = "Postorden";
            this.Postorden.ReadOnly = true;
            this.Postorden.Width = 177;
            // 
            // Resultado
            // 
            this.Resultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Resultado.Frozen = true;
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Resultado.Width = 176;
            // 
            // btnAntiguos
            // 
            this.btnAntiguos.ActiveBorderThickness = 1;
            this.btnAntiguos.ActiveCornerRadius = 20;
            this.btnAntiguos.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAntiguos.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAntiguos.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAntiguos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAntiguos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAntiguos.BackgroundImage")));
            this.btnAntiguos.ButtonText = "Mostrar por mas Antiguos";
            this.btnAntiguos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntiguos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntiguos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAntiguos.IdleBorderThickness = 1;
            this.btnAntiguos.IdleCornerRadius = 25;
            this.btnAntiguos.IdleFillColor = System.Drawing.Color.White;
            this.btnAntiguos.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.btnAntiguos.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.btnAntiguos.Location = new System.Drawing.Point(85, 543);
            this.btnAntiguos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAntiguos.Name = "btnAntiguos";
            this.btnAntiguos.Size = new System.Drawing.Size(440, 58);
            this.btnAntiguos.TabIndex = 12;
            this.btnAntiguos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAntiguos.Click += new System.EventHandler(this.btnAntiguos_Click);
            // 
            // btnRecientes
            // 
            this.btnRecientes.ActiveBorderThickness = 1;
            this.btnRecientes.ActiveCornerRadius = 20;
            this.btnRecientes.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.btnRecientes.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.btnRecientes.ActiveLineColor = System.Drawing.Color.LightSkyBlue;
            this.btnRecientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRecientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecientes.BackgroundImage")));
            this.btnRecientes.ButtonText = "Mostrar por mas Recientes";
            this.btnRecientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecientes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRecientes.IdleBorderThickness = 1;
            this.btnRecientes.IdleCornerRadius = 25;
            this.btnRecientes.IdleFillColor = System.Drawing.Color.White;
            this.btnRecientes.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnRecientes.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnRecientes.Location = new System.Drawing.Point(588, 543);
            this.btnRecientes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRecientes.Name = "btnRecientes";
            this.btnRecientes.Size = new System.Drawing.Size(440, 58);
            this.btnRecientes.TabIndex = 14;
            this.btnRecientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecientes.Click += new System.EventHandler(this.btnRecientes_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.ActiveBorderThickness = 1;
            this.btnRegresar.ActiveCornerRadius = 20;
            this.btnRegresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegresar.ActiveForecolor = System.Drawing.Color.Green;
            this.btnRegresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.ButtonText = "Regresar";
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRegresar.IdleBorderThickness = 1;
            this.btnRegresar.IdleCornerRadius = 25;
            this.btnRegresar.IdleFillColor = System.Drawing.Color.White;
            this.btnRegresar.IdleForecolor = System.Drawing.Color.LimeGreen;
            this.btnRegresar.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.btnRegresar.Location = new System.Drawing.Point(410, 613);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(306, 58);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RespuestasMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1102, 736);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRecientes);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnAntiguos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RespuestasMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RespuestasMensajes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private ns1.BunifuThinButton2 btnAntiguos;
        private ns1.BunifuThinButton2 btnRecientes;
        private ns1.BunifuThinButton2 btnRegresar;
    }
}