using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp.Model
{
    class OtherChild
    {
        public int Id { get; set; }
        public string Field { get; set; }

        public int IdParent { get; set; }
       
        public Parent Parent { get; set; }

        public int IdIntermediate { get; set; }
        public Intermediate Intermediate { get; set; }
        public int IdSelfChild { get; set; }

        //exagerate references between Entities
        public OtherChild Self { get; set; }
        public OtherChild Self1 { get; set; }
        public OtherChild Self2 { get; set; }
        public OtherChild Self3 { get; set; }
        public OtherChild Self4 { get; set; }
        public OtherChild Self5 { get; set; }
        public OtherChild Self6 { get; set; }
        public OtherChild Self7 { get; set; }
        public OtherChild Self8 { get; set; }
        public OtherChild Self9 { get; set; }
        public OtherChild Self11 { get; set; }
        public OtherChild Self12 { get; set; }
        public OtherChild Self13 { get; set; }
        public OtherChild Self14 { get; set; }
        public OtherChild Self15 { get; set; }
        public OtherChild Self16 { get; set; }
        public OtherChild Self17 { get; set; }
        public OtherChild Self18 { get; set; }
        public OtherChild Self19 { get; set; }
        public OtherChild Self21 { get; set; }
        public OtherChild Self22 { get; set; }
        public OtherChild Self23 { get; set; }
        public OtherChild Self24 { get; set; }
        public OtherChild Self25 { get; set; }
        public OtherChild Self26 { get; set; }
        public OtherChild Self27 { get; set; }
        public OtherChild Self28 { get; set; }
        public OtherChild Self29 { get; set; }
        public OtherChild Self31 { get; set; }
        public OtherChild Self32 { get; set; }
        public OtherChild Self33 { get; set; }
        public OtherChild Self34 { get; set; }
        public OtherChild Self35 { get; set; }
        public OtherChild Self36 { get; set; }
        public OtherChild Self37 { get; set; }
        public OtherChild Self38 { get; set; }
        public OtherChild Self39 { get; set; }
        public List<Child> SelfParents { get; set; }
    }
}
