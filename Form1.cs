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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsDatabase.mostar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        persona p = new persona();
        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textNombre.Text;
            p.Apellido = textApellido.Text;
            p.Fecha_nacimiento1 = FechaCampo.Value;
            p.Genero= textGenero.Text;
            p.Estado_civil = textEstado.Text;
            p.Direccion = texDireccion.Text;
            p.Movil = textMovil.Text;
            p.Telefono = textTelefono.Text;
            p.Correo_electronico= textCorreo.Text;
            ClsDatabase.insertar(p);
            dataGridView1.DataSource = ClsDatabase.mostar();

            textID.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            FechaCampo.Text = "";
            texDireccion.Text = "";
            textGenero.Text = "";
            textEstado.Text = "";
            textMovil.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Id = int.Parse(textID.Text);
            p.Nombre = textNombre.Text;
            p.Apellido = textApellido.Text;
            p.Fecha_nacimiento1 = FechaCampo.Value;
            p.Genero = textGenero.Text;
            p.Estado_civil = textEstado.Text;
            p.Movil = textMovil.Text;
            p.Telefono = textTelefono.Text;
            p.Correo_electronico = textCorreo.Text;
            ClsDatabase.Modificar(p);
            dataGridView1.DataSource = ClsDatabase.mostar();

            textID.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            FechaCampo.Text = "";
            texDireccion.Text = "";
            textGenero.Text = "";
            textEstado.Text = "";
            textMovil.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Id = int.Parse(textID.Text);
            ClsDatabase.Eliminar(p);
            dataGridView1.DataSource = ClsDatabase.mostar();


            textID.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            FechaCampo.Text = "";
            texDireccion.Text = "";
            textGenero.Text = "";
            textEstado.Text = "";
            textMovil.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            persona p = new persona();
            p.Nombre = textBuscar.Text;
            try
            {  
                dataGridView1.DataSource = ClsDatabase.Buscar(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
