using Part3_CodeFirst.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_CodeFirst.EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity<T> //Burada abstract olarak işaretlenmiş BaseEntity.cs sınıfımın kalıtım verdiği yerde bir tipe bürüneceğini ama bu tipin belli olmadığını belirttim.Her alt sınıfta ihtiyaçlarım doğrultusunda farklı tipler verebileceğim.İleride alacağı tip C#'ta hiyerarşik olarak bulunan bir tip(int,string vs) olabileceği gibi generic bir tipte olabilir.
    {

        public  abstract T Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get=>_createDate; }
        public DateTime? ModifiedDate { get; set; }//Buradaki soru işareti ilgili property'nin database tarafında null geçilebilmesi için yapıldı.Datetime value type olduğu için RAM'in stack mantığından dolayı boş geçilemezdi.Lakin burada benim ihtiyacım olan şey şudur: Bir entity create edildiğinde ilgili entity'nin yaratılma esnasında Modified ve Passive Datelerinin olamayacağından ve yaratılma anında bunların boş geçilmesi gerektiğinden burada nullable DateTime oluşturuldu.
        public DateTime? PassivedDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get=>_status; set => _status=value; }

    }
}
