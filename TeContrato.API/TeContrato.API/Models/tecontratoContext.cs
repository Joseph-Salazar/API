using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class tecontratoContext : DbContext
    {
        public tecontratoContext()
        {
        }

        public tecontratoContext(DbContextOptions<tecontratoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Controlemployee> Controlemployees { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Projectcontrol> Projectcontrols { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Taskprojectcontrol> Taskprojectcontrols { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=tecontrato;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasKey(e => e.Cbudget)
                    .HasName("PRIMARY");

                entity.ToTable("budget");

                entity.Property(e => e.Cbudget).HasColumnName("CBudget");

                entity.Property(e => e.Dfecha)
                    .HasColumnType("datetime")
                    .HasColumnName("DFecha");

                entity.Property(e => e.Mmonto).HasColumnName("MMonto");

                entity.Property(e => e.Tdescription)
                    .HasColumnType("text")
                    .HasColumnName("TDescription")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Ccity)
                    .HasName("PRIMARY");

                entity.ToTable("cities");

                entity.Property(e => e.Ccity).HasColumnName("CCity");

                entity.Property(e => e.Ncity)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("NCity")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Controlemployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.ProjectControlId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("controlemployees");

                entity.HasIndex(e => e.ProjectControlId, "IX_ControlEmployees_ProjectControlId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Controlemployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_ControlEmployees_Employees_EmployeeId");

                entity.HasOne(d => d.ProjectControl)
                    .WithMany(p => p.Controlemployees)
                    .HasForeignKey(d => d.ProjectControlId)
                    .HasConstraintName("FK_ControlEmployees_ProjectControls_ProjectControlId");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Cemployee)
                    .HasName("PRIMARY");

                entity.ToTable("employees");

                entity.HasIndex(e => e.JobId, "IX_Employees_JobId");

                entity.Property(e => e.Nemployee)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tposition)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tworks)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Employees_Jobs_JobId");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Cjob)
                    .HasName("PRIMARY");

                entity.ToTable("jobs");

                entity.Property(e => e.Njob)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tdescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Cposts)
                    .HasName("PRIMARY");

                entity.ToTable("posts");

                entity.HasIndex(e => e.UserId, "IX_Posts_UserId");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Ntitle)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tbody)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Posts_User_UserId");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Cproject)
                    .HasName("PRIMARY");

                entity.ToTable("projects");

                entity.HasIndex(e => e.BudgetId, "IX_Projects_BudgetId");

                entity.HasIndex(e => e.ClientId, "IX_Projects_ClientId");

                entity.HasIndex(e => e.ContractorId, "IX_Projects_ContractorId");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Nproject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tdescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK_Projects_Budget_BudgetId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProjectClients)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Projects_User_ClientId");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ProjectContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_Projects_User_ContractorId");
            });

            modelBuilder.Entity<Projectcontrol>(entity =>
            {
                entity.HasKey(e => e.Ccontrol)
                    .HasName("PRIMARY");

                entity.ToTable("projectcontrols");

                entity.HasIndex(e => e.CstatusId, "IX_ProjectControls_CStatusId");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectControls_ProjectId")
                    .IsUnique();

                entity.Property(e => e.CstatusId).HasColumnName("CStatusId");

                entity.Property(e => e.Dlastedited).HasColumnType("datetime");

                entity.Property(e => e.Nproject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Cstatus)
                    .WithMany(p => p.Projectcontrols)
                    .HasForeignKey(d => d.CstatusId)
                    .HasConstraintName("FK_ProjectControls_Status_CStatusId");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.Projectcontrol)
                    .HasForeignKey<Projectcontrol>(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectControls_Projects_ProjectId");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Cstatus)
                    .HasName("PRIMARY");

                entity.ToTable("status");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");

                entity.Property(e => e.Nstatus)
                    .HasColumnType("text")
                    .HasColumnName("NStatus")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TtaskId)
                    .HasName("PRIMARY");

                entity.ToTable("tasks");

                entity.Property(e => e.TtaskId).HasColumnName("TTaskId");

                entity.Property(e => e.TtaskName)
                    .HasColumnType("text")
                    .HasColumnName("TTaskName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Taskprojectcontrol>(entity =>
            {
                entity.HasKey(e => e.TaskCtask)
                    .HasName("PRIMARY");

                entity.ToTable("taskprojectcontrol");

                entity.HasIndex(e => e.EmployeesId, "IX_TaskProjectControl_EmployeesId");

                entity.HasIndex(e => e.ProjectControlId, "IX_TaskProjectControl_ProjectControlId");

                entity.HasIndex(e => e.TtaskId, "IX_TaskProjectControl_TTaskId");

                entity.Property(e => e.TaskCtask).HasColumnName("Task_CTask");

                entity.Property(e => e.TtaskId).HasColumnName("TTaskId");

                entity.HasOne(d => d.Employees)
                    .WithMany(p => p.Taskprojectcontrols)
                    .HasForeignKey(d => d.EmployeesId)
                    .HasConstraintName("FK_TaskProjectControl_Employees_EmployeesId");

                entity.HasOne(d => d.ProjectControl)
                    .WithMany(p => p.Taskprojectcontrols)
                    .HasForeignKey(d => d.ProjectControlId)
                    .HasConstraintName("FK_TaskProjectControl_ProjectControls_ProjectControlId");

                entity.HasOne(d => d.Ttask)
                    .WithMany(p => p.Taskprojectcontrols)
                    .HasForeignKey(d => d.TtaskId)
                    .HasConstraintName("FK_TaskProjectControl_Tasks_TTaskId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Cuser)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.HasIndex(e => e.CityId, "IX_User_CityId");

                entity.Property(e => e.Ccontractor).HasColumnName("CContractor");

                entity.Property(e => e.ClientTbio)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("Client_TBio")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.Neducation)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("NEducation")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nlastname)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nname)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nuser)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Taddress)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("TAddress")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tbio)
                    .HasColumnType("text")
                    .HasColumnName("TBio")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Temail)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoDeUsuario).HasColumnName("Tipo de Usuario");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_Cities_CityId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
