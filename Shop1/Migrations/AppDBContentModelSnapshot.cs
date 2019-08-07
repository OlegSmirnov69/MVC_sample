﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop1.Data;

namespace Shop1.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop1.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("DBCategory");
                });

            modelBuilder.Entity("Shop1.Data.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("category_id");

                    b.Property<string>("img");

                    b.Property<bool>("isTop");

                    b.Property<int?>("item_categoryid");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("item_categoryid");

                    b.ToTable("DBItem");
                });

            modelBuilder.Entity("Shop1.Data.Models.Item", b =>
                {
                    b.HasOne("Shop1.Data.Models.Category", "item_category")
                        .WithMany("item_list")
                        .HasForeignKey("item_categoryid");
                });
#pragma warning restore 612, 618
        }
    }
}
