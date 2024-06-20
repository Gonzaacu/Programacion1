using EjerciciosDePrueba.Models;
using EjerciciosDePrueba.RepositoriesCell;

namespace ProyectoTesteoCelulares
{
    public class TestsCelu
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerCelulares()
        {
            CelularesRepository celularesRepository = new CelularesRepository();
            var celulares = await celularesRepository.ObtenerCelularesAsync();

            Assert.That(celulares.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public async Task TestAgregarCelu()
        {
            CelularesRepository celularesRepository = new CelularesRepository();
            var celulares = await celularesRepository.AgregarAsync("celutest", "autostest", "samsumg", "fewef", "grdgh");
            Assert.That(celulares.nombre, Is.EqualTo("GonzaAA"));
        }
        [Test] 
        public async Task testeliminar()
        {
            CelularesRepository celularesRepository = new CelularesRepository();
            var borrado = await celularesRepository.EliminarAsync("66711d982ab8f67c00007b53");
            Assert.That(borrado, Is.EqualTo(true));
        }
        [Test]
        public async Task testObtener()
        {
            CelularesRepository celularesRepository = new CelularesRepository();
            var celulares = await celularesRepository.ObtenerPorIdAsync("666c66ad2ab8f67c00005cc0");
            Assert.That(celulares.nombre, Is.EqualTo("motorola"));
        }
        [Test]
        public async Task testActualizar()
        {
            CelularesRepository celularesRepository = new CelularesRepository();
            var celulares = await celularesRepository.ActualizarAsync("celuactualizado", "edge 30 ultra", "gon", "gfer", "108Mp", "66711e002ab8f67c00007b56");
            Assert.That(celulares.nombre, Is.EqualTo("celuactualizado"));
        }
    }
}
