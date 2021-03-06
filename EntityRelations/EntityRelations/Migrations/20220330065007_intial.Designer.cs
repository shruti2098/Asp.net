// <auto-generated />
using EntityRelations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityRelations.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220330065007_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityRelations.Model.ModelInfo", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.ToTable("ModelInfo");
                });

            modelBuilder.Entity("EntityRelations.Model.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EntityRelations.Model.ProductDescription", b =>
                {
                    b.Property<int>("ProductDesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductDetails")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductDesId");

                    b.ToTable("ProductDes");
                });

            modelBuilder.Entity("ModelInfoProduct", b =>
                {
                    b.Property<int>("ModelInfosModelId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProdId")
                        .HasColumnType("int");

                    b.HasKey("ModelInfosModelId", "ProductsProdId");

                    b.HasIndex("ProductsProdId");

                    b.ToTable("ModelInfoProduct");
                });

            modelBuilder.Entity("ModelInfoProduct", b =>
                {
                    b.HasOne("EntityRelations.Model.ModelInfo", null)
                        .WithMany()
                        .HasForeignKey("ModelInfosModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityRelations.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
