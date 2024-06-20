using EjerciciosDePrueba.Models;
using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosDesktop.Views
{
    public partial class AgregarEditarLibroView : Form
    {
        private string idLibroSeleccionado;
        LibroRepository repo = new LibroRepository();
        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }

        //Constructor que resibe como parametros el id
        public AgregarEditarLibroView(string idLibroSeleccionado)
        {
            this.idLibroSeleccionado = idLibroSeleccionado;
            InitializeComponent();
            CaargarDatosLibrosEnPantalla();
        }

        private async void CaargarDatosLibrosEnPantalla()
        {
            Libros? libro = await repo.ObtenerPorIdAsync(idLibroSeleccionado);
            if (libro != null)
            {
                txtNombre.Text = libro.nombre;
                txtAutor.Text = libro.autor;
                txtEditorial.Text = libro.editorial;
                txtPortadaUrl.Text = libro.portada_url;
                txtSinopsis.Text = libro.sinopsis;  
                txtGenero.Text = libro.genero;
            }
            else
            {
                MessageBox.Show("Error ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarEditarLibroView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.idLibroSeleccionado != string.Empty) 
            {
                await repo.ActualizarAsync(txtNombre.Text,
                (int)numericPaginas.Value,
                txtAutor.Text,
                txtEditorial.Text,
                txtPortadaUrl.Text,
                txtSinopsis.Text,
                txtGenero.Text,
                this.idLibroSeleccionado);
            }
            else 
            {
                await repo.AgregarAsync(txtNombre.Text,
                (int)numericPaginas.Value,
                txtAutor.Text,
                txtEditorial.Text,
                txtPortadaUrl.Text,
                txtSinopsis.Text,
                txtGenero.Text);
            }
            

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
