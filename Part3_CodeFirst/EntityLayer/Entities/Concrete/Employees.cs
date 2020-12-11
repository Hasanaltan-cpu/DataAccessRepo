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
    public class Employees : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required, Column(Order = 2)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required, Column(Order = 3)]
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        [Required]
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        [Required, Column(Order = 4)]
        public string ReportsTo { get; set; }
    }
}
