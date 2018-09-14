using NPoco.FluentMappings;
using NpocoOutOfMemoryApp.Model;


namespace NpocoOutOfMemoryApp.Mapping
{
    class ChildMap : Map<Child>
    {
        public ChildMap() : base()
        {

            PrimaryKey(x => x.Id);
            TableName($"Child");
            Columns(x =>
            {
                x.Column(y => y.Field).WithName("Id");
                x.Column(y => y.IdParent).WithName("IdParent");
                x.Column(y => y.IdParent).WithName("IdIntermediate");
                x.Column(y => y.Parent).WithName("IdParent").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Intermediate).WithName("IdIntermediate").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);

                x.Column(y => y.Self).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self1).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self2).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self3).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self4).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self5).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self6).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self7).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self8).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self9).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self11).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self12).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self13).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self14).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self15).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self16).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self17).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self18).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self19).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self21).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self22).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self23).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self24).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self25).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self26).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self27).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self28).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self29).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self31).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self32).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self33).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self34).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self35).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self36).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self37).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self38).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);
                x.Column(y => y.Self39).WithName("IdSelfChild").Reference(z => z.Id, NPoco.ReferenceType.OneToOne);

                x.Many(y => y.SelfParents).WithName("id").Reference(z => z.IdSelfChild);
            });
        }
    }
}