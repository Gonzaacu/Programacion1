using MotorolaDesktop.Views;

namespace MotorolaDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void celularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCelularesView gestionCelularesView = new GestionCelularesView();
            gestionCelularesView.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionCelularesView gestionCelularesView = new GestionCelularesView();
            gestionCelularesView.ShowDialog();
        }
    }
}
