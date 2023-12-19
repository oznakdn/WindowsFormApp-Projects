﻿// <auto-generated />
using System;
using CRMapp.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRMapp.DataAccessLayer.Migrations
{
    [DbContext(typeof(CRMappContext))]
    partial class CRMappContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRMapp.Model.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmanAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("CRMapp.Model.Gorusme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int?>("RandevuId")
                        .HasColumnType("int");

                    b.Property<string>("Sonuc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.HasIndex("RandevuId");

                    b.ToTable("Gorusmeler");
                });

            modelBuilder.Entity("CRMapp.Model.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("CRMapp.Model.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<string>("DogumTarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("MedeniDurum")
                        .HasColumnType("bit");

                    b.Property<string>("Meslek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("iletisimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("iletisimId");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("CRMapp.Model.MusteriUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.HasIndex("UrunId");

                    b.ToTable("MusteriUrunler");
                });

            modelBuilder.Entity("CRMapp.Model.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<int?>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("DogumTarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("MedeniDurum")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("iletisimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("iletisimId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("CRMapp.Model.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MusteriId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RandevuTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("CRMapp.Model.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrunKatgoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunKatgoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("CRMapp.Model.UrunKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kategori")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UrunKategoriler");
                });

            modelBuilder.Entity("CRMapp.Model.iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("iletisimler");
                });

            modelBuilder.Entity("CRMapp.Model.Gorusme", b =>
                {
                    b.HasOne("CRMapp.Model.Personel", null)
                        .WithMany("Gorusmeler")
                        .HasForeignKey("PersonelId");

                    b.HasOne("CRMapp.Model.Randevu", "Randevu")
                        .WithMany("Gorusmeler")
                        .HasForeignKey("RandevuId");

                    b.Navigation("Randevu");
                });

            modelBuilder.Entity("CRMapp.Model.Kullanici", b =>
                {
                    b.HasOne("CRMapp.Model.Personel", "Personel")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("PersonelId");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CRMapp.Model.Musteri", b =>
                {
                    b.HasOne("CRMapp.Model.iletisim", "İletisim")
                        .WithMany("Musteriler")
                        .HasForeignKey("iletisimId");

                    b.Navigation("İletisim");
                });

            modelBuilder.Entity("CRMapp.Model.MusteriUrun", b =>
                {
                    b.HasOne("CRMapp.Model.Musteri", "Musteri")
                        .WithMany("MusteriUrunler")
                        .HasForeignKey("MusteriId");

                    b.HasOne("CRMapp.Model.Urun", "Urun")
                        .WithMany("MusteriUrunler")
                        .HasForeignKey("UrunId");

                    b.Navigation("Musteri");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("CRMapp.Model.Personel", b =>
                {
                    b.HasOne("CRMapp.Model.iletisim", "İletisim")
                        .WithMany("Personeller")
                        .HasForeignKey("iletisimId");

                    b.Navigation("İletisim");
                });

            modelBuilder.Entity("CRMapp.Model.Urun", b =>
                {
                    b.HasOne("CRMapp.Model.UrunKategori", "UrunKatgori")
                        .WithMany("Urunler")
                        .HasForeignKey("UrunKatgoriId");

                    b.Navigation("UrunKatgori");
                });

            modelBuilder.Entity("CRMapp.Model.Musteri", b =>
                {
                    b.Navigation("MusteriUrunler");
                });

            modelBuilder.Entity("CRMapp.Model.Personel", b =>
                {
                    b.Navigation("Gorusmeler");

                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("CRMapp.Model.Randevu", b =>
                {
                    b.Navigation("Gorusmeler");
                });

            modelBuilder.Entity("CRMapp.Model.Urun", b =>
                {
                    b.Navigation("MusteriUrunler");
                });

            modelBuilder.Entity("CRMapp.Model.UrunKategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("CRMapp.Model.iletisim", b =>
                {
                    b.Navigation("Musteriler");

                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}