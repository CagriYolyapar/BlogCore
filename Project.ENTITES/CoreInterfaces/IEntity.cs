using Project.ENTITES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.CoreInterfaces
{
    public interface IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus? Status { get; set; }

    }
}