using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class Category:BaseEntity,IEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<Article> Articles { get; set; }
    }
}
