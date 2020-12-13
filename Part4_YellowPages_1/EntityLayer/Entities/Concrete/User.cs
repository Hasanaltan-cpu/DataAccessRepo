using Part4_YellowPages_1.EntityLayer.Entities.Abstract;
using Part4_YellowPages_1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part4_YellowPages_1.EntityLayer.Entities.Concrete
{
    [Table("UserList")]
    public class User : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Note { get; set; }

        
    }
}

