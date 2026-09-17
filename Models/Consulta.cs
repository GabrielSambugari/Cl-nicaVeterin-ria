using System.Text.Json.Serialization;

namespace ClínicaVeterinária.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHora{ get; set; }

        public int PetId { get; set; }

        [JsonIgnore]
        public Pet? Pet { get; set; }

        public int VeterinarioID { get; set; }
        [JsonIgnore]

        public Veterinario? Veterinario { get; set; }
    }
}
