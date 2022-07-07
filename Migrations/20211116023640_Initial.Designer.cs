﻿// <auto-generated />
using DbOutOfNames.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbOutOfNames.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20211116023640_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DbOutOfNames.Models.Person", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("First")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.HasKey("Email");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Email = "CoffeeNotCode@yahoo.com",
                            First = "Sam",
                            Last = "Relational",
                            Password = "R0CKYOu99999999"
                        },
                        new
                        {
                            Email = "3MonsterEnergy@MoreRedbull.com",
                            First = "Jackie",
                            Last = "Nonrelational",
                            Password = "PlainText4ThatWin"
                        },
                        new
                        {
                            Email = "Java>SQL@truestatement.net",
                            First = "Selma",
                            Last = "Crowsfoot",
                            Password = "S3lmaCrowsf00t"
                        },
                        new
                        {
                            Email = "NoMoDb@ThatNastyDB.com",
                            First = "Senor",
                            Last = "Casablanca",
                            Password = ""
                        },
                        new
                        {
                            Email = "ItsBrokenAgain@Shocker.com",
                            First = "Trevor",
                            Last = "Lastelick",
                            Password = "C4ntH4ckM3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
