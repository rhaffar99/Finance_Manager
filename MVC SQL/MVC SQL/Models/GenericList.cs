using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    public class GenericList<T>
    {
        public List<T> objectList { get; set; }

        public GenericList(List<T> list)
        {
            objectList = list;
        }
    }
}
