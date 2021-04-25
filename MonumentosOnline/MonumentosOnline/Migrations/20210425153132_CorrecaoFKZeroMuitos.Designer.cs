﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonumentosOnline.Data;

namespace MonumentosOnline.Migrations
{
    [DbContext(typeof(Monumentos_OnlineDB))]
    [Migration("20210425153132_CorrecaoFKZeroMuitos")]
    partial class CorrecaoFKZeroMuitos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MonumentosOnline.Models.CaractMonumentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaracteristicaFK")
                        .HasColumnType("int");

                    b.Property<int>("MonumentoFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaracteristicaFK");

                    b.HasIndex("MonumentoFK");

                    b.ToTable("CaractMonumentos");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Caracteristicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassPatrimonial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estilo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Imagens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataImagem")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Legenda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonumentoFK")
                        .HasColumnType("int");

                    b.Property<string>("NomeImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UtilizadorFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonumentoFK");

                    b.HasIndex("UtilizadorFK");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Monumentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtitetoConstrutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodSIPA")
                        .HasColumnType("int");

                    b.Property<string>("CoordLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoordLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EpocaConstrucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UtilizadorFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilizadorFK");

                    b.ToTable("Monumentos");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Utilizadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalidadeUtilizador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizadores");
                });

            modelBuilder.Entity("MonumentosOnline.Models.CaractMonumentos", b =>
                {
                    b.HasOne("MonumentosOnline.Models.Caracteristicas", "Caracteristica")
                        .WithMany("ListaMonumentos")
                        .HasForeignKey("CaracteristicaFK");

                    b.HasOne("MonumentosOnline.Models.Monumentos", "Monumento")
                        .WithMany("ListaCaracteristicas")
                        .HasForeignKey("MonumentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caracteristica");

                    b.Navigation("Monumento");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Imagens", b =>
                {
                    b.HasOne("MonumentosOnline.Models.Monumentos", "Monumento")
                        .WithMany("ListaImagens")
                        .HasForeignKey("MonumentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentosOnline.Models.Utilizadores", "Utilizador")
                        .WithMany("ListaImagens")
                        .HasForeignKey("UtilizadorFK");

                    b.Navigation("Monumento");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Monumentos", b =>
                {
                    b.HasOne("MonumentosOnline.Models.Utilizadores", "Utilizador")
                        .WithMany("ListaMonumentos")
                        .HasForeignKey("UtilizadorFK");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Caracteristicas", b =>
                {
                    b.Navigation("ListaMonumentos");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Monumentos", b =>
                {
                    b.Navigation("ListaCaracteristicas");

                    b.Navigation("ListaImagens");
                });

            modelBuilder.Entity("MonumentosOnline.Models.Utilizadores", b =>
                {
                    b.Navigation("ListaImagens");

                    b.Navigation("ListaMonumentos");
                });
#pragma warning restore 612, 618
        }
    }
}
