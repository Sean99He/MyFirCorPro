using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyFirCorPro.Web;
using MyFirCorPro.Base;

namespace MyFirCorPro.Web.Migrations
{
    [DbContext(typeof(MyFirCorProDbContext))]
    [Migration("20170412013929_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirCorPro.Base.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Type");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryGeneral", b =>
                {
                    b.Property<int>("GeneralId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("ContentOrder")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ContentView")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("View")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("GeneralId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("CategoryGeneral");
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryLink", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("LinkId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("CategoryLink");
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryPage", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(10000);

                    b.Property<string>("View")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("PageId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("CategoryPage");
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryGeneral", b =>
                {
                    b.HasOne("MyFirCorPro.Base.Category", "Category")
                        .WithOne("CategoryGeneral")
                        .HasForeignKey("MyFirCorPro.Base.CategoryGeneral", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryLink", b =>
                {
                    b.HasOne("MyFirCorPro.Base.Category")
                        .WithOne("CategoryLink")
                        .HasForeignKey("MyFirCorPro.Base.CategoryLink", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyFirCorPro.Base.CategoryPage", b =>
                {
                    b.HasOne("MyFirCorPro.Base.Category", "Category")
                        .WithOne("CategoryPage")
                        .HasForeignKey("MyFirCorPro.Base.CategoryPage", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
