using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class ArticleTag:BaseEntity,IEntity
    {
        public int TagID { get; set; }
        public int ArticleID { get; set; }

        //Relational Properties

        public virtual Tag Tag { get; set; }
        public virtual Article Article { get; set; }


    }
}
