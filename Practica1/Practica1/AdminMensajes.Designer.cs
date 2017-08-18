namespace Practica1
{
    partial class AdminMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMensajes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRespuestas = new ns1.BunifuThinButton2();
            this.btnCola = new ns1.BunifuThinButton2();
            this.btnEnviar = new ns1.BunifuThinButton2();
            this.opd = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administración de Mensajes";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 43);
            this.panel3.TabIndex = 2;
            // 
            // btnRespuestas
            // 
            this.btnRespuestas.ActiveBorderThickness = 1;
            this.btnRespuestas.ActiveCornerRadius = 20;
            this.btnRespuestas.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuestas.ActiveForecolor = System.Drawing.Color.ForestGreen;
            this.btnRespuestas.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRespuestas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRespuestas.BackgroundImage")));
            this.btnRespuestas.ButtonText = "Ver Respuestas de Mensajes";
            this.btnRespuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespuestas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuestas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnRespuestas.IdleBorderThickness = 1;
            this.btnRespuestas.IdleCornerRadius = 25;
            this.btnRespuestas.IdleFillColor = System.Drawing.Color.White;
            this.btnRespuestas.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnRespuestas.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.btnRespuestas.Location = new System.Drawing.Point(200, 303);
            this.btnRespuestas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRespuestas.Name = "btnRespuestas";
            this.btnRespuestas.Size = new System.Drawing.Size(384, 77);
            this.btnRespuestas.TabIndex = 7;
            this.btnRespuestas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRespuestas.Click += new System.EventHandler(this.btnRespuestas_Click);
            // 
            // btnCola
            // 
            this.btnCola.ActiveBorderThickness = 1;
            this.btnCola.ActiveCornerRadius = 20;
            this.btnCola.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnCola.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnCola.ActiveLineColor = System.Drawing.Color.Gainsboro;
            this.btnCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCola.BackgroundImage")));
            this.btnCola.ButtonText = "Ver Cola de Mensajes";
            this.btnCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCola.IdleBorderThickness = 1;
            this.btnCola.IdleCornerRadius = 25;
            this.btnCola.IdleFillColor = System.Drawing.Color.White;
            this.btnCola.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCola.IdleLineColor = System.Drawing.Color.Gray;
            this.btnCola.Location = new System.Drawing.Point(232, 195);
            this.btnCola.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(325, 78);
            this.btnCola.TabIndex = 6;
            this.btnCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 20;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.Navy;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Enviar Mensajes";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 25;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.White;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.Navy;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.Navy;
            this.btnEnviar.Location = new System.Drawing.Point(266, 89);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(7);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(257, 72);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // opd
            // 
            this.opd.FileName = "op";
            // 
            // AdminMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.btnRespuestas);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMensajes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuThinButton2 btnRespuestas;
        private ns1.BunifuThinButton2 btnCola;
        private ns1.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.OpenFileDialog opd;
    }
}