using System.ComponentModel.DataAnnotations;

namespace WebBaoDoi.Models
{
    public class Faculties
    {
        internal object id;

        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
