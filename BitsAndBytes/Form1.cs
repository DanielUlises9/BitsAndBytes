using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitsAndBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public int RecorrerBits (int Numero)
        {
            Numero >>= 1;
            /* 321
             * 000
             * 001
             * 010
             * 100
             * 101
             * 110
             * 111
             */
            int direccion = Numero & 7;
            Numero >>= 3;
            /* 21
             * 00
             * 01
             * 10
             * 11 
             */
            int tanque = Numero & 3;
            Numero >>= 2;

            int bit6 = Numero & 1;
            Numero >>= 1;
            int bit7 = Numero & 1;
            Numero >>= 1;
           
            /* Bytes Numero 2 y 3
             * 
             * d d d d d
             * m m m m 
             * a a a a a a a 
             */

            int dia = Numero & 31;
            Numero >>= 5;
            int mes = Numero & 15;
            Numero >>= 4;
            int año= Numero & 127;
            Numero >>= 7;
           
            return Fecha(año,mes,dia) + SensoresYDirecciones(bit6, bit7, direccion, tanque);

        }

        public int Fecha (int año, int mes,int dia)
        {

            if (dia > 31)
            {
                MessageBox.Show("El valor de dia es mayor que 31, se tomara como 31");
                dia = 31;
            }
            else if (dia < 1)
            {
                MessageBox.Show("El valor del dia es menor que 1, se tomara como 1");
                dia = 1;
            }
            if (mes < 1)
            {
                MessageBox.Show("El valor del mes es menor que 1, se tomara como 1");
                mes = 1;
            }
            else if (mes > 12)
            {
                mes = 12;
                MessageBox.Show("Sobre pasa el valor del mes, se tomara como 12");
            }
            else if (mes == 4)
            {
                if (dia > 30)
                {
                    MessageBox.Show("Los dias de este mes no pueden ser mayor que 30, se tomara como 30");
                    dia = 30;
                }
            }else if (mes == 2)
            {
                if (dia > 28)
                {
                    MessageBox.Show("Los dias de este mes no pueden ser mayor que 28, se tomara como 28");
                    dia = 1;
                }
            }else if(mes == 6)
            {
                if (dia > 30)
                {
                    MessageBox.Show("Los dias de este mes no pueden ser mayor que 30, se tomara como 30");
                    dia = 30;
                }
            }
            dtpPrimero.Value = new DateTime(año + 1900, mes, dia);
            return 0;
        }

        public int SensoresYDirecciones(int NumeroUno, int NumeroDos,int Direcciones,int llenado)
        {
            switch (NumeroUno)
            {
                case 0:this.pbSensorUno.Image = BitsAndBytes.Properties.Resources.Apagado;
                    this.pbSensorUno.Visible = true; break;
                case 1:this.pbSensorUno.Image = BitsAndBytes.Properties.Resources.Encendido;
                    this.pbSensorUno.Visible = true; break;

            }

            switch (NumeroDos)
            {
                case 0:this.pbSensor2.Image = BitsAndBytes.Properties.Resources.Apagado;
                    this.pbSensor2.Visible = true; break;
                case 1:this.pbSensor2.Image = BitsAndBytes.Properties.Resources.Encendido;
                    this.pbSensor2.Visible = true; break;
            }
            switch (Direcciones)
            {
                case 0: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.N; 
                    this.pbSeñales.Visible = true; break;
                case 1: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.NE;
                    this.pbSeñales.Visible = true; break;
                case 2: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.E;
                    this.pbSeñales.Visible = true; break;
                case 3: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.SE;
                    this.pbSeñales.Visible = true; break;
                case 4: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.S;
                    this.pbSeñales.Visible = true; break;
                case 5: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.SO;
                    this.pbSeñales.Visible = true; break;
                case 6: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.O;
                    this.pbSeñales.Visible = true; break;
                case 7: this.pbSeñales.Image = BitsAndBytes.Properties.Resources.NO;
                    this.pbSeñales.Visible = true; break;
            }
            switch(llenado)
            {
                case 0:this.pbJarra.Image = BitsAndBytes.Properties.Resources.Vacio;
                    this.pbJarra.Visible = true;  break;
                case 1:this.pbJarra.Image = BitsAndBytes.Properties.Resources.NivelMedio;
                    this.pbJarra.Visible = true; break;
                case 2:this.pbJarra.Image = BitsAndBytes.Properties.Resources.Lleno;
                    this.pbJarra.Visible = true; break;
                case 3:this.pbJarra.Image = BitsAndBytes.Properties.Resources.ProcesoDeLlenado;
                    this.pbJarra.Visible = true; break;
            }
            return 0;
        }
        public int CambioDeFecha(DateTime fecha)
        {
            /* Bytes Numero 2 y 3
            * 
            * d d d d d
            * m m m m 
            * a a a a a a a 
            */

            int fechEnNumeros;
            
            fechEnNumeros= fecha.Year;
            fechEnNumeros -= 1900;
            fechEnNumeros <<= 4;
            fechEnNumeros += fecha.Month;
            fechEnNumeros <<= 5;
            fechEnNumeros += fecha.Day;

            txtResultado.Text = Convert.ToString(fechEnNumeros);
            return 0;

        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            RecorrerBits(Convert.ToInt32(txtEntrada.Text));
        }

        private void pbSensorUno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambioDeFecha(dtpPrimero.Value);
        }

    }
}
