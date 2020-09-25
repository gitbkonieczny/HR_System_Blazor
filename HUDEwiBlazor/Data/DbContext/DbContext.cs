using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HUDEwiBlazor.Data.Models;
namespace HUDEwiBlazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Callendar Indexes
            modelBuilder.Entity<Calendar>().HasIndex(u => u.DateID).IsUnique();
            modelBuilder.Entity<Calendar>().HasIndex(u => u.WorkingWeekOfYear);
            modelBuilder.Entity<Calendar>().HasIndex(u => u.Year);
            modelBuilder.Entity<Calendar>().HasIndex(u => new { u.MonthID, u.Year });

            //Navigations Indexes
            modelBuilder.Entity<Navigation>().HasIndex(u => u.nodeId).IsUnique();

            //Days Indexes
            modelBuilder.Entity<Day>().HasIndex(u => u.DayID).IsUnique();

            //Month Indexes
            modelBuilder.Entity<Month>().HasIndex(u => u.MonthID).IsUnique();

            //Employee Indexes
            modelBuilder.Entity<Employee>().HasIndex(u => u.EmployeeID).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(u => u.Email).IsUnique();

            //Roles Indexes
            modelBuilder.Entity<Roles>().HasIndex(u => u.RolesID).IsUnique();

            //LinkEmployeRoles Indexes
            modelBuilder.Entity<LinkEmployeRoles>().HasIndex(u => u.RolesID);
            modelBuilder.Entity<LinkEmployeRoles>().HasIndex(u => u.EmployeeID);
            modelBuilder.Entity<LinkEmployeRoles>().HasIndex(u => new { u.EmployeeID, u.RolesID });

            //Projects Indexes
            modelBuilder.Entity<Projects>().HasIndex(u => u.ProjectID).IsUnique();

            //Client Indexes
            modelBuilder.Entity<Client>().HasIndex(u => u.ClientID).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(u => u.Nip).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(u => u.Regon).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(u => u.Name);
            modelBuilder.Entity<Client>().HasIndex(u => u.SurName);
            modelBuilder.Entity<Client>().HasIndex(u => u.FirstName);
            //LinkTeamsEmployee Indexes
            modelBuilder.Entity<LinkTeamsEmployee>().HasIndex(u => u.TeamId);
            modelBuilder.Entity<LinkTeamsEmployee>().HasIndex(u => u.EmployeeID);
            modelBuilder.Entity<LinkTeamsEmployee>().HasIndex(u => new { u.TeamId, u.EmployeeID });


            //LinkEmployeRoles Indexes
            modelBuilder.Entity<LinkProjectDepartment>().HasIndex(u => u.ProjectID);
            modelBuilder.Entity<LinkProjectDepartment>().HasIndex(u => u.DepartmentID);
            modelBuilder.Entity<LinkProjectDepartment>().HasIndex(u => new { u.ProjectID, u.DepartmentID });

            //LinkEmployeRoles Indexes
            modelBuilder.Entity<LinkLeaderDepartment>().HasIndex(u => u.LeaderID);
            modelBuilder.Entity<LinkLeaderDepartment>().HasIndex(u => u.DepartmentID);
            modelBuilder.Entity<LinkLeaderDepartment>().HasIndex(u => new { u.LeaderID, u.DepartmentID });

            //Teams Indexes
            modelBuilder.Entity<Teams>().HasIndex(u => u.TeamId).IsUnique();

            //Projects Indexes
            modelBuilder.Entity<Departments>().HasIndex(u => u.DepartmentID).IsUnique();

            //Shifts Indexes
            modelBuilder.Entity<Shifts>().HasIndex(u => u.ShiftID).IsUnique();


            //DayActions Indexes
            modelBuilder.Entity<DayActions>().HasIndex(u => u.DayActionsID).IsUnique();
            modelBuilder.Entity<DayActions>().HasIndex(u => u.ChildID);
            modelBuilder.Entity<DayActions>().HasIndex(u => u.EmployeeID);
            modelBuilder.Entity<DayActions>().HasIndex(u => u.FromDateID);
            modelBuilder.Entity<DayActions>().HasIndex(u => u.ToDateID);
            modelBuilder.Entity<DayActions>().HasIndex(u => u.CodeID);
            modelBuilder.Entity<DayActions>().HasIndex(u => u.Confirmed);

            modelBuilder.Entity<DayActions>().HasIndex(u => new { u.EmployeeID, u.CodeID, u.FromDateID, u.ToDateID, u.Confirmed });
            modelBuilder.Entity<DayActions>().HasIndex(u => new { u.EmployeeID, u.CodeID, u.Confirmed });
            modelBuilder.Entity<DayActions>().HasIndex(u => new { u.ChildID, u.CodeID, u.FromDateID, u.Confirmed });
            modelBuilder.Entity<DayActions>().HasIndex(u => new { u.EmployeeID, u.CodeID });

            //Codes Indexes
            modelBuilder.Entity<Codes>().HasIndex(u => u.CodeID).IsUnique();
            modelBuilder.Entity<Codes>().HasIndex(u => u.Code);

            //HolidayEventsList Indexes
            modelBuilder.Entity<HolidayEventsList>().HasIndex(u => u.EventID).IsUnique();
            modelBuilder.Entity<HolidayEventsList>().HasIndex(u => u.Count);

            //ParentHoliday Indexes
            modelBuilder.Entity<Child>().HasIndex(u => u.ChildID).IsUnique();
            modelBuilder.Entity<Child>().HasIndex(u => u.EmployeeID);

            //WorkCardSign Indexes
            modelBuilder.Entity<WorkCardSign>().HasIndex(u => u.WorkCardSignID).IsUnique();
            modelBuilder.Entity<WorkCardSign>().HasIndex(u => new { u.Month, u.Year });
            modelBuilder.Entity<WorkCardSign>().HasIndex(u => u.EmployeesID);

            //Holidays Indexes
            modelBuilder.Entity<HolidaysApi>().HasKey(c => new { c.date, c.country, c.name, c.type, c.locations });
            modelBuilder.Entity<HolidaysApi>().HasIndex(u => new { u.date, u.name });

            //MessengerGroups Indexes
            modelBuilder.Entity<MessengerGroups>().HasIndex(u => new { u.GUID });
            //Messages Indexes
            modelBuilder.Entity<Messages>().HasIndex(u => new { u.ToEmployee });
            modelBuilder.Entity<Messages>().HasIndex(u => new { u.ToGroup });

            //Relations
            modelBuilder.Entity<LinkEmployeeMessengerGroup>()
                .HasOne<Employee>(d => d.Employee)
                .WithMany(td => td.LinkEmployeeMessengerGroup)
                .HasForeignKey(d => d.EmployeeID)
                         .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LinkEmployeeMessengerGroup>()
               .HasOne<MessengerGroups>(d => d.MessengerGroups)
               .WithMany(td => td.Members)
               .HasForeignKey(d => d.groupID)
                         .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Messages>()
                .HasOne<Employee>(t => t.FromEmployeeObj)
                .WithMany(td => td.MessagesFrom)
                .HasForeignKey(x => x.FromEmployee)
                         .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Messages>()
               .HasOne<Employee>(t => t.ToEmployeeObj)
               .WithMany(td => td.MessagesTo)
               .HasForeignKey(x => x.ToEmployee)
                         .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Messages>()
               .HasOne<MessengerGroups>(t => t.ToGroupObj)
               .WithMany(td => td.Messages)
               .HasForeignKey(x => x.ToGroup)
                         .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LinkTeamsEmployee>()
               .HasOne<Employee>(d => d.Employee)
               .WithMany(td => td.LinkTeamsEmployee)
               .HasForeignKey(d => d.EmployeeID);

            modelBuilder.Entity<LinkTeamsEmployee>()
                .HasOne<Teams>(t => t.Teams)
                .WithMany(td => td.LinkTeamsEmployee)
                .HasForeignKey(t => t.TeamId);


            modelBuilder.Entity<LinkRolesMenuItem>()
              .HasOne<Roles>(d => d.Role)
              .WithMany(td => td.LinkRolesMenuItem)
              .HasForeignKey(d => d.RoleID)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LinkRolesMenuItem>()
                .HasOne<MenuItem>(t => t.MenuItem)
                .WithMany(td => td.LinkRolesMenuItem)
                .HasForeignKey(t => t.MenuItemID)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Teams>()
                 .HasOne<Employee>(t => t.TeamLeader)
                 .WithMany(td => td.Teams)
                 .HasForeignKey(x => x.TeamLeaderID);



            modelBuilder.Entity<Teams>()
              .HasOne<Projects>(t => t.Projects)
              .WithMany(td => td.Teams)
              .HasForeignKey(t => t.ProjectID)
              .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Shifts>()
              .HasOne<Projects>(t => t.Projects)
              .WithMany(td => td.Shifts)
              .HasForeignKey(t => t.ProjectID)
              .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Projects>()
                .HasOne<Employee>(t => t.ProjectLeader)
                .WithMany(td => td.Projects)
                .HasForeignKey(x => x.ProjectLeaderID);

            modelBuilder.Entity<Projects>()
              .HasOne<Employee>(t => t.deputyProjectLeader)
              .WithMany(td => td.ProjectsDeputy)
              .HasForeignKey(x => x.deputyProjectLeaderID);

            modelBuilder.Entity<LinkProjectDepartment>()
             .HasOne<Projects>(d => d.Projects)
             .WithMany(td => td.LinkProjectDepartment)
             .HasForeignKey(d => d.ProjectID)
             .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LinkProjectDepartment>()
                .HasOne<Departments>(t => t.Departments)
                .WithMany(td => td.LinkProjectDepartment)
                .HasForeignKey(t => t.DepartmentID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LinkLeaderDepartment>()
            .HasOne<Departments>(d => d.Departments)
            .WithMany(td => td.LinkLeaderDepartment)
            .HasForeignKey(d => d.DepartmentID);

            modelBuilder.Entity<LinkLeaderDepartment>()
                .HasOne<Employee>(t => t.Employee)
                .WithMany(td => td.LinkLeaderDepartment)
                .HasForeignKey(t => t.LeaderID);

            modelBuilder.Entity<WorkCardSign>()
                .HasOne<Employee>(t => t.employee)
                .WithMany(td => td.WorkCardSigns)
                .HasForeignKey(t => t.EmployeesID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OverTimesSimple>()
                .HasOne<Employee>(t => t.employee)
                .WithMany(td => td.OverTimesSimple)
                .HasForeignKey(t => t.EmployeesID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OverTimesSimple>()
                .HasOne<OverTimeTypes>(t => t.OverTimeTypes)
                .WithMany(td => td.OverTimesSimple)
                .HasForeignKey(t => t.OverTimeTypesId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OverTimesSimple>()
               .HasOne<Projects>(t => t.Projects)
               .WithMany(td => td.OverTimesSimple)
               .HasForeignKey(t => t.ProjectID)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Tokens>()
              .HasOne<Employee>(t => t.employee)
              .WithMany(td => td.Tokens)
              .HasForeignKey(t => t.EmployeesID)
              .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Schedules>()
               .HasOne<Employee>(t => t.Employee)
               .WithMany(td => td.Schedules)
               .HasForeignKey(t => t.EmployeeID)
             .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Schedules>()
              .HasOne<Shifts>(t => t.Shifts)
              .WithMany(td => td.Schedules)
              .HasForeignKey(t => t.ShiftID)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DayActions>()
             .HasOne<Codes>(t => t.Codes)
             .WithMany(td => td.DayActions)
             .HasForeignKey(t => t.CodeID);

            modelBuilder.Entity<DayActions>()
             .HasOne<HolidayEventsList>(t => t.HolidayEventsList)
             .WithMany(td => td.DayActions)
             .HasForeignKey(t => t.EventID)
              .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<HolidaysSet>()
              .HasOne<Employee>(t => t.Employee)
              .WithMany(td => td.HolidaysSet)
              .HasForeignKey(t => t.EmployeeID)
              .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<PasswordOptions>().HasNoKey();

            modelBuilder.Entity<EmailSettings>().HasNoKey();
            modelBuilder.Entity<SystemSettings>().HasNoKey();

            modelBuilder.Entity<MenuItem>()
                .HasKey(x => x.MenuItemId);

            modelBuilder.Entity<MenuItem>()
                .HasMany(x => x.Items)
                .WithOne(x => x.Parent)
                .HasForeignKey(x=>x.ParentID)
                .OnDelete(DeleteBehavior.Restrict);

          
        }


        public DbSet<PasswordLink> PasswordLink { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<LinkEmployeRoles> LinkEmployeRoles { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<LinkTeamsEmployee> LinkTeamsEmployee { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<HolidaysSet> HolidaysSet { get; set; }
        public DbSet<DayActions> DayActions { get; set; }
        public DbSet<Codes> Codes { get; set; }
        public DbSet<HolidayEventsList> HolidayEventsList { get; set; }
        public DbSet<ParentHoliday> ParentHoliday { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Tokens> Tokens { get; set; }
        public DbSet<OverTimesSimple> OverTimesSimple { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ProjectClient> ProjectClient { get; set; }
        public DbSet<WorkCardSign> WorkCardSign { get; set; }
        public DbSet<HolidaysApi> HolidaysApi { get; set; }

        public DbSet<Departments> Departments { get; set; }
        public DbSet<LinkLeaderDepartment> LinkLeaderDepartment { get; set; }
        public DbSet<LinkProjectDepartment> LinkProjectDepartment { get; set; }
        public DbSet<Schedules> Schedules { get; set; }

        public DbSet<OverTimeTypes> OverTimeTypes { get; set; }
        public DbSet<MessengerGroups> MessengerGroups { get; set; }
        public DbSet<LinkEmployeeMessengerGroup> LinkEmployeeMessengerGroup { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<PasswordOptions> PasswordOptions { get; set; }
        public DbSet<EmailSettings> EmailSettings { get; set; }
        public DbSet<SystemSettings> SystemSettings { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<LinkRolesMenuItem> LinkRolesMenuItem { get; set; }

    }
}
