using System;

namespace BitsAndBytes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPrimero = new System.Windows.Forms.DateTimePicker();
            this.pbJarra = new System.Windows.Forms.PictureBox();
            this.pbSeñales = new System.Windows.Forms.PictureBox();
            this.pbSensor2 = new System.Windows.Forms.PictureBox();
            this.pbSensorUno = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeñales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensorUno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(70, 101);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(5);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(164, 30);
            this.txtEntrada.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackgroundImage = global::BitsAndBytes.Properties.Resources._1510159916691;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Location = new System.Drawing.Point(437, 96);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(125, 41);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada";
            // 
            // dtpPrimero
            // 
            this.dtpPrimero.Location = new System.Drawing.Point(70, 311);
            this.dtpPrimero.Margin = new System.Windows.Forms.Padding(5);
            this.dtpPrimero.Name = "dtpPrimero";
            this.dtpPrimero.Size = new System.Drawing.Size(331, 30);
            this.dtpPrimero.TabIndex = 4;
            // 
            // pbJarra
            // 
            this.pbJarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbJarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJarra.Location = new System.Drawing.Point(306, 148);
            this.pbJarra.Margin = new System.Windows.Forms.Padding(5);
            this.pbJarra.Name = "pbJarra";
            this.pbJarra.Size = new System.Drawing.Size(124, 101);
            this.pbJarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJarra.TabIndex = 8;
            this.pbJarra.TabStop = false;
            this.pbJarra.Visible = false;
            // 
            // pbSeñales
            // 
            this.pbSeñales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSeñales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSeñales.Location = new System.Drawing.Point(463, 147);
            this.pbSeñales.Margin = new System.Windows.Forms.Padding(5);
            this.pbSeñales.Name = "pbSeñales";
            this.pbSeñales.Size = new System.Drawing.Size(118, 102);
            this.pbSeñales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeñales.TabIndex = 7;
            this.pbSeñales.TabStop = false;
            this.pbSeñales.Visible = false;
            this.pbSeñales.Click += new System.EventHandler(this.pbSeñales_Click);
            // 
            // pbSensor2
            // 
            this.pbSensor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSensor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSensor2.Location = new System.Drawing.Point(144, 148);
            this.pbSensor2.Margin = new System.Windows.Forms.Padding(5);
            this.pbSensor2.Name = "pbSensor2";
            this.pbSensor2.Size = new System.Drawing.Size(129, 101);
            this.pbSensor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSensor2.TabIndex = 6;
            this.pbSensor2.TabStop = false;
            this.pbSensor2.Visible = false;
            // 
            // pbSensorUno
            // 
            this.pbSensorUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSensorUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSensorUno.Location = new System.Drawing.Point(14, 147);
            this.pbSensorUno.Margin = new System.Windows.Forms.Padding(5);
            this.pbSensorUno.Name = "pbSensorUno";
            this.pbSensorUno.Size = new System.Drawing.Size(110, 102);
            this.pbSensorUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSensorUno.TabIndex = 5;
            this.pbSensorUno.TabStop = false;
            this.pbSensorUno.Visible = false;
            this.pbSensorUno.Click += new System.EventHandler(this.pbSensorUno_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImage = global::BitsAndBytes.Properties.Resources._151015991669;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(463, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajustar Fecha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(490, 375);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 30);
            this.txtResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitsAndBytes.Properties.Resources.spring_day_island_wallpaper_dauntless_2560x1600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpPrimero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.pbJarra);
            this.Controls.Add(this.pbSeñales);
            this.Controls.Add(this.pbSensor2);
            this.Controls.Add(this.pbSensorUno);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeñales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensorUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pbSeñales_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPrimero;
        private System.Windows.Forms.PictureBox pbSensorUno;
        private System.Windows.Forms.PictureBox pbSensor2;
        private System.Windows.Forms.PictureBox pbSeñales;
        private System.Windows.Forms.PictureBox pbJarra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

