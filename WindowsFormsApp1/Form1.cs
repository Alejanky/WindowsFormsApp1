using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private enum MethodoContacto
        {
            Ninguno,
            CorreoElectronico,
            Telefono
        }
        private struct Contacto
        {
            public string Nombre;
            public string Direccion;
            public string Ciudad;
            public string Estado;
            public string CP;
            public string Email;
            public string Telefono;
            public MethodoContacto metodocon;
        }
        private Dictionary<string, Contacto> Contactos =
            new Dictionary<string, Contacto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacto nuevoContacto;
            nuevoContacto.Nombre = textBox1.Text;
            nuevoContacto.Direccion = textBox2.Text;
            nuevoContacto.Ciudad = textBox3.Text;
            nuevoContacto.Estado = textBox4.Text;
            nuevoContacto.CP = textBox5.Text;
            nuevoContacto.Email = textBox6.Text;
            nuevoContacto.Telefono = textBox7.Text;
            nuevoContacto.metodocon = (MethodoContacto)comboBox1.SelectedIndex;
            //
            Contactos[textBox1.Text] = nuevoContacto;
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            //
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buscar del nombre
            
            //Muestre los daots 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // elimine el dato que actualmene se muestra en la pantalla 
            // en caso de no existir datos, mandar un mensaje de error

            // limpie los datos de la panatalla

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // tiene que guardar en algun archivo la informacion y de la informacion tiene que guardar todo menos el nombre 
        }
    }
}
