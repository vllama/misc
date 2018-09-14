using NPoco.FluentMappings;
using NpocoOutOfMemoryApp.Model;


namespace NpocoOutOfMemoryApp.Mapping
{
    class ParentMap : Map<Parent>
    {
        public ParentMap() : base()
        {
            PrimaryKey(x => x.Id);
            TableName($"Parent");
            Columns(x =>
            {
                x.Column(y => y.Field);
                x.Column(y => y.IdParentParent).WithName("IdParentParent");
                x.Many(y => y.Children).WithName("id").Reference(z => z.IdParent);
                x.Many(y => y.Intermediate).WithName("id").Reference(z => z.IdParent);
                x.Many(y => y.ParentParent).WithName("id").Reference(z => z.IdParentParent);
            });
        }
    }
}
