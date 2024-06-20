using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()
        {
            LibroRepository libroRepository = new LibroRepository();
            var libros =  await libroRepository.ObtenerLibrosAsync();
            
            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public async Task TestAgregarLibro()
        {
            LibroRepository libroRepository = new LibroRepository();
            var libro = await libroRepository.AgregarAsync("LibroTest", 213, "Editorialtest", "portadaTest", "sinopsisTest", "nfjkab", "generoTest");
            Assert.That(libro.nombre, Is.EqualTo("LibroTest"));
        }
        [Test]
        public async Task TestEliminarLibro()
        {
            LibroRepository libroRepository = new LibroRepository();
            var borrado = await libroRepository.EliminarAsync("665f457f69e958000004427c");
            Assert.That(borrado, Is.EqualTo(true));
        }

        [Test]
        public async Task TestObtenerLibro()
        {
            LibroRepository libroRepository = new LibroRepository();
            var libro = await libroRepository.ObtenerPorIdAsync("64e6532ea1ce3020000d23f7");
            Assert.That(libro.nombre, Is.EqualTo("Tao Te King"));
        }

        [Test]
        public async Task TestActualizarLibro()
        {
            LibroRepository libroRepository = new LibroRepository();
            var libro = await libroRepository.ActualizarAsync( "TestAgregar", 900, "Test", "Test123", "https://http2.mlstatic.com/D_NQ_NP_692542-MLA46483098859_062021-O.webp", "Holaaaaaaaa", "Programador", "64ef9161e53ccf6f00008a4a");
            Assert.That(libro.nombre, Is.EqualTo("TestAgregar"));
        }
    }
}