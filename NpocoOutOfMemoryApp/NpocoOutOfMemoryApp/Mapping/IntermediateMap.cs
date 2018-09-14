using NPoco.FluentMappings;
using NpocoOutOfMemoryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp.Mapping
{
    class IntermediateMap : Map<Intermediate>
    {
        public IntermediateMap() : base() {
            PrimaryKey(x => x.Id);
            TableName($"Intermediate");
            Columns(x => {
                x.Column(y => y.IdParent).WithName("IdParent");
                x.Column(y => y.Child).WithName("IdParent").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.OtherChild).WithName("IdParent").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);

                x.Column(y => y.Parent).WithName("IdParent").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
            });
        }
    }
}
