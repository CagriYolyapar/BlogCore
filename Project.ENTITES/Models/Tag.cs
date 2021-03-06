using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITES.Models
{
    public class Tag:BaseEntity,IEntity
    {
        public string TagName { get; set; }

        //Relational Properties
        public virtual List<ArticleTag> ArticleTags { get; set; }

    }
}
