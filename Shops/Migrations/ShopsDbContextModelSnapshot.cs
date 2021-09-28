﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shops.Database;

namespace Shops.Migrations
{
    [DbContext(typeof(ShopsDbContext))]
    partial class ShopsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Shops.Database.Models.ItemShopModel", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<decimal?>("BuyPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal?>("SellPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ItemId");

                    b.ToTable("Shops_ItemShops");
                });

            modelBuilder.Entity("Shops.Database.Models.VehicleShopModel", b =>
                {
                    b.Property<string>("VehicleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("VehicleId");

                    b.ToTable("Shops_VehicleShops");
                });
#pragma warning restore 612, 618
        }
    }
}
