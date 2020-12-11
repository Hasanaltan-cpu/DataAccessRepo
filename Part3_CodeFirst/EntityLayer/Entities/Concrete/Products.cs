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
        //Order attribute'si sayesinde name property'sinin tablo içerisinde ikinci sütun olarak yaratılacağını belirttik.
        public string Name { get; set; }
        //Relation Database gereği bir product'ın muhakkak bir category'si olmak zorundadır.
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //Yukarıda EF teknolojilerinden Lazy Loading'i aktif hale getirmek için virtual olarak işaretledik.Ayrıca başka bir alternatif olarak Eager Loading ' de tercih edilebilir.Tüm bu yaklaşımları projede duyulan ihtiyaclara göre seçmeliyiz.

       
    }
}
