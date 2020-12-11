using Part3_CodeFirst.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_CodeFirst.EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity<T>//In this class signed as a abstract because i will use this class after creating concrete classes.In addition to that <T> is type generator.It means you should write <int,string ..> before writing the body.It can be also generic type.
    {

        public  abstract T Id { get; set; } // Now It is rule for the child classes which inherited from this class.
        
        
        private DateTime _createDate = DateTime.Now; //This is Encapsulation as we known before.Protect our value that name is CreateDate by using get,set methods.But here we don't need to use set method because it automatically takes from Datetime and set.
        public DateTime CreateDate { get=>_createDate; }


        public DateTime? ModifiedDate { get; set; }
        //Datetime?=Nullable DateTime=> it means it can be null because as true logic when u create a data it doesn't have modified date at the same time.Now we can skip ModifiedDate & PassivedDate null.
        public DateTime? PassivedDate { get; set; }

        private Status _status = Status.Active;//We took this from Enums class.
        public Status Status { get=>_status; set => _status=value; }

    }
}
