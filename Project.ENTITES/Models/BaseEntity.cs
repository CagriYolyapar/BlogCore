using Project.ENTITES.CoreInterfaces;
using Project.ENTITES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public abstract class BaseEntity:IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus? Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
