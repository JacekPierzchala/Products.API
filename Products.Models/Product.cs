using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product:BaseModel
    {
     
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string ProductCode { get; set; }
        public Guid CategoryId { get; set; }

       
        public Category? Category { get; set; }

    }
}
