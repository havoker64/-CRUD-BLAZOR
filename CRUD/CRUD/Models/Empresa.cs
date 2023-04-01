using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Empresa
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(100)]
        public string nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string site { get; set; }

        [Required]
        [MaxLength(100)]
        public string seguimento { get; set; }

        public void generateNewId()
        {
            id = Guid.NewGuid();
        }
    }
}