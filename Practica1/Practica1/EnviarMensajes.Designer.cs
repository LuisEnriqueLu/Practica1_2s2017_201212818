namespace Practica1
{
    partial class EnviarMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMensajes));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnCargarXML = new ns1.BunifuThinButton2();
            this.btnEnviarM = new ns1.BunifuThinButton2();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opd = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 43);
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
            this.panel2.Size = new System.Drawing.Size(802, 41);
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
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "EnviarMensajes";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(729, 4);
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
            this.lblSalir.Location = new System.Drawing.Point(764, 6);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(26, 29);
            this.lblSalir.TabIndex = 10;
            this.lblSalir.Text = "x";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnCargarXML
            // 
            this.btnCargarXML.ActiveBorderThickness = 1;
            this.btnCargarXML.ActiveCornerRadius = 20;
            this.btnCargarXML.ActiveFillColor = System.Drawing.Color.Chartreuse;
            this.btnCargarXML.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnCargarXML.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btnCargarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCargarXML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarXML.BackgroundImage")));
            this.btnCargarXML.ButtonText = "CargarXML";
            this.btnCargarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarXML.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCargarXML.IdleBorderThickness = 1;
            this.btnCargarXML.IdleCornerRadius = 25;
            this.btnCargarXML.IdleFillColor = System.Drawing.Color.White;
            this.btnCargarXML.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCargarXML.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCargarXML.Location = new System.Drawing.Point(274, 98);
            this.btnCargarXML.Margin = new System.Windows.Forms.Padding(7);
            this.btnCargarXML.Name = "btnCargarXML";
            this.btnCargarXML.Size = new System.Drawing.Size(257, 72);
            this.btnCargarXML.TabIndex = 6;
            this.btnCargarXML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargarXML.Click += new System.EventHandler(this.btnCargarXML_Click);
            // 
            // btnEnviarM
            // 
            this.btnEnviarM.ActiveBorderThickness = 1;
            this.btnEnviarM.ActiveCornerRadius = 20;
            this.btnEnviarM.ActiveFillColor = System.Drawing.Color.MediumTurquoise;
            this.btnEnviarM.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarM.ActiveLineColor = System.Drawing.Color.MediumTurquoise;
            this.btnEnviarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEnviarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarM.BackgroundImage")));
            this.btnEnviarM.ButtonText = "Enviar Mensaje";
            this.btnEnviarM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarM.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEnviarM.IdleBorderThickness = 1;
            this.btnEnviarM.IdleCornerRadius = 25;
            this.btnEnviarM.IdleFillColor = System.Drawing.Color.White;
            this.btnEnviarM.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarM.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarM.Location = new System.Drawing.Point(459, 288);
            this.btnEnviarM.Margin = new System.Windows.Forms.Padding(7);
            this.btnEnviarM.Name = "btnEnviarM";
            this.btnEnviarM.Size = new System.Drawing.Size(257, 72);
            this.btnEnviarM.TabIndex = 7;
            this.btnEnviarM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviarM.Click += new System.EventHandler(this.btnEnviarM_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(53, 272);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(265, 30);
            this.txtMensaje.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mensaje - Operacion";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(53, 376);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(265, 30);
            this.txtIP.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "IP a Enviar Mensaje";
            // 
            // opd
            // 
            this.opd.FileName = "op";
            // 
            // EnviarMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviarM);
            this.Controls.Add(this.btnCargarXML);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnviarMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarMensajes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSalir;
        private ns1.BunifuThinButton2 btnCargarXML;
        private ns1.BunifuThinButton2 btnEnviarM;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opd;
    }
}