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
    public class Order : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public virtual Employees Employee { get; set; }


        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }

        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public int ShipPostalCode { get; set; }
        [Required]
        public string ShipCountry { get; set; }


        [ForeignKey("Shipper")]
        public int ShipperId { get; set; }
        public virtual Shipper Shipper { get; set; }


    }
}
