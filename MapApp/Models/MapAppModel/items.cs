using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapApp.Models.MapAppModel
{
    public class items
    {
        public string title { get; set; }
        public string id { get; set; }
        public string resultType { get; set; }
         
        public address address { get; set; }
        public position position { get; set; }
        public List<access> access { get; set; }
        public List<categories> categories { get; set; }
        public scoring scoring { get; set; }

    }
}
