using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Equipo
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string? Descripcion { get; set; }
        
        [DisplayName("Descripcion Larga")]
        public string? DescripcionLarga { get; set; }
        public string? Ram { get; set; }
        public string? Procesador { get; set; }
        public string? DiscoDuroHDD { get; set; }
        public string? DiscoDuroSSD { get; set; }
        public bool GPUIntegrada { get; set; }
        public bool GPUDedicada { get; set; }
        public string? GPUDedicadaName { get; set; }
       
        public string? HzPantalla { get; set; }
        
        [DisplayName("Pulgadas Pantalla")]
        public string? InPantalla { get; set; }
        public string? ImagenUrl { get; set; }

        [NotMapped]
        public IFormFile? ImagenFile { get; set; }

        //Foreign Keys
        public int MarcaId { get; set; }
        public Marca? Marca { get; set; }

        public int LineaId { get; set; }
        public Linea? Linea { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
