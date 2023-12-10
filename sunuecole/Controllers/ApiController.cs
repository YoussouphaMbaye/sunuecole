using IronBarCode;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using sunuecole.models;
using System.Data;

namespace sunuecole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly CatalogDbContext catalogDbContext;
        private readonly IWebHostEnvironment _environnement;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _signInManager;
        public ApiController(CatalogDbContext catalogDbContext, IWebHostEnvironment environnement, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            SignInManager<IdentityUser> signInManager)
        {
            this.catalogDbContext = catalogDbContext;
            this._environnement = environnement;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;

        }
        [HttpPost("/PostStudents", Name = "/PostStudents")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<ActionResult> PostEmployer([FromBody] Students st)
        {
            double ConvertToUnixTimestamp(DateTime date)
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                TimeSpan diff = date.ToUniversalTime() - origin;
                return Math.Floor(diff.TotalSeconds);
            }
            try {
                string dayToday = ConvertToUnixTimestamp(DateTime.Now).ToString();
                GeneratedBarcode gBarcode = IronBarCode.BarcodeWriter.CreateBarcode("N" + dayToday, BarcodeEncoding.QRCode);
                gBarcode.SaveAsPng(".\\Resources\\Images\\" + "N" + dayToday + ".png");
                st.code = "N" + dayToday;
                await catalogDbContext.Students.AddAsync(st);
                await  catalogDbContext.SaveChangesAsync();
                return Ok(st);
            }
            catch (Exception ex) {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostSchoolYear", Name = "/SchoolYear")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<IActionResult> PostSchoolYear([FromBody] SchoolYear sy)
        {

            try
            {

                await catalogDbContext.SchoolYear.AddAsync(sy);
                await catalogDbContext.SaveChangesAsync();
                return Ok(sy);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/PostClasse", Name = "/Classes")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<IActionResult> PostClasse([FromBody] Classe cl)
        {

            try
            {
                await catalogDbContext.Classes.AddAsync(cl);
                await catalogDbContext.SaveChangesAsync();
                return Ok(cl);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/Supplies", Name = "/Supplies")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<ActionResult> PostSupplies([FromBody] Supplies supplies)
        {

            try
            {
                await catalogDbContext.Supplies.AddAsync(supplies);
                await catalogDbContext.SaveChangesAsync();
                return Ok(supplies);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/PostAgents", Name = "/Agents")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<ActionResult> PostAgents([FromBody] Agents ag)
        {

            try
            {
                await catalogDbContext.Agents.AddAsync(ag);
                await catalogDbContext.SaveChangesAsync();
                return Ok(ag);
            }
            catch (Exception ex)
            {
               return Ok(ex);
            }

        }
        [HttpPost("/PostOrders", Name = "/Orders")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<ActionResult> PostOrder([FromBody] Orders ord)
        {

            try
            {
                await catalogDbContext.Orders.AddAsync(ord);
                await catalogDbContext.SaveChangesAsync();
                return Ok(ord);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PaidSubscribe", Name = "/PaidSubscribe")]
        //[Authorize(AuthenticationSchemes = "Bearer", Roles = nameof(RoleTypes.User))]
        public async Task<ActionResult> PaidSubscriber([FromBody] PaidSubscribe paidSubscribe)
        {

            try
            {
                await catalogDbContext.PaidSubscribes.AddAsync(paidSubscribe);
                await catalogDbContext.SaveChangesAsync();
                return Ok(paidSubscribe);
            }
            catch (Exception ex)
            {
               return Ok(ex.Message);
            }

        }
        [HttpPost("/PostRegisterClasse", Name = "/RegisterClasse")]
        public async Task<ActionResult> RegisterClasse([FromBody] RegisterClasse rg)
        {

            try
            {
                await catalogDbContext.RegisterClasse.AddAsync(rg);
                await catalogDbContext.SaveChangesAsync();
                return Ok(rg);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostLesson", Name = "/PostLesson")]
        public async Task<ActionResult> PostLesson([FromBody] Lesson lesson)
        {

            try
            {
                await catalogDbContext.Lesson.AddAsync(lesson);
                await catalogDbContext.SaveChangesAsync();
                return Ok(lesson);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/PostHours", Name = "/PostHours")]
        public async Task<ActionResult> PostHours([FromBody] Hours hours)
        {

            try
            {
                await catalogDbContext.Hours.AddAsync(hours);
                await catalogDbContext.SaveChangesAsync();
                return Ok(hours);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostRoom", Name = "/PostRoom")]
        public async Task<ActionResult> PostRoom([FromBody] Room room)
        {

            try
            {
                await catalogDbContext.Rooms.AddAsync(room);
                await catalogDbContext.SaveChangesAsync();
                return Ok(room);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostTeacher", Name = "/PostTeacher")]
        public async Task<ActionResult> PostTeacher([FromBody] Teacher teacher)
        {

            try
            {
                await catalogDbContext.Teacher.AddAsync(teacher);
                await catalogDbContext.SaveChangesAsync();
                return Ok(teacher);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostTutor", Name = "/PostTutor")]
        public async Task<ActionResult> PostTutor([FromBody] Tutor tutor)
        {

            try
            {
                await catalogDbContext.Tutors.AddAsync(tutor);
                await catalogDbContext.SaveChangesAsync();
                return Ok(tutor);
            }
            catch (Exception ex)
            {
               return Ok(ex.Message);
            }

        }
        [HttpPost("/PostDoClasse", Name = "/PostDoClasse")]
        public async Task<ActionResult> DoClasse([FromBody] DoClasse doClasse)
        {

            try
            {
                await catalogDbContext.DoClasses.AddAsync(doClasse);
                await catalogDbContext.SaveChangesAsync();
                return Ok(doClasse);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/PostInfSubscribe", Name = "/PostInfSubscribe")]
        public async Task<ActionResult> PostInfSubscribe([FromBody] InfSubscribe infSubscribe)
        {

            try
            {
                await catalogDbContext.InfSubscribe.AddAsync(infSubscribe);
                await catalogDbContext.SaveChangesAsync();
                return Ok(infSubscribe);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost("/GetNoteStudent", Name = "/GetNoteStudent")]
        public async Task<List<Note>> GetNoteStudent(int? lessonId,int? studentId, int? semestre, string? evaluationType, int? schoolYearID,int classeId,int? idTeacher, int? idEvaluation)
        {
            
            //List<Note>  emps = await catalogDbContext.Note.FromSqlRaw(sql).Include(e => e.evaluation.lesson).Include(e => e.evaluation.lesson.classe).Include(e => e.evaluation).ToListAsync();
            List<Note> emps = await catalogDbContext.Note.Where(e=> (classeId == null || e.evaluation.lesson.classeId == classeId) && (idEvaluation == null || e.evaluation.idEvaluation == idEvaluation) && (studentId == null || e.studentId == studentId) && (lessonId == null || e.evaluation.lesson.idLesson == lessonId) && (semestre == null || e.evaluation.semestre == semestre) && (evaluationType == null||e.evaluation.evaluationType == evaluationType) && (idTeacher==null||e.evaluation.lesson.idTeacher==idTeacher) && (schoolYearID==null||e.evaluation.schoolYearID==schoolYearID)).Include(e => e.evaluation.lesson).Include(e => e.evaluation.lesson.classe).Include(e => e.evaluation).Include(e => e.student).ToListAsync();
            SqlParameter[] param = new SqlParameter[]
            {
             new SqlParameter("@StudentId",studentId),
             new SqlParameter("@ClasseId",classeId)
            };
            //List<Note> emps  = await catalogDbContext.Database.SqlQueryRaw<Note>("GETNOTESTUDENTS @StudentId", param).ToListAsync();
            
            //string jjj = "kkkkk";
            if (emps != null && emps.Count() > 0)
                {
                    return emps;

                }
                else
                {
                    return new List<Note>();

                }

            
        }
        [HttpPost("/GetNoteOfStudentPerLesson", Name = "/GetNoteOfStudentPerLesson")]
        public async Task<List<RespMarkStudents>> GetNoteOfStudentPerLesson(int lessonId, int studentId, int? semestre, string? evaluationType, int schoolYearID, int classeId, int? idTeacher, int? idEvaluation)
        {

            //List<Note>  emps = await catalogDbContext.Note.FromSqlRaw(sql).Include(e => e.evaluation.lesson).Include(e => e.evaluation.lesson.classe).Include(e => e.evaluation).ToListAsync();
            List<Note> notes = await catalogDbContext.Note.Where(e => (classeId == null || e.evaluation.lesson.classeId == classeId) && (idEvaluation == null || e.evaluation.idEvaluation == idEvaluation) && (studentId == null || e.studentId == studentId) && (lessonId == null || e.evaluation.lesson.idLesson == lessonId) && (semestre == null || e.evaluation.semestre == semestre) && (evaluationType == null || e.evaluation.evaluationType == evaluationType) && (idTeacher == null || e.evaluation.lesson.idTeacher == idTeacher) && (schoolYearID == null || e.evaluation.schoolYearID == schoolYearID) && e.evaluation.staus=="A").Include(e => e.evaluation.lesson).Include(e => e.evaluation.lesson.classe).Include(e => e.evaluation).Include(e => e.student).ToListAsync();
            
            //List<Note> emps  = await catalogDbContext.Database.SqlQueryRaw<Note>("GETNOTESTUDENTS @StudentId", param).ToListAsync();

            //string jjj = "kkkkk";
            if (notes != null && notes.Count() > 0)

            {
                
                List<RespMarkStudents> lRpN = new List<RespMarkStudents>();
                foreach (Note n in notes)
                {
                    RespMarkStudents rpN = new RespMarkStudents();
                   
                    int mark = n.mark;
                    int points = n.mark * n.evaluation.lesson.coefficient;
                    Lesson l = n.evaluation.lesson;
                    Evaluation eva = n.evaluation;
                    Students stds = n.student;
                   
                    rpN.points= points;
                    rpN.mark = mark;
                    rpN.lesson = l;
                    rpN.evaluation= eva;
                    rpN.student = stds;
                    lRpN.Add(rpN);
                }
                return lRpN;

            }
            else
            {
                return new List<RespMarkStudents>();

            }
            


        }
        [HttpPost("/PostMissOrHier", Name = "/PostMissOrHier")]
        public async Task<ActionResult> PostMissOrHier([FromBody] MissOrHier missOrHier)
        {

            try
            {
                await catalogDbContext.MissOrHier.AddAsync(missOrHier);
                await catalogDbContext.SaveChangesAsync();
                return Ok(missOrHier);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/PostNote", Name = "/PostNote")]
        public async Task<ActionResult> PostNote([FromBody] Note note)
        {

            try
            {
                await catalogDbContext.Note.AddAsync(note);
                await catalogDbContext.SaveChangesAsync();
                return Ok(note);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpPost("/PostEvaluation", Name = "/PostEvaluation")]
        public async Task<ActionResult> PostEvaluation([FromBody] Evaluation evaluation)
        {

            try
            {
                await catalogDbContext.Evaluation.AddAsync(evaluation);
                await catalogDbContext.SaveChangesAsync();
                return Ok(evaluation);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetRoom")]
        public async Task<ActionResult<List<Room>>> GetRoom()
        {

            try
            {
                var st = await catalogDbContext.Rooms.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Room>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpGet("/GetSupplies")]
        public async Task<ActionResult<List<Supplies>>> GetSupplies()
        {

            try
            {
                var st = await catalogDbContext.Supplies.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Supplies>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetSchoolYearByYear")]
        public async Task<ActionResult<List<SchoolYear>>> GetSchoolYearByYear(string Year)
        {

            try
            {
                var st = await catalogDbContext.SchoolYear.Where(s=>s.year==Year).ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<SchoolYear>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetStudentsOfClasse")]
        public async Task<ActionResult<List<RegisterClasse>>> GetStudentsOfClasse(int classeId, int schoolYearId)
        {

            try
            {
                var st = await catalogDbContext.RegisterClasse.Where(r => r.classeID == classeId && r.schoolYearID == schoolYearId).Include(r => r.students).ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<RegisterClasse>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetClasseOfStudents")]
        public async Task<ActionResult<RegisterClasse>> GetClasseOfStudents(int schoolYearId, int studentId)
        {

            try
            {
                var st = await catalogDbContext.RegisterClasse.Where(r => r.schoolYearID == schoolYearId && r.studentsId == studentId).Include(r => r.classe).FirstOrDefaultAsync();
                //string jjj = "kkkkk";
                if (st != null )
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<RegisterClasse>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetAgents")]
        public async Task<ActionResult<List<Agents>>> GetAgents()
        {

            try
            {
                var st = await catalogDbContext.Agents.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Agents>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpGet("/GetInfSubscribe")]
        public async Task<ActionResult<List<InfSubscribe>>> GetInfSubscribe()
        {

            try
            {
                var st = await catalogDbContext.InfSubscribe.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<InfSubscribe>());
                }

            }
            catch (Exception ex)
            {
                return Ok (ex.Message);
            }

        }
        [HttpGet("/GetOrder")]
        public async Task<ActionResult<List<Orders>>> GetOrder()
        {

            try
            {
                var st = await catalogDbContext.Orders.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Orders>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetPaidSubscribe")]
        public async Task<ActionResult<List<PaidSubscribe>>> GetPaidSubscribe()
        {

            try
            {
                var st = await catalogDbContext.PaidSubscribes.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<PaidSubscribe>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetTutors")]
        public async Task<ActionResult<List<Tutor>>> GetTutor()
        {

            try
            {
                var st = await catalogDbContext.Tutors.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Tutor>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetMissOrHier")]
        public async Task<ActionResult<List<MissOrHier>>> GetMissOrHier()
        {

            try
            {
                var st = await catalogDbContext.MissOrHier.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<MissOrHier>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetDoClasse")]
        public async Task<ActionResult<List<DoClasse>>> GetDoClasse()
        {

            try
            {
                var st = await catalogDbContext.DoClasses.Include(r => r.hour).Include(r => r.room).Include(r=>r.lesson).OrderBy(d=>d.CreatedDate).ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<DoClasse>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetDoClasseByClasse")]
        public async Task<ActionResult<List<DoClasse>>> GetDoClasseByClasse(int idClasse)
        {

            try
            {
                var st = await catalogDbContext.DoClasses.Include(r => r.hour).Include(r => r.room).Include(r => r.lesson).Where(d=>d.lesson.classeId==idClasse).OrderBy(d => d.CreatedDate).ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<DoClasse>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetHous")]
        public async Task<ActionResult<List<Hours>>> GetHous()
        {

            try
            {
                var st = await catalogDbContext.Hours.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Hours>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetEvaluation")]
        public async Task<ActionResult<List<Evaluation>>> GetEvaluation()
        {

            try
            {
                var st = await catalogDbContext.Evaluation.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Evaluation>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
        [HttpGet("/GetNote")]
        public async Task<ActionResult<List<Note>>> GetNote()
        {

            try
            {
                var st = await catalogDbContext.Note.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Note>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetTeacher")]
        public async Task<ActionResult<List<Teacher>>> GetTeacher()
        {

            try
            {
                var st = await catalogDbContext.Teacher.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Teacher>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetLessons")]
        public async Task<ActionResult<List<Lesson>>> GetLessons()
        {
          
            try
            {
                var st = await catalogDbContext.Lesson.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Lesson>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetStudents")]
        public async Task<ActionResult<List<Students>>> GetStudents()
        {
            //Timer timer = new Timer(this.startTransaction, null, 0, 100000);
            //int i= 0;
            try
            {
                var st = await catalogDbContext.Students.ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<Students>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet("/GetRegisterClasse")]
        public async Task<ActionResult<List<RegisterClasse>>> RegisterClasse()
        {
           
            try
            {
                var st = await catalogDbContext.RegisterClasse.Include(r => r.classe).Include(r => r.students).Include(r => r.schoolYear).ToListAsync();
                //string jjj = "kkkkk";
                if (st != null && st.Count() > 0)
                {
                    return Ok(st);

                }
                else
                {
                    return Ok(new List<RegisterClasse>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet("/GetSchoolYear")]
        public async Task<ActionResult<List<SchoolYear>>> getSchoolYear()
        {
            
            try
            {
                var sy =await catalogDbContext.SchoolYear.ToListAsync();
                //string jjj = "kkkkk";
                if (sy != null && sy.Count() > 0)
                {
                    return Ok(sy);

                }
                else
                {
                    return Ok(new List<SchoolYear>());
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }




        }
        [HttpGet("/GetClasses")]
        public async Task<ActionResult<List<Classe>>> GetClasses()
        {
            //Timer timer = new Timer(this.startTransaction, null, 0, 100000);
            //int i= 0;
            try
            {
                var cl = await catalogDbContext.Classes.ToListAsync();
                //string jjj = "kkkkk";
                if (cl != null && cl.Count() > 0)
                {
                    return Ok(cl);

                }
                else
                {
                    return Ok(new List<Classe>());
                }

            }
            catch (Exception ex)
            {
               return Ok(ex.Message);
            }

        }
    }
}
    
