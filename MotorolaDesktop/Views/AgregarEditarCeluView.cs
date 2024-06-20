using MotorolaDesktop.Models;
using MotorolaDesktop.RepositoriesCell;
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
    public partial class AgregarEditarCeluView : Form
    {
        private string idCelularSeleccionado;
        private CelularesRepository repo = new CelularesRepository();



        public AgregarEditarCeluView()
        {
            InitializeComponent();

        }



        public AgregarEditarCeluView(string idCelularSeleccionado){
            this.idCelularSeleccionado = idCelularSeleccionado;
            InitializeComponent();
            CargarDatosCelularPantalla();
        }
        
    private async void CargarDatosCelularPantalla()
        {
            Celulares? celulares = await repo.ObtenerPorIdAsync(this.idCelularSeleccionado);
            if (celulares != null)
            {
                txtNombre.Text = celulares.nombre;
                txtModelo.Text = celulares.modelo;
                txtAutor.Text = celulares.autor;
                txtUrlimagen.Text = celulares.urlimagen;
                txtDescripcion.Text = celulares.descripcion;
            }
            else
                MessageBox.Show("no se encontro el libro");
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.idCelularSeleccionado != string.Empty)
            {
                await repo.ActualizarAsync(txtNombre.Text,
                              txtModelo.Text,
                              txtAutor.Text,
                              txtUrlimagen.Text,
                              txtDescripcion.Text,
                this.idCelularSeleccionado);
            }
            else
            {
                await repo.AgregarAsync(txtNombre.Text,
                              txtModelo.Text,
                              txtAutor.Text,
                              txtUrlimagen.Text,
                              txtDescripcion.Text);
            }


            this.Close();
        }
        private async void btnCanse_Click(object sender, EventArgs e)
        {
            
            await repo.AgregarAsync(txtNombre.Text,
                              txtModelo.Text,
                              txtAutor.Text,
                              txtUrlimagen.Text,
                              txtDescripcion.Text);
            this.Close();
        }
    }
}
