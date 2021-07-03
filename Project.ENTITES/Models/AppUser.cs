using Microsoft.AspNetCore.Identity;
using Project.ENTITES.CoreInterfaces;
using Project.ENTITES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus? Status { get; set; }
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Article> Articles { get; set; }

    }
}
