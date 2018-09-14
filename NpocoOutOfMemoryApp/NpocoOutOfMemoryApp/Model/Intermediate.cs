using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp.Model
{
    class Intermediate
    {
        public int Id { get; set; }
        public int IdParent { get; set; }
        public int IdChild { get; set; }
        public Parent Parent { get; set; }
        public Child Child { get; set; }
        public OtherChild OtherChild { get; set; }
    }
}
