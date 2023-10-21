using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EducationClubs.TestModels;

public partial class EducationClubContext : DbContext
{
    public EducationClubContext()
    {
    }

    public EducationClubContext(DbContextOptions<EducationClubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AdditionalClass> AdditionalClasses { get; set; }

    public virtual DbSet<Attendence> Attendences { get; set; }

    public virtual DbSet<DayOfWeek> DayOfWeeks { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Tutor> Tutors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;User ID=SA;Password=sTrongPassword123;Database=EducationClub;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnName("Role_Id");

            entity.HasOne(d => d.Role).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_Account_Role");
        });

        modelBuilder.Entity<AdditionalClass>(entity =>
        {
            entity.ToTable("AdditionalClass");

            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TutorId).HasColumnName("Tutor_Id");

            entity.HasOne(d => d.Tutor).WithMany(p => p.AdditionalClasses)
                .HasForeignKey(d => d.TutorId)
                .HasConstraintName("FK_AdditionalClass_Tutor");
        });

        modelBuilder.Entity<Attendence>(entity =>
        {
            entity.ToTable("Attendence");

            entity.Property(e => e.LessonId).HasColumnName("Lesson_Id");
            entity.Property(e => e.StudentId).HasColumnName("Student_Id");

            entity.HasOne(d => d.Lesson).WithMany(p => p.Attendences)
                .HasForeignKey(d => d.LessonId)
                .HasConstraintName("FK_Attendence_Lesson");

            entity.HasOne(d => d.Student).WithMany(p => p.Attendences)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Attendence_Student");
        });

        modelBuilder.Entity<DayOfWeek>(entity =>
        {
            entity.ToTable("DayOfWeek");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.ToTable("Lesson");

            entity.Property(e => e.AdditionalClassId).HasColumnName("AdditionalClass_Id");
            entity.Property(e => e.DayOfWeekId).HasColumnName("DayOfWeek_Id");
            entity.Property(e => e.TimeFinish).HasColumnType("datetime");
            entity.Property(e => e.TimeStart).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.AdditionalClass).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.AdditionalClassId)
                .HasConstraintName("FK_Lesson_AdditionalClass");

            entity.HasOne(d => d.DayOfWeek).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.DayOfWeekId)
                .HasConstraintName("FK_Lesson_DayOfWeek");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<Tutor>(entity =>
        {
            entity.ToTable("Tutor");

            entity.Property(e => e.AccountId).HasColumnName("Account_Id");
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);

            entity.HasOne(d => d.Account).WithMany(p => p.Tutors)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_Tutor_Account");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
