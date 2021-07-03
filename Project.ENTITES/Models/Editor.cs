using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class Editor:BaseEntity,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual List<Article> Articles { get; set; }

    }
}
