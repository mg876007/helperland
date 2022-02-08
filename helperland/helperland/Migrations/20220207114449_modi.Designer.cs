﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using helperland.Models;

#nullable disable

namespace helperland.Migrations
{
    [DbContext(typeof(HelperlandContext))]
    [Migration("20220207114449_modi")]
    partial class modi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("helperland.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("helperland.Models.ContactU", b =>
                {
                    b.Property<int>("ContactUsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactUsId"), 1L, 1);

                    b.Property<int?>("AssignedToUser")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UploadFileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactUsId");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("helperland.Models.ContactUsAttachment", b =>
                {
                    b.Property<int>("ContactUsAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactUsAttachmentId"), 1L, 1);

                    b.Property<byte[]>("FileName")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactUsAttachmentId");

                    b.ToTable("ContactUsAttachment", (string)null);
                });

            modelBuilder.Entity("helperland.Models.FavoriteAndBlocked", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TargetUserId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteAndBlocked", (string)null);
                });

            modelBuilder.Entity("helperland.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<decimal>("Friendly")
                        .HasColumnType("decimal(2,1)");

                    b.Property<bool?>("IsApproved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("OnTimeArrival")
                        .HasColumnType("decimal(2,1)");

                    b.Property<decimal>("QualityOfService")
                        .HasColumnType("decimal(2,1)");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime");

                    b.Property<int>("RatingFrom")
                        .HasColumnType("int");

                    b.Property<int>("RatingTo")
                        .HasColumnType("int");

                    b.Property<decimal>("Ratings")
                        .HasColumnType("decimal(2,1)");

                    b.Property<int>("ServiceRequestId")
                        .HasColumnType("int");

                    b.Property<bool>("VisibleOnHomeScreen")
                        .HasColumnType("bit");

                    b.HasKey("RatingId");

                    b.HasIndex("RatingFrom");

                    b.HasIndex("RatingTo");

                    b.HasIndex("ServiceRequestId");

                    b.ToTable("Rating", (string)null);
                });

            modelBuilder.Entity("helperland.Models.ServiceRequest", b =>
                {
                    b.Property<int>("ServiceRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceRequestId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double?>("ExtraHours")
                        .HasColumnType("float");

                    b.Property<bool?>("HasIssue")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPets")
                        .HasColumnType("bit");

                    b.Property<byte?>("JobStatus")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<bool?>("PaymentDone")
                        .HasColumnType("bit");

                    b.Property<bool>("PaymentDue")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentTransactionRefNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("RecordVersion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("RefundedAmount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<byte?>("ServiceFrequency")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("ServiceHourlyRate")
                        .HasColumnType("decimal(8,2)");

                    b.Property<double>("ServiceHours")
                        .HasColumnType("float");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceProviderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceStartDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("SpacceptedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("SPAcceptedDate");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ServiceRequestId");

                    b.HasIndex("ServiceProviderId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceRequest", (string)null);
                });

            modelBuilder.Entity("helperland.Models.ServiceRequestAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ServiceRequestId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.HasIndex("ServiceRequestId");

                    b.ToTable("ServiceRequestAddress", (string)null);
                });

            modelBuilder.Entity("helperland.Models.ServiceRequestExtra", b =>
                {
                    b.Property<int>("ServiceRequestExtraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceRequestExtraId"), 1L, 1);

                    b.Property<int>("ServiceExtraId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceRequestId")
                        .HasColumnType("int");

                    b.HasKey("ServiceRequestExtraId");

                    b.HasIndex("ServiceRequestId");

                    b.ToTable("ServiceRequestExtra", (string)null);
                });

            modelBuilder.Entity("helperland.Models.ServiceSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastPoll")
                        .HasColumnType("datetime");

                    b.Property<TimeSpan>("ScheduleTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("ServiceSetting", (string)null);
                });

            modelBuilder.Entity("helperland.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("helperland.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("BankTokenId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegisteredUser")
                        .HasColumnType("bit");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PaymentGatewayUserRef")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ResetKey")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TaxNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserProfilePicture")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("WebSite")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("WorksWithPets")
                        .HasColumnType("bit");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("helperland.Models.UserAddress", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddressId")
                        .HasName("PK_UserAddresses");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddress", (string)null);
                });

            modelBuilder.Entity("helperland.Models.Zipcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ZipcodeValue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Zipcode", (string)null);
                });

            modelBuilder.Entity("helperland.Models.City", b =>
                {
                    b.HasOne("helperland.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .IsRequired()
                        .HasConstraintName("FK_City_State");

                    b.Navigation("State");
                });

            modelBuilder.Entity("helperland.Models.FavoriteAndBlocked", b =>
                {
                    b.HasOne("helperland.Models.User", "TargetUser")
                        .WithMany("FavoriteAndBlockedTargetUsers")
                        .HasForeignKey("TargetUserId")
                        .IsRequired()
                        .HasConstraintName("FK_FavoriteAndBlocked_User");

                    b.HasOne("helperland.Models.User", "User")
                        .WithMany("FavoriteAndBlockedUsers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_FavoriteAndBlocked_FavoriteAndBlocked");

                    b.Navigation("TargetUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("helperland.Models.Rating", b =>
                {
                    b.HasOne("helperland.Models.User", "RatingFromNavigation")
                        .WithMany("RatingRatingFromNavigations")
                        .HasForeignKey("RatingFrom")
                        .IsRequired()
                        .HasConstraintName("FK_Rating_User");

                    b.HasOne("helperland.Models.User", "RatingToNavigation")
                        .WithMany("RatingRatingToNavigations")
                        .HasForeignKey("RatingTo")
                        .IsRequired()
                        .HasConstraintName("FK_Rating_User1");

                    b.HasOne("helperland.Models.ServiceRequest", "ServiceRequest")
                        .WithMany("Ratings")
                        .HasForeignKey("ServiceRequestId")
                        .IsRequired()
                        .HasConstraintName("FK_Rating_ServiceRequest");

                    b.Navigation("RatingFromNavigation");

                    b.Navigation("RatingToNavigation");

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("helperland.Models.ServiceRequest", b =>
                {
                    b.HasOne("helperland.Models.User", "ServiceProvider")
                        .WithMany("ServiceRequestServiceProviders")
                        .HasForeignKey("ServiceProviderId")
                        .HasConstraintName("FK_ServiceRequest_User1");

                    b.HasOne("helperland.Models.User", "User")
                        .WithMany("ServiceRequestUsers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_ServiceRequest_User");

                    b.Navigation("ServiceProvider");

                    b.Navigation("User");
                });

            modelBuilder.Entity("helperland.Models.ServiceRequestAddress", b =>
                {
                    b.HasOne("helperland.Models.ServiceRequest", "ServiceRequest")
                        .WithMany("ServiceRequestAddresses")
                        .HasForeignKey("ServiceRequestId")
                        .HasConstraintName("FK_ServiceRequestAddress_ServiceRequest");

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("helperland.Models.ServiceRequestExtra", b =>
                {
                    b.HasOne("helperland.Models.ServiceRequest", "ServiceRequest")
                        .WithMany("ServiceRequestExtras")
                        .HasForeignKey("ServiceRequestId")
                        .IsRequired()
                        .HasConstraintName("FK_ServiceRequestExtra_ServiceRequest");

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("helperland.Models.UserAddress", b =>
                {
                    b.HasOne("helperland.Models.User", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserAddresses_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("helperland.Models.Zipcode", b =>
                {
                    b.HasOne("helperland.Models.City", "City")
                        .WithMany("Zipcodes")
                        .HasForeignKey("CityId")
                        .IsRequired()
                        .HasConstraintName("FK_Zipcode_City");

                    b.Navigation("City");
                });

            modelBuilder.Entity("helperland.Models.City", b =>
                {
                    b.Navigation("Zipcodes");
                });

            modelBuilder.Entity("helperland.Models.ServiceRequest", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("ServiceRequestAddresses");

                    b.Navigation("ServiceRequestExtras");
                });

            modelBuilder.Entity("helperland.Models.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("helperland.Models.User", b =>
                {
                    b.Navigation("FavoriteAndBlockedTargetUsers");

                    b.Navigation("FavoriteAndBlockedUsers");

                    b.Navigation("RatingRatingFromNavigations");

                    b.Navigation("RatingRatingToNavigations");

                    b.Navigation("ServiceRequestServiceProviders");

                    b.Navigation("ServiceRequestUsers");

                    b.Navigation("UserAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
