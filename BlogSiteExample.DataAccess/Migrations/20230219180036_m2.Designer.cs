﻿// <auto-generated />
using System;
using BlogSiteExample.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogSiteExample.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230219180036_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AboutDesciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BlogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.BlogRating", b =>
                {
                    b.Property<int>("BlogRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("BlogScoreCount")
                        .HasColumnType("int");

                    b.Property<int>("BlogTotalScore")
                        .HasColumnType("int");

                    b.HasKey("BlogRatingId");

                    b.ToTable("BlogsRatings");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("BlogScore")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Reciever")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SenderRecieverWriterId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderUserWriterId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("SenderRecieverWriterId");

                    b.HasIndex("SenderUserWriterId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Message2", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Reciever")
                        .HasColumnType("int");

                    b.Property<int>("Sender")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("Reciever");

                    b.HasIndex("Sender");

                    b.ToTable("Message2s");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Newsletter", b =>
                {
                    b.Property<int>("NewsletterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NewsletterMail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsletterId");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("WriterImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterNickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WriterId");

                    b.HasIndex("GenderId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Blog", b =>
                {
                    b.HasOne("BlogSiteExample.Entity.Entities.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogSiteExample.Entity.Entities.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Comment", b =>
                {
                    b.HasOne("BlogSiteExample.Entity.Entities.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Message", b =>
                {
                    b.HasOne("BlogSiteExample.Entity.Entities.Writer", "SenderReciever")
                        .WithMany()
                        .HasForeignKey("SenderRecieverWriterId");

                    b.HasOne("BlogSiteExample.Entity.Entities.Writer", "SenderUser")
                        .WithMany()
                        .HasForeignKey("SenderUserWriterId");

                    b.Navigation("SenderReciever");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Message2", b =>
                {
                    b.HasOne("BlogSiteExample.Entity.Entities.Writer", "RecieverID")
                        .WithMany("RecieverMessager")
                        .HasForeignKey("Reciever")
                        .IsRequired();

                    b.HasOne("BlogSiteExample.Entity.Entities.Writer", "SenderUserID")
                        .WithMany("SenderMessages")
                        .HasForeignKey("Sender")
                        .IsRequired();

                    b.Navigation("RecieverID");

                    b.Navigation("SenderUserID");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Writer", b =>
                {
                    b.HasOne("BlogSiteExample.Entity.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BlogSiteExample.Entity.Entities.Writer", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("RecieverMessager");

                    b.Navigation("SenderMessages");
                });
#pragma warning restore 612, 618
        }
    }
}