using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Nip = table.Column<string>(nullable: true),
                    Regon = table.Column<string>(nullable: true),
                    KRS = table.Column<string>(nullable: true),
                    Voivodeship = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Codes",
                columns: table => new
                {
                    CodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codes", x => x.CodeID);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    PersonalNumber = table.Column<string>(nullable: true),
                    ShortCut = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MobileNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PReset = table.Column<bool>(nullable: false),
                    HolidayCountry = table.Column<string>(nullable: true),
                    HolidayCountryState = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    DeviceToken = table.Column<string>(nullable: true),
                    ForcePasswordChange = table.Column<bool>(nullable: true),
                    SessionTime = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "HolidayEventsList",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayEventsList", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "HolidaysApi",
                columns: table => new
                {
                    date = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    country = table.Column<string>(nullable: false),
                    locations = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidaysApi", x => new { x.date, x.country, x.name, x.type, x.locations });
                });

            migrationBuilder.CreateTable(
                name: "MessengerGroups",
                columns: table => new
                {
                    groupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessengerGroups", x => x.groupID);
                });

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthID);
                });

            migrationBuilder.CreateTable(
                name: "Navigations",
                columns: table => new
                {
                    nodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nodeText = table.Column<string>(nullable: true),
                    iconCss = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true),
                    controller = table.Column<string>(nullable: true),
                    action = table.Column<string>(nullable: true),
                    childs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigations", x => x.nodeId);
                });

            migrationBuilder.CreateTable(
                name: "OverTimeTypes",
                columns: table => new
                {
                    OverTimeTypesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimeTypes", x => x.OverTimeTypesId);
                });

            migrationBuilder.CreateTable(
                name: "PasswordLink",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordLink", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolesID);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    ChildID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildName = table.Column<string>(nullable: true),
                    ChildBorn = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.ChildID);
                    table.ForeignKey(
                        name: "FK_Child_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HolidaysSet",
                columns: table => new
                {
                    HolidaysSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee = table.Column<int>(nullable: false),
                    Year_int = table.Column<int>(nullable: false),
                    HolidaysMax = table.Column<int>(nullable: true),
                    HolidaysGet = table.Column<int>(nullable: true),
                    HolidaysOnDemandMax = table.Column<int>(nullable: true),
                    HolidaysOnDemandGet = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidaysSet", x => x.HolidaysSetID);
                    table.ForeignKey(
                        name: "FK_HolidaysSet_Employees_Employee",
                        column: x => x.Employee,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "LinkLeaderDepartment",
                columns: table => new
                {
                    PLinkLeaderDepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(nullable: true),
                    LeaderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkLeaderDepartment", x => x.PLinkLeaderDepartmentID);
                    table.ForeignKey(
                        name: "FK_LinkLeaderDepartment_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LinkLeaderDepartment_Employees_LeaderID",
                        column: x => x.LeaderID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParentHoliday",
                columns: table => new
                {
                    ParentHolidayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    CountHoliday = table.Column<int>(nullable: true),
                    Year = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentHoliday", x => x.ParentHolidayID);
                    table.ForeignKey(
                        name: "FK_ParentHoliday_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectLeaderID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Projects_Employees_ProjectLeaderID",
                        column: x => x.ProjectLeaderID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    TokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesID = table.Column<int>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.TokenID);
                    table.ForeignKey(
                        name: "FK_Tokens_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "WorkCardSign",
                columns: table => new
                {
                    WorkCardSignID = table.Column<string>(nullable: false),
                    GenerateDate = table.Column<DateTime>(nullable: true),
                    EmployeesID = table.Column<int>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Signed = table.Column<bool>(nullable: true),
                    SignDate = table.Column<DateTime>(nullable: true),
                    Accepted = table.Column<bool>(nullable: true),
                    AcceptedDate = table.Column<DateTime>(nullable: true),
                    Closed = table.Column<bool>(nullable: true),
                    File = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCardSign", x => x.WorkCardSignID);
                    table.ForeignKey(
                        name: "FK_WorkCardSign_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "DayActions",
                columns: table => new
                {
                    DayActionsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionDate = table.Column<DateTime>(nullable: false),
                    Employee = table.Column<int>(nullable: false),
                    FromDateID = table.Column<DateTime>(nullable: false),
                    ToDateID = table.Column<DateTime>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: true),
                    ConfirmedBy = table.Column<int>(nullable: true),
                    Code = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: true),
                    ChildID = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FromShift = table.Column<string>(nullable: true),
                    ToShift = table.Column<string>(nullable: true),
                    From = table.Column<TimeSpan>(nullable: false),
                    To = table.Column<TimeSpan>(nullable: false),
                    ShowOnCard = table.Column<bool>(nullable: false),
                    ScheduleColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayActions", x => x.DayActionsID);
                    table.ForeignKey(
                        name: "FK_DayActions_Codes_Code",
                        column: x => x.Code,
                        principalTable: "Codes",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayActions_Employees_Employee",
                        column: x => x.Employee,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayActions_HolidayEventsList_EventID",
                        column: x => x.EventID,
                        principalTable: "HolidayEventsList",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "LinkEmployeeMessengerGroup",
                columns: table => new
                {
                    PLinkEmployeeMessengerGroup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: true),
                    groupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkEmployeeMessengerGroup", x => x.PLinkEmployeeMessengerGroup);
                    table.ForeignKey(
                        name: "FK_LinkEmployeeMessengerGroup_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_LinkEmployeeMessengerGroup_MessengerGroups_groupID",
                        column: x => x.groupID,
                        principalTable: "MessengerGroups",
                        principalColumn: "groupID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    messageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_message = table.Column<bool>(nullable: false),
                    FromEmployee = table.Column<int>(nullable: true),
                    ToGroup = table.Column<int>(nullable: true),
                    ToEmployee = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.messageId);
                    table.ForeignKey(
                        name: "FK_Messages_Employees_FromEmployee",
                        column: x => x.FromEmployee,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_Messages_Employees_ToEmployee",
                        column: x => x.ToEmployee,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_Messages_MessengerGroups_ToGroup",
                        column: x => x.ToGroup,
                        principalTable: "MessengerGroups",
                        principalColumn: "groupID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    DateID = table.Column<DateTime>(nullable: false),
                    DayOfMonth = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    QuarterOfYear = table.Column<int>(nullable: true),
                    DayOfQuarter = table.Column<int>(nullable: true),
                    DayofYear = table.Column<int>(nullable: true),
                    WeekOfMonth = table.Column<int>(nullable: true),
                    WeekOfQuarter = table.Column<int>(nullable: true),
                    BillingPeriod = table.Column<int>(nullable: true),
                    DayOfBillingPeriod = table.Column<int>(nullable: true),
                    WeekOfBillingPeriod = table.Column<int>(nullable: true),
                    WorkingWeekOfYear = table.Column<int>(nullable: true),
                    IsHoliday = table.Column<bool>(nullable: true),
                    DayID = table.Column<int>(nullable: true),
                    MonthID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.DateID);
                    table.ForeignKey(
                        name: "FK_Calendars_Days_DayID",
                        column: x => x.DayID,
                        principalTable: "Days",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendars_Months_MonthID",
                        column: x => x.MonthID,
                        principalTable: "Months",
                        principalColumn: "MonthID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LinkEmployeRoles",
                columns: table => new
                {
                    EmployeRolesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: true),
                    RolesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkEmployeRoles", x => x.EmployeRolesID);
                    table.ForeignKey(
                        name: "FK_LinkEmployeRoles_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LinkEmployeRoles_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "RolesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LinkProjectDepartment",
                columns: table => new
                {
                    PLinkProjectDepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkProjectDepartment", x => x.PLinkProjectDepartmentID);
                    table.ForeignKey(
                        name: "FK_LinkProjectDepartment_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_LinkProjectDepartment_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProjectClient",
                columns: table => new
                {
                    ProjectClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    ProjectsProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectClient", x => x.ProjectClientID);
                    table.ForeignKey(
                        name: "FK_ProjectClient_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectClient_Projects_ProjectsProjectID",
                        column: x => x.ProjectsProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    From = table.Column<TimeSpan>(nullable: false),
                    To = table.Column<TimeSpan>(nullable: false),
                    ProjectID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftID);
                    table.ForeignKey(
                        name: "FK_Shifts_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: true),
                    ScheduleDate = table.Column<DateTime>(nullable: false),
                    ShiftID = table.Column<int>(nullable: true),
                    ScheduleColor = table.Column<string>(nullable: true),
                    isoverride = table.Column<bool>(nullable: false),
                    From = table.Column<TimeSpan>(nullable: false),
                    To = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Schedules_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
                        principalColumn: "ShiftID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    TeamLeaderID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ShiftOrder = table.Column<string>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true),
                    ShiftsShiftID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teams_Shifts_ShiftsShiftID",
                        column: x => x.ShiftsShiftID,
                        principalTable: "Shifts",
                        principalColumn: "ShiftID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Employees_TeamLeaderID",
                        column: x => x.TeamLeaderID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LinkTeamsEmployee",
                columns: table => new
                {
                    PLinkTeamsEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkTeamsEmployee", x => x.PLinkTeamsEmployee);
                    table.ForeignKey(
                        name: "FK_LinkTeamsEmployee_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LinkTeamsEmployee_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverTimesSimple",
                columns: table => new
                {
                    OverTimeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesID = table.Column<int>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true),
                    TeamId = table.Column<int>(nullable: true),
                    TeamsTeamId = table.Column<int>(nullable: true),
                    DateID = table.Column<DateTime>(nullable: false),
                    SapOvertime = table.Column<bool>(nullable: false),
                    PaidPercent = table.Column<string>(nullable: true),
                    Confirmed = table.Column<bool>(nullable: true),
                    ConfirmedBy = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ToolTip = table.Column<string>(nullable: true),
                    FromValueTicks = table.Column<long>(nullable: false),
                    ToValueTicks = table.Column<long>(nullable: false),
                    OverTimeTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimesSimple", x => x.OverTimeID);
                    table.ForeignKey(
                        name: "FK_OverTimesSimple_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OverTimesSimple_OverTimeTypes_OverTimeTypesId",
                        column: x => x.OverTimeTypesId,
                        principalTable: "OverTimeTypes",
                        principalColumn: "OverTimeTypesId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OverTimesSimple_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OverTimesSimple_Teams_TeamsTeamId",
                        column: x => x.TeamsTeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_DateID",
                table: "Calendars",
                column: "DateID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_DayID",
                table: "Calendars",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_WorkingWeekOfYear",
                table: "Calendars",
                column: "WorkingWeekOfYear");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_Year",
                table: "Calendars",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_MonthID_Year",
                table: "Calendars",
                columns: new[] { "MonthID", "Year" });

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildID",
                table: "Child",
                column: "ChildID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Child_EmployeeID",
                table: "Child",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientID",
                table: "Client",
                column: "ClientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_FirstName",
                table: "Client",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Name",
                table: "Client",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Nip",
                table: "Client",
                column: "Nip",
                unique: true,
                filter: "[Nip] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Regon",
                table: "Client",
                column: "Regon",
                unique: true,
                filter: "[Regon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Client_SurName",
                table: "Client",
                column: "SurName");

            migrationBuilder.CreateIndex(
                name: "IX_Codes_Code",
                table: "Codes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Codes_CodeID",
                table: "Codes",
                column: "CodeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_ChildID",
                table: "DayActions",
                column: "ChildID");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Code",
                table: "DayActions",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Confirmed",
                table: "DayActions",
                column: "Confirmed");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_DayActionsID",
                table: "DayActions",
                column: "DayActionsID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Employee",
                table: "DayActions",
                column: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_EventID",
                table: "DayActions",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_FromDateID",
                table: "DayActions",
                column: "FromDateID");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_ToDateID",
                table: "DayActions",
                column: "ToDateID");

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Employee_Code",
                table: "DayActions",
                columns: new[] { "Employee", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Employee_Code_Confirmed",
                table: "DayActions",
                columns: new[] { "Employee", "Code", "Confirmed" });

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_ChildID_Code_FromDateID_Confirmed",
                table: "DayActions",
                columns: new[] { "ChildID", "Code", "FromDateID", "Confirmed" });

            migrationBuilder.CreateIndex(
                name: "IX_DayActions_Employee_Code_FromDateID_ToDateID_Confirmed",
                table: "DayActions",
                columns: new[] { "Employee", "Code", "FromDateID", "ToDateID", "Confirmed" });

            migrationBuilder.CreateIndex(
                name: "IX_Days_DayID",
                table: "Days",
                column: "DayID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentID",
                table: "Departments",
                column: "DepartmentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeID",
                table: "Employees",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HolidayEventsList_Count",
                table: "HolidayEventsList",
                column: "Count");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayEventsList_EventID",
                table: "HolidayEventsList",
                column: "EventID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HolidaysApi_date_name",
                table: "HolidaysApi",
                columns: new[] { "date", "name" });

            migrationBuilder.CreateIndex(
                name: "IX_HolidaysSet_Employee",
                table: "HolidaysSet",
                column: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEmployeeMessengerGroup_EmployeeID",
                table: "LinkEmployeeMessengerGroup",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEmployeeMessengerGroup_groupID",
                table: "LinkEmployeeMessengerGroup",
                column: "groupID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEmployeRoles_EmployeeID",
                table: "LinkEmployeRoles",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEmployeRoles_RolesID",
                table: "LinkEmployeRoles",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEmployeRoles_EmployeeID_RolesID",
                table: "LinkEmployeRoles",
                columns: new[] { "EmployeeID", "RolesID" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkLeaderDepartment_DepartmentID",
                table: "LinkLeaderDepartment",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkLeaderDepartment_LeaderID",
                table: "LinkLeaderDepartment",
                column: "LeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkLeaderDepartment_LeaderID_DepartmentID",
                table: "LinkLeaderDepartment",
                columns: new[] { "LeaderID", "DepartmentID" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkProjectDepartment_DepartmentID",
                table: "LinkProjectDepartment",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkProjectDepartment_ProjectID",
                table: "LinkProjectDepartment",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkProjectDepartment_ProjectID_DepartmentID",
                table: "LinkProjectDepartment",
                columns: new[] { "ProjectID", "DepartmentID" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkTeamsEmployee_EmployeeID",
                table: "LinkTeamsEmployee",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkTeamsEmployee_TeamId",
                table: "LinkTeamsEmployee",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkTeamsEmployee_TeamId_EmployeeID",
                table: "LinkTeamsEmployee",
                columns: new[] { "TeamId", "EmployeeID" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromEmployee",
                table: "Messages",
                column: "FromEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToEmployee",
                table: "Messages",
                column: "ToEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToGroup",
                table: "Messages",
                column: "ToGroup");

            migrationBuilder.CreateIndex(
                name: "IX_MessengerGroups_GUID",
                table: "MessengerGroups",
                column: "GUID");

            migrationBuilder.CreateIndex(
                name: "IX_Months_MonthID",
                table: "Months",
                column: "MonthID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Navigations_nodeId",
                table: "Navigations",
                column: "nodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OverTimesSimple_EmployeesID",
                table: "OverTimesSimple",
                column: "EmployeesID");

            migrationBuilder.CreateIndex(
                name: "IX_OverTimesSimple_OverTimeTypesId",
                table: "OverTimesSimple",
                column: "OverTimeTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_OverTimesSimple_ProjectID",
                table: "OverTimesSimple",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_OverTimesSimple_TeamsTeamId",
                table: "OverTimesSimple",
                column: "TeamsTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentHoliday_EmployeeID",
                table: "ParentHoliday",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectClient_ClientID",
                table: "ProjectClient",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectClient_ProjectsProjectID",
                table: "ProjectClient",
                column: "ProjectsProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectID",
                table: "Projects",
                column: "ProjectID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectLeaderID",
                table: "Projects",
                column: "ProjectLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RolesID",
                table: "Roles",
                column: "RolesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_EmployeeID",
                table: "Schedules",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ShiftID",
                table: "Schedules",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ProjectID",
                table: "Shifts",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ShiftID",
                table: "Shifts",
                column: "ShiftID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectID",
                table: "Teams",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ShiftsShiftID",
                table: "Teams",
                column: "ShiftsShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamId",
                table: "Teams",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamLeaderID",
                table: "Teams",
                column: "TeamLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_EmployeesID",
                table: "Tokens",
                column: "EmployeesID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCardSign_EmployeesID",
                table: "WorkCardSign",
                column: "EmployeesID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCardSign_WorkCardSignID",
                table: "WorkCardSign",
                column: "WorkCardSignID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkCardSign_Month_Year",
                table: "WorkCardSign",
                columns: new[] { "Month", "Year" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "DayActions");

            migrationBuilder.DropTable(
                name: "HolidaysApi");

            migrationBuilder.DropTable(
                name: "HolidaysSet");

            migrationBuilder.DropTable(
                name: "LinkEmployeeMessengerGroup");

            migrationBuilder.DropTable(
                name: "LinkEmployeRoles");

            migrationBuilder.DropTable(
                name: "LinkLeaderDepartment");

            migrationBuilder.DropTable(
                name: "LinkProjectDepartment");

            migrationBuilder.DropTable(
                name: "LinkTeamsEmployee");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Navigations");

            migrationBuilder.DropTable(
                name: "OverTimesSimple");

            migrationBuilder.DropTable(
                name: "ParentHoliday");

            migrationBuilder.DropTable(
                name: "PasswordLink");

            migrationBuilder.DropTable(
                name: "ProjectClient");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "WorkCardSign");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Codes");

            migrationBuilder.DropTable(
                name: "HolidayEventsList");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "MessengerGroups");

            migrationBuilder.DropTable(
                name: "OverTimeTypes");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
