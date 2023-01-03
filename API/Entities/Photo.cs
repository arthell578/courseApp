using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int IsMain { get; set; }
        public int PublicId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}