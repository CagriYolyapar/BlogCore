using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class Article:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AppUserID { get; set; }
        public int? CategoryID { get; set; }
        public int? EditorID { get; set; }


        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ArticleTag> ArticleTags { get; set; }
        public virtual Editor Editor { get; set; }





    }
}
