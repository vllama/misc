using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp.Model
{
    class Child
    {
        public int Id { get; set; }
        public string Field { get; set; }

        public int IdParent { get; set; }
       
        public Parent Parent { get; set; }

        public int IdIntermediate { get; set; }
        public Intermediate Intermediate { get; set; }
        public int IdSelfChild { get; set; }

        //exagerate references between Entities
        public Child Self { get; set; }
        public Child Self1 { get; set; }
        public Child Self2 { get; set; }
        public Child Self3 { get; set; }
        public Child Self4 { get; set; }
        public Child Self5 { get; set; }
        public Child Self6 { get; set; }
        public Child Self7 { get; set; }
        public Child Self8 { get; set; }
        public Child Self9 { get; set; }
        public Child Self11 { get; set; }
        public Child Self12 { get; set; }
        public Child Self13 { get; set; }
        public Child Self14 { get; set; }
        public Child Self15 { get; set; }
        public Child Self16 { get; set; }
        public Child Self17 { get; set; }
        public Child Self18 { get; set; }
        public Child Self19 { get; set; }
        public Child Self21 { get; set; }
        public Child Self22 { get; set; }
        public Child Self23 { get; set; }
        public Child Self24 { get; set; }
        public Child Self25 { get; set; }
        public Child Self26 { get; set; }
        public Child Self27 { get; set; }
        public Child Self28 { get; set; }
        public Child Self29 { get; set; }
        public Child Self31 { get; set; }
        public Child Self32 { get; set; }
        public Child Self33 { get; set; }
        public Child Self34 { get; set; }
        public Child Self35 { get; set; }
        public Child Self36 { get; set; }
        public Child Self37 { get; set; }
        public Child Self38 { get; set; }
        public Child Self39 { get; set; }
        public List<Child> SelfParents { get; set; }
    }
}
