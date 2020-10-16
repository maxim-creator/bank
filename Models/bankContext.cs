using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace bank.Models
{
    public partial class bankContext : DbContext
    {
        public bankContext()
        {
        }

        public bankContext(DbContextOptions<bankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contribution> Contribution { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Depositor> Depositor { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Position> Position { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb; Database = bank; Trusted_Connection = TRUE");
                //optionsBuilder.UseSqlite("Data Source=C:\\Users\\2311\\Desktop\\МП31\\михайлов\\bank.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contribution");

                entity.HasIndex(e => e.NameOfContribution)
                    .IsUnique();

                entity.Property(e => e.AdditionalConditions)
                    .HasColumnName("additional_conditions")
                    .HasColumnType("INT");

                entity.Property(e => e.CodeOfContribution)
                    .HasColumnName("code_of_contribution")
                    .HasColumnType("INT");

                entity.Property(e => e.InterestRate)
                    .HasColumnName("interest_rate")
                    .HasColumnType("INT");

                entity.Property(e => e.MaxTimeOfDeposit)
                    .HasColumnName("max_time_of_deposit")
                    .HasColumnType("INT");

                entity.Property(e => e.MinTimeOfDeposit)
                    .HasColumnName("min_time_of_deposit")
                    .HasColumnType("INT");

                entity.Property(e => e.NameOfContribution)
                    .HasColumnName("name_of_contribution")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CodeOfCurrency);

                entity.ToTable("currency");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.CodeOfCurrency)
                    .HasColumnName("code_of_currency")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasColumnType("INT");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Depositor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("depositor");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("INT");

                entity.Property(e => e.AmountOfTheRefund)
                    .HasColumnName("amount_of_the_refund")
                    .HasColumnType("INT");

                entity.Property(e => e.CodeOfContribution)
                    .HasColumnName("code_of_contribution")
                    .HasColumnType("INT");

                entity.Property(e => e.CodeOfEmployee)
                    .HasColumnName("code_of_employee")
                    .HasColumnType("INT");

                entity.Property(e => e.DateOfContribution)
                    .HasColumnName("date_of_contribution")
                    .HasColumnType("INT");

                entity.Property(e => e.DepositAmount)
                    .HasColumnName("deposit_amount")
                    .HasColumnType("INT");

                entity.Property(e => e.MarkTheReturnOfTheDepositbute)
                    .HasColumnName("mark_the_return_of_the_Depositbute")
                    .HasColumnType("INT");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("INT");

                entity.Property(e => e.PassportData)
                    .HasColumnName("passport_data")
                    .HasColumnType("INT");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("INT");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.HasIndex(e => e.PassportData)
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("INT");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("INT");

                entity.Property(e => e.CodeOfEmployee)
                    .HasColumnName("code_of_employee")
                    .HasColumnType("INT");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("INT");

                entity.Property(e => e.PassportData)
                    .HasColumnName("passport_data")
                    .HasColumnType("INT");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("INT");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.CodeOfPosition);

                entity.ToTable("position");

                entity.HasIndex(e => e.NameOfPosition)
                    .IsUnique();

                entity.Property(e => e.CodeOfPosition)
                    .HasColumnName("code_of_position")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duties)
                    .HasColumnName("duties")
                    .HasColumnType("INT");

                entity.Property(e => e.NameOfPosition)
                    .HasColumnName("name_of_position")
                    .HasColumnType("INT");

                entity.Property(e => e.Requirements)
                    .HasColumnName("requirements")
                    .HasColumnType("INT");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
