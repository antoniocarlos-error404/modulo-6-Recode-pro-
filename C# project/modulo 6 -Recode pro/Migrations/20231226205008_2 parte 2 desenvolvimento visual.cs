﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modulo_6.Context;

#nullable disable

namespace Modulo_6.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20231226205008_segundo")]
    partial class segundo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Modulo_6.Models.Cliente", b =>
                {
                    b.Property<long>("CPF")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("CPF");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Modulo_6.Models.Pacote", b =>
                {
                    b.Property<int>("PacoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Destinoind")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("ValorDiaria")
                        .HasColumnType("float(10,2)");

                    b.HasKey("PacoteId");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("Modulo_6.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("ClienteCPF")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DiariasPedido")
                        .HasColumnType("int");

                    b.Property<int>("PacoteId")
                        .HasColumnType("int");

                    b.Property<float>("ValorPedido")
                        .HasColumnType("float(10,2)");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteCPF");

                    b.HasIndex("PacoteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Modulo_6.Models.Pedido", b =>
                {
                    b.HasOne("Modulo_6.Models.Clienteacao", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteCPF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modulo_6.Models.Pacote", "Pacote")
                        .WithMany("Pedidosacao")
                        .HasForeignKey("PacoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Pacoteacao");
                });

            modelBuilder.Entity("Modulo_6.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Modulo_6.Models.Pacote", b =>
                {
                    b.Navigation("Pedidosacao");
                });
#pragma warning restore 612, 618
        }
    }
}