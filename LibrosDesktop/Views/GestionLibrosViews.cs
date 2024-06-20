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
    public partial class GestionLibrosViews : Form
    {
        LibroRepository repo = new LibroRepository();
        public GestionLibrosViews()
        {
            InitializeComponent();
            CargarLibrosAlaGrilla();
        }

        private async void CargarLibrosAlaGrilla()
        {
            dataGridLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void dataGridLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNAg_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.ShowDialog();
            CargarLibrosAlaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtener el mensaje del libro seleccionado y su nombre
            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;
            string? nombreLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[1].Value;
            //
            DialogResult respuesta = MessageBox.Show($"Estas seguro que quiere borrar el libro {nombreLibroSeleccionado} ?",
                "Eliminar libro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //mostramos un mensajebox que pregunta si esta seguro de que decea eleiminar
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idLibroSeleccionado);
                CargarLibrosAlaGrilla();
            }
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            //tambien tenemos wue obtener el id del libro seleccionado 
            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;
            // instanciar la ventana AgregarEditarLibros y pasarle ese id a su
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(idLibroSeleccionado);

            agregarEditarLibroView.ShowDialog();
            /// vamos a tener q crear un nurvo conctructos 
            CargarLibrosAlaGrilla();
        }
    }
}
