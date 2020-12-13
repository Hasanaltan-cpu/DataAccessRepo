using Part4_YellowPages_1.EntityLayer.Entities.Enums;
using Part4_YellowPages_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4_YellowPages_1.EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        private DateTime _createDate = DateTime.Now;//Encapsulation
        public DateTime CreateDate { get => _createDate; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassivedDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
