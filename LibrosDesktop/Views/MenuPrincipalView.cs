using LibrosDesktop.Views;

namespace LibrosDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GestionLibrosViews gestionLibrosViews = new GestionLibrosViews();
            
            gestionLibrosViews.ShowDialog();

        }

        
    }
}
