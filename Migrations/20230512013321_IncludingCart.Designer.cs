﻿// <auto-generated />
using System;
using EasyShop.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyShop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230512013321_IncludingCart")]
    partial class IncludingCart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EasyShop.Model.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdmEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("AdmFirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("AdmLastName")
                        .HasColumnType("longtext");

                    b.Property<string>("AdmPassword")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("EasyShop.Model.BillingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BillingInfo");
                });

            modelBuilder.Entity("EasyShop.Model.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("double");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("EasyShop.Model.Category", b =>
                {
                    b.Property<int>("Cat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cat_Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Cat_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Cat_Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EasyShop.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ContactName")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonalInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("CustomerId");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EasyShop.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BillingInfoId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("Freight")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("PersonalInfoId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("OrderId");

                    b.HasIndex("BillingInfoId");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EasyShop.Model.PersonalInfo", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("ResidenceHouse")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.HasKey("PersonalId");

                    b.ToTable("PersonalInfo");
                });

            modelBuilder.Entity("EasyShop.Model.Product", b =>
                {
                    b.Property<int>("Prod_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cat_Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryCat_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Prod_Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Prod_Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Prod_Material")
                        .HasColumnType("longtext");

                    b.Property<string>("Prod_Name")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Prod_PricePerUnity")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Prod_PriceWithDiscount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Prod_Size")
                        .HasColumnType("longtext");

                    b.Property<int>("Prod_Stock")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Unit_ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("Prod_UnitsOnOrder")
                        .HasColumnType("int");

                    b.Property<int>("Supp_Id")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierSupp_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Prod_Id");

                    b.HasIndex("CategoryCat_Id");

                    b.HasIndex("SupplierSupp_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EasyShop.Model.Subcategory", b =>
                {
                    b.Property<int>("Subcat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Subcat_Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Subcat_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Subcat_Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory");
                });

            modelBuilder.Entity("EasyShop.Model.Supplier", b =>
                {
                    b.Property<int>("Supp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactFirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactLastFName")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("longtext");

                    b.Property<int>("PersonalInfoId")
                        .HasColumnType("int");

                    b.HasKey("Supp_Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("EasyShop.Model.Cart", b =>
                {
                    b.HasOne("EasyShop.Model.Customer", "Cusomer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyShop.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyShop.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cusomer");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EasyShop.Model.Customer", b =>
                {
                    b.HasOne("EasyShop.Model.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("EasyShop.Model.Order", b =>
                {
                    b.HasOne("EasyShop.Model.BillingInfo", "BillingInfo")
                        .WithMany()
                        .HasForeignKey("BillingInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyShop.Model.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingInfo");

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("EasyShop.Model.Product", b =>
                {
                    b.HasOne("EasyShop.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryCat_Id");

                    b.HasOne("EasyShop.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierSupp_Id");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EasyShop.Model.Subcategory", b =>
                {
                    b.HasOne("EasyShop.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EasyShop.Model.Supplier", b =>
                {
                    b.HasOne("EasyShop.Model.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("EasyShop.Model.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
