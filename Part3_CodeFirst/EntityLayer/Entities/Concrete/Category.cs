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
    [Table("Categories")]
    public class Category : BaseEntity<int>
    { 
        //This is attribute and we should give IdentityKey of Category.cs.
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }

        [Required] 
        public string CategoryName {get; set; }
        [Required]
        
        public string Description { get; set; } 
        public virtual List<Product> Product{ get; set; }
    }
}
