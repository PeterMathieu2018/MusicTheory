// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MusicTheory.Data.Music
{

    // Chord
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class ChordConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Chord>
    {
        public ChordConfiguration()
            : this("dbo")
        {
        }

        public ChordConfiguration(string schema)
        {
            ToTable("Chord", schema);
            HasKey(x => x.ChordId);

            Property(x => x.ChordId).HasColumnName(@"ChordId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ChordName).HasColumnName(@"ChordName").HasColumnType("nvarchar(max)").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>