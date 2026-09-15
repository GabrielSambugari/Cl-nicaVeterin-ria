using System.Text.Json.Serialization;

namespace ClínicaVeterinária.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; } 

        public int TutorId { get; set; }
        [JsonIgnore]
        public Tutor? Tutor { get; set; }

        public ICollection<Tutor> Tutors { get; set; } = new List<Tutor>();
    }
}
