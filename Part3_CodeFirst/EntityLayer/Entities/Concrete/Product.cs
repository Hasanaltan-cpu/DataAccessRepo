using Part3_CodeFirst.EntityLayer.Entities.Abstract;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Part3_CodeFirst.EntityLayer.Entities.Concrete
{
    public class Product : BaseEntity<int>
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public override int Id { get; set; }

        [Required, Column(Order = 2)]
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }// I use boolean because discontinued in the database 0 or 1 .

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("Supplier")]
        public int SuppliersId { get; set; }
        public virtual Supplier Supplier { get; set; }




    }
}
