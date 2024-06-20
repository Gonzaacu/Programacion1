using MotorolaDesktop.Models;
using MotorolaDesktop.RepositoriesCell;
using MotorolaDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorolaDesktop.Views
{
    public partial class GestionCelularesView : Form
    {
        CelularesRepository repo = new CelularesRepository();
        public GestionCelularesView()
        {
            InitializeComponent();
            CargarCelusALaGrilla();
        }

        private async void CargarCelusALaGrilla()
        {
            dataGridCelus.DataSource = await repo.ObtenerCelularesAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCeluView agregarEditarCelularView = new AgregarEditarCeluView();
            agregarEditarCelularView.ShowDialog();
            CargarCelusALaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string? idCelularSeleccionado = (string)dataGridCelus.CurrentRow.Cells[0].Value;
            string? nombreCelularSeleccionado = (string)dataGridCelus.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que quiere borrar el celular {nombreCelularSeleccionado} ?",
                               "Eliminar Celular",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idCelularSeleccionado);

                CargarCelusALaGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string? idCelularSeleccionado = (string)dataGridCelus.CurrentRow.Cells[0].Value;

            AgregarEditarCeluView agregarEditarCelularView = new AgregarEditarCeluView(idCelularSeleccionado);

            agregarEditarCelularView.ShowDialog();

            CargarCelusALaGrilla();
        }
    }
}
