﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cheeseria.Server.DataRepositories;

#nullable disable

namespace cheeseria.Server.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CheeseApp.Server.Cheese", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PricePerKilo")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Cheeses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Colour = "Light Yellow",
                            Name = "Cheddar",
                            PricePerKilo = 1f
                        },
                        new
                        {
                            Id = 2,
                            Colour = "White",
                            Name = "Feta",
                            PricePerKilo = 1f
                        },
                        new
                        {
                            Id = 3,
                            Colour = "White with Blue Pigment",
                            Name = "Gorgonzola",
                            PricePerKilo = 1f
                        },
                        new
                        {
                            Id = 4,
                            Colour = "Light Yellow",
                            Name = "Gouda",
                            PricePerKilo = 1f
                        },
                        new
                        {
                            Id = 5,
                            Colour = "White",
                            Name = "Aarenwasser",
                            PricePerKilo = 8f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}