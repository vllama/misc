using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp.Model
{
    class Parent
    {
        public int Id { get; set; }
        public string Field { get; set; }
        public int IdParentParent{ get; set; }
        public List<Child> Children { get; set; }
        public List<Intermediate> Intermediate { get; set; }

        public List<Parent> ParentParent { get; set; }
    }
}
