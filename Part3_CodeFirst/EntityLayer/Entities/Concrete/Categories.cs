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
    [Table("Categories")]//Bu attribute ile aşağıdaki sınıfın veri tabanı tarafında tablo olarak ayapı kalkarken alacağı ismi belirler.
    public class Categories : BaseEntity<int>
    { 
        //Aşağıda attribute bazında mapping yapıyoruz..
        [Key] // PrimaryKey olarak belirttik.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }

        //Entity Framework bir  property'nin adını "Id" olarak gördüğünde onu ilgili üyeyi "Key&Idendity" olarak işaretler.Bu işlemi otomatik olarak yapar.

        //Dikkat
        //Herhangi bir varlığın database tarafında bir Id'si olmak zorundadır.SQL'den hatırlayın.
        //Burada da herhangi bir varlığı Id vermezsek göç(migration) esnasında ya da göç işleminden sonra yapılacak CRUD operasyonlarında  EF bize kızacaktır,exception fırlatarak uygulamayı durduracaktır.

        [Required] //Reqyired attribute sayesinde veritabınında bu sütunun zorunlu tutulmasını temin ettik.Mapping işlemi..
        public string CategoryName {get; set; }
        [Required]
        [MaxLength(255)]//Maksimum uzunluk
        [MinLength(3,ErrorMessage ="En az üç karakter girer misiniz..")]
        public string Description { get; set; } // string heap alanda tutuluyor , adresleri stack alanda tutuluyor.

        //Dikkat
        //Required vb property üzerine yazdığıımız attribute'ler vasıtasıyla "Mapping" işlem yapıyoruz.Yani veritabanı tarafında tablo olarak oluşacak sınıflarımızdan içerisindeki üyelerin özelliklerini,boş geçilip geçilemeyeceğini tipini vb. özelliklerini belirtiyoruz.
        //Mapping işlemlerini 2 yolla yapabiliriz.Birinci yol attribute bazında bizim bu projede yaptığımız,ikinci yol ise fluentapi'dir.
        //Bir kategory altında bir çok ürün bulunmaktadır.Category veritabanında cağırdığında onunla ilişik olan tüm productlarda gelecektir.Buna bana Lazy Loading temin etti.İlgili satırda dikkat ederseniz gene "virtual" ibaresi bulunmaktadır.
        public virtual List<Products> Product{ get; set; }
    }
}
