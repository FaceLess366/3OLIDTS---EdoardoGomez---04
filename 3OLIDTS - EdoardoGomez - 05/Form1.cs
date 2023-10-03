using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3OLIDTS___EdoardoGomez___05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1guardar_Click(object sender, EventArgs e)
        {
            string nombres = txtnombre.Text;
            string apellidos = txtapellido.Text;
            string telefono = txttelefono.Text;
            string estatura = txtestatura.Text;
            string edad = txtedad.Text;

            //Obtenemos genero seleccionado 
            string genero = " ";

            if (rbnormal.Checked)
            {
                genero = "Hombre";
            }
            else if (rbnonormal.Checked)
            {
                genero = "Mujer";
            }
            //Crear cadena con los datos

            string datos = $"Nombres: {nombres}\r\n Apellidos:{apellidos} \r\n Telefono:{telefono} \r\n Estatura:{estatura} \r\n Edad :{edad}\r\n Genero:{genero}";
            //Guardar los datos en un archivo de texto
            string rutaArchivo = "C:/Users/gomez/Documents/datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter write = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    //Si el archivo existe, añadir un separador antes del nuevo registro
                    write.WriteLine();
                }
                write.WriteLine(datos);

                //Mensaje de que los datos fueron capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn2limpiar_Click(object sender, EventArgs e)
        {
            //Limpieza
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txttelefono.Clear();
            txtestatura.Clear();
            rbnormal.Checked = false;
            rbnonormal.Checked = false;
        }
    }
}
