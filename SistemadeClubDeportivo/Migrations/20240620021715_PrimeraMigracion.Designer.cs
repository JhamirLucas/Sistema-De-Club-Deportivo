﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemadeClubDeportivo.Contexto;

#nullable disable

namespace SistemadeClubDeportivo.Migrations
{
    [DbContext(typeof(MyContexto))]
    [Migration("20240620021715_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CI")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaDeRegistro")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("IDPersonal")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MontoDeRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NroCelular")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonalID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Horario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonalID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Pago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Anio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NroRecibo")
                        .HasColumnType("date");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Personal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CI")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("FechaDeNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("NroCel")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Cliente", b =>
                {
                    b.HasOne("SistemadeClubDeportivo.Models.Personal", "Personal")
                        .WithMany("Clientes")
                        .HasForeignKey("PersonalID");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Horario", b =>
                {
                    b.HasOne("SistemadeClubDeportivo.Models.Cliente", "Cliente")
                        .WithMany("Horarios")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemadeClubDeportivo.Models.Personal", "Personal")
                        .WithMany("Horarios")
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Pago", b =>
                {
                    b.HasOne("SistemadeClubDeportivo.Models.Cliente", "Cliente")
                        .WithMany("Pagos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemadeClubDeportivo.Models.Usuario", "Usuario")
                        .WithMany("Pagos")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Cliente", b =>
                {
                    b.Navigation("Horarios");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Personal", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("SistemadeClubDeportivo.Models.Usuario", b =>
                {
                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
