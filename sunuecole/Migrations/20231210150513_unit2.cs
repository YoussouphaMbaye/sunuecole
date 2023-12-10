using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sunuecole.Migrations
{
    /// <inheritdoc />
    public partial class unit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    IdAgents = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAgents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAgents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneAgents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.IdAgents);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    IdClasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    niveau = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.IdClasse);
                });

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    idHours = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    heure = table.Column<TimeSpan>(type: "time", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.idHours);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    idRoom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placeCount = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.idRoom);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    IdSchoolYear = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.IdSchoolYear);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    IdSupplies = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSupplies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSupplies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneSupplies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.IdSupplies);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    idTeacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexe = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placeOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.idTeacher);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    IdTutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneTutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.IdTutor);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfSubscribe",
                columns: table => new
                {
                    IdInfSubscribe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    montant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classeID = table.Column<int>(type: "int", nullable: false),
                    schoolYearID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfSubscribe", x => x.IdInfSubscribe);
                    table.ForeignKey(
                        name: "FK_InfSubscribe_Classes_classeID",
                        column: x => x.classeID,
                        principalTable: "Classes",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfSubscribe_SchoolYear_schoolYearID",
                        column: x => x.schoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "IdSchoolYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrders = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productQuantity = table.Column<double>(type: "float", nullable: false),
                    unitPrice = table.Column<double>(type: "float", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agentID = table.Column<int>(type: "int", nullable: false),
                    agentsIdAgents = table.Column<int>(type: "int", nullable: true),
                    suppliesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrders);
                    table.ForeignKey(
                        name: "FK_Orders_Agents_agentsIdAgents",
                        column: x => x.agentsIdAgents,
                        principalTable: "Agents",
                        principalColumn: "IdAgents");
                    table.ForeignKey(
                        name: "FK_Orders_Supplies_suppliesID",
                        column: x => x.suppliesID,
                        principalTable: "Supplies",
                        principalColumn: "IdSupplies",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    idLesson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coefficient = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTeacher = table.Column<int>(type: "int", nullable: false),
                    classeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.idLesson);
                    table.ForeignKey(
                        name: "FK_Lesson_Classes_classeId",
                        column: x => x.classeId,
                        principalTable: "Classes",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lesson_Teacher_idTeacher",
                        column: x => x.idTeacher,
                        principalTable: "Teacher",
                        principalColumn: "idTeacher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudents = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStudents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexe = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorID = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudents);
                    table.ForeignKey(
                        name: "FK_Students_Tutors_TutorID",
                        column: x => x.TutorID,
                        principalTable: "Tutors",
                        principalColumn: "IdTutor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoClasses",
                columns: table => new
                {
                    idDoClasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weekDay = table.Column<int>(type: "int", nullable: false),
                    hourId = table.Column<int>(type: "int", nullable: false),
                    lessonId = table.Column<int>(type: "int", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoClasses", x => x.idDoClasse);
                    table.ForeignKey(
                        name: "FK_DoClasses_Hours_hourId",
                        column: x => x.hourId,
                        principalTable: "Hours",
                        principalColumn: "idHours",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoClasses_Lesson_lessonId",
                        column: x => x.lessonId,
                        principalTable: "Lesson",
                        principalColumn: "idLesson",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoClasses_Rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "Rooms",
                        principalColumn: "idRoom",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    idEvaluation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    staus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evaluationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    evaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lessonId = table.Column<int>(type: "int", nullable: false),
                    schoolYearID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.idEvaluation);
                    table.ForeignKey(
                        name: "FK_Evaluation_Lesson_lessonId",
                        column: x => x.lessonId,
                        principalTable: "Lesson",
                        principalColumn: "idLesson",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluation_SchoolYear_schoolYearID",
                        column: x => x.schoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "IdSchoolYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaidSubscribes",
                columns: table => new
                {
                    IdPaidSubscribe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentsID = table.Column<int>(type: "int", nullable: false),
                    InfSubscribeID = table.Column<int>(type: "int", nullable: false),
                    AgentID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaidSubscribes", x => x.IdPaidSubscribe);
                    table.ForeignKey(
                        name: "FK_PaidSubscribes_Agents_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agents",
                        principalColumn: "IdAgents",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaidSubscribes_InfSubscribe_InfSubscribeID",
                        column: x => x.InfSubscribeID,
                        principalTable: "InfSubscribe",
                        principalColumn: "IdInfSubscribe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaidSubscribes_Students_studentsID",
                        column: x => x.studentsID,
                        principalTable: "Students",
                        principalColumn: "IdStudents",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterClasse",
                columns: table => new
                {
                    IdRegisterClasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolYearID = table.Column<int>(type: "int", nullable: false),
                    classeID = table.Column<int>(type: "int", nullable: false),
                    studentsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterClasse", x => x.IdRegisterClasse);
                    table.ForeignKey(
                        name: "FK_RegisterClasse_Classes_classeID",
                        column: x => x.classeID,
                        principalTable: "Classes",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterClasse_SchoolYear_schoolYearID",
                        column: x => x.schoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "IdSchoolYear",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterClasse_Students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "Students",
                        principalColumn: "IdStudents",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissOrHier",
                columns: table => new
                {
                    idMissOrHier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissingOrHier = table.Column<bool>(type: "bit", nullable: false),
                    HourComing = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayComing = table.Column<DateTime>(type: "date", nullable: false),
                    doClasseId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissOrHier", x => x.idMissOrHier);
                    table.ForeignKey(
                        name: "FK_MissOrHier_DoClasses_doClasseId",
                        column: x => x.doClasseId,
                        principalTable: "DoClasses",
                        principalColumn: "idDoClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissOrHier_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "IdStudents",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    idNote = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mark = table.Column<int>(type: "int", nullable: false),
                    evaluationId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.idNote);
                    table.ForeignKey(
                        name: "FK_Note_Evaluation_evaluationId",
                        column: x => x.evaluationId,
                        principalTable: "Evaluation",
                        principalColumn: "idEvaluation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Note_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "IdStudents",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DoClasses_hourId",
                table: "DoClasses",
                column: "hourId");

            migrationBuilder.CreateIndex(
                name: "IX_DoClasses_lessonId",
                table: "DoClasses",
                column: "lessonId");

            migrationBuilder.CreateIndex(
                name: "IX_DoClasses_roomId",
                table: "DoClasses",
                column: "roomId");

            migrationBuilder.CreateIndex(
                name: "IX_DoClasses_weekDay_roomId_hourId",
                table: "DoClasses",
                columns: new[] { "weekDay", "roomId", "hourId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_lessonId",
                table: "Evaluation",
                column: "lessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_schoolYearID",
                table: "Evaluation",
                column: "schoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_InfSubscribe_classeID",
                table: "InfSubscribe",
                column: "classeID");

            migrationBuilder.CreateIndex(
                name: "IX_InfSubscribe_schoolYearID_classeID",
                table: "InfSubscribe",
                columns: new[] { "schoolYearID", "classeID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_classeId",
                table: "Lesson",
                column: "classeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_idTeacher",
                table: "Lesson",
                column: "idTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_MissOrHier_doClasseId",
                table: "MissOrHier",
                column: "doClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_MissOrHier_studentId",
                table: "MissOrHier",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_evaluationId",
                table: "Note",
                column: "evaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_studentId",
                table: "Note",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_agentsIdAgents",
                table: "Orders",
                column: "agentsIdAgents");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_suppliesID",
                table: "Orders",
                column: "suppliesID");

            migrationBuilder.CreateIndex(
                name: "IX_PaidSubscribes_AgentID",
                table: "PaidSubscribes",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_PaidSubscribes_InfSubscribeID",
                table: "PaidSubscribes",
                column: "InfSubscribeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaidSubscribes_studentsID",
                table: "PaidSubscribes",
                column: "studentsID");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterClasse_classeID",
                table: "RegisterClasse",
                column: "classeID");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterClasse_schoolYearID",
                table: "RegisterClasse",
                column: "schoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterClasse_studentsId_schoolYearID",
                table: "RegisterClasse",
                columns: new[] { "studentsId", "schoolYearID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TutorID",
                table: "Students",
                column: "TutorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MissOrHier");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaidSubscribes");

            migrationBuilder.DropTable(
                name: "RegisterClasse");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DoClasses");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "InfSubscribe");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
