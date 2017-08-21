namespace Practica1
{
    partial class ColaMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaMensajes));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lbOp = new System.Windows.Forms.Label();
            this.btnOperar = new ns1.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMensajes = new System.Windows.Forms.GroupBox();
            this.txtPostorden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInorden = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.gbMensajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 738);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 45);
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
            this.panel2.Size = new System.Drawing.Size(1048, 41);
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
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cola de Mensajes";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(968, 4);
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
            this.lblSalir.Location = new System.Drawing.Point(1003, 6);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(26, 29);
            this.lblSalir.TabIndex = 10;
            this.lblSalir.Text = "x";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lbOp
            // 
            this.lbOp.AutoSize = true;
            this.lbOp.BackColor = System.Drawing.Color.Transparent;
            this.lbOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOp.ForeColor = System.Drawing.Color.White;
            this.lbOp.Location = new System.Drawing.Point(405, 68);
            this.lbOp.Name = "lbOp";
            this.lbOp.Size = new System.Drawing.Size(229, 25);
            this.lbOp.TabIndex = 12;
            this.lbOp.Text = "Operaciones en Cola: ";
            // 
            // btnOperar
            // 
            this.btnOperar.ActiveBorderThickness = 1;
            this.btnOperar.ActiveCornerRadius = 20;
            this.btnOperar.ActiveFillColor = System.Drawing.Color.LightCyan;
            this.btnOperar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnOperar.ActiveLineColor = System.Drawing.Color.LightCyan;
            this.btnOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnOperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOperar.BackgroundImage")));
            this.btnOperar.ButtonText = "Operar";
            this.btnOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnOperar.IdleBorderThickness = 1;
            this.btnOperar.IdleCornerRadius = 25;
            this.btnOperar.IdleFillColor = System.Drawing.Color.White;
            this.btnOperar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnOperar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnOperar.Location = new System.Drawing.Point(434, 110);
            this.btnOperar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(200, 60);
            this.btnOperar.TabIndex = 13;
            this.btnOperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Carnet que Hizo el Mensaje";
            // 
            // gbMensajes
            // 
            this.gbMensajes.Controls.Add(this.txtArea);
            this.gbMensajes.Controls.Add(this.txtPostorden);
            this.gbMensajes.Controls.Add(this.label7);
            this.gbMensajes.Controls.Add(this.txtInorden);
            this.gbMensajes.Controls.Add(this.label6);
            this.gbMensajes.Controls.Add(this.txtOperacion);
            this.gbMensajes.Controls.Add(this.label5);
            this.gbMensajes.Controls.Add(this.txtIp);
            this.gbMensajes.Controls.Add(this.label4);
            this.gbMensajes.Controls.Add(this.txtCarnet);
            this.gbMensajes.Controls.Add(this.label3);
            this.gbMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMensajes.ForeColor = System.Drawing.Color.White;
            this.gbMensajes.Location = new System.Drawing.Point(-10, 179);
            this.gbMensajes.Name = "gbMensajes";
            this.gbMensajes.Size = new System.Drawing.Size(1065, 563);
            this.gbMensajes.TabIndex = 15;
            this.gbMensajes.TabStop = false;
            this.gbMensajes.Text = "-Mensajes";
            // 
            // txtPostorden
            // 
            this.txtPostorden.Enabled = false;
            this.txtPostorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostorden.Location = new System.Drawing.Point(149, 495);
            this.txtPostorden.Name = "txtPostorden";
            this.txtPostorden.Size = new System.Drawing.Size(265, 30);
            this.txtPostorden.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(145, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Operarion en Postorden";
            // 
            // txtInorden
            // 
            this.txtInorden.Enabled = false;
            this.txtInorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInorden.Location = new System.Drawing.Point(149, 400);
            this.txtInorden.Name = "txtInorden";
            this.txtInorden.Size = new System.Drawing.Size(265, 30);
            this.txtInorden.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(145, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Operarion en Inorden";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Enabled = false;
            this.txtOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperacion.Location = new System.Drawing.Point(149, 294);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(265, 30);
            this.txtOperacion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Resultado de la Operacion";
            // 
            // txtIp
            // 
            this.txtIp.Enabled = false;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(149, 184);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(265, 30);
            this.txtIp.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "IP que Hizo el Mensaje";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Enabled = false;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(149, 86);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(265, 30);
            this.txtCarnet.TabIndex = 15;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(498, 42);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(475, 483);
            this.txtArea.TabIndex = 24;
            this.txtArea.Text = "";
            // 
            // ColaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1048, 783);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbMensajes);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lbOp);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColaMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColaMensajes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbMensajes.ResumeLayout(false);
            this.gbMensajes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lbOp;
        private ns1.BunifuThinButton2 btnOperar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMensajes;
        private System.Windows.Forms.TextBox txtPostorden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInorden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.RichTextBox txtArea;
    }
}