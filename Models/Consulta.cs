using System.Text.Json.Serialization;

namespace ClínicaVeterinária.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public int PetId { get; set; }

        [JsonIgnore]
        public Pet? Pet { get; set; }

        public int VeterinarioID { get; set; }
        [JsonIgnore]

        public Veterinario? Veterinario { get; set; }
    }
}
