using WebApp.Models;

namespace WebApp.ViewModels
{
    public class EquipoIndexViewModel
    {
        public List<Equipo>? Equipos;

        public string? PalabraClave { get; set; }
        public int? MarcaId { get; set; }
        public int? LineaId { get; set; }
        public int? CategoriaId { get; set; }


    }
}
