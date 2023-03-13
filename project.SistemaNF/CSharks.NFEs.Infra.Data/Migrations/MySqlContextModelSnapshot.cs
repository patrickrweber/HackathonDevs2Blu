﻿// <auto-generated />
using System;
using CSharks.NFEs.Infra.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Enrollment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Enterprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6778bf07-517f-4916-989b-15b17b374203"),
                            City = "8453",
                            CpfCnpj = "12345678901234",
                            Email = "csharkenterprise@hotmail.com",
                            Name = "Csharks Developers LTDA"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.NF_UTILS.ISQN", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Aliquot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Isqns");
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("aliquota_item_lista_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_item_lista_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_local_prestacao_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("descritivo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("situacao_tributaria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tributa_municipio_prestador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("valor_tributavel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e7e5c29-e582-465e-a6f8-ea045c94f392"),
                            aliquota_item_lista_servico = "5",
                            codigo_item_lista_servico = "702",
                            codigo_local_prestacao_servico = "8357",
                            descritivo = "Teste",
                            situacao_tributaria = "000",
                            tributa_municipio_prestador = "S",
                            valor_tributavel = "0"
                        },
                        new
                        {
                            Id = new Guid("e0015a6c-f696-4eaf-a098-0cfb99fc320e"),
                            aliquota_item_lista_servico = "2",
                            codigo_item_lista_servico = "0106",
                            codigo_local_prestacao_servico = "8357",
                            descritivo = "Assessoria e consultoria em informática.",
                            situacao_tributaria = "000",
                            tributa_municipio_prestador = "S",
                            valor_tributavel = "0"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.TOM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("EnterpriseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(55)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e6a2479-c86a-4e5e-a46b-82b870fa4cb8"),
                            Email = "teste@hotmail.com",
                            EnterpriseId = new Guid("6778bf07-517f-4916-989b-15b17b374203"),
                            Login = "dev",
                            Name = "Desenvolvedor",
                            Password = "MTIz",
                            Profile = 1
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.User", b =>
                {
                    b.HasOne("CSharks.NFEs.Domain.Models.Enterprise", "Enterprise")
                        .WithMany()
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");
                });
#pragma warning restore 612, 618
        }
    }
}