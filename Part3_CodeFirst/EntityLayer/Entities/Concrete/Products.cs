using Part3_CodeFirst.EntityLayer.Entities.Abstract;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Part3_CodeFirst.EntityLayer.Entities.Concrete
{
    public class Products : BaseEntity<int>
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public override int Id { get; set; }

        [Required, Column(Order = 2, TypeName = "nvarchar")]
       
        public string ProductName { get; set; }
        [ForeignKey("Suppliers")]
        public int SupplierId { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }// Becase discontinued in the database 0 or 1 .

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }




    }
}
