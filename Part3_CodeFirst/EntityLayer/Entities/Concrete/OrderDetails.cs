using Part3_CodeFirst.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_CodeFirst.EntityLayer.Entities.Concrete
{
    public class OrderDetails : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set; }

        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public int OrderId { get; set; }
        public virtual Orders Order { get; set; }

        public int ProductID { get; set; }
        public virtual Products Products { get; set; }
    }
}
