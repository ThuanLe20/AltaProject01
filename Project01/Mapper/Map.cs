using AutoMapper;
using Project01.DTO;
using Project01.Entity;

namespace Project01.Mapper
{
    public class Map : Profile
    {
        public Map()
        {
            this.CreateMap<AccountDTO, Account>();
            this.CreateMap<Account, AccountDTO>();

            this.CreateMap<AdminDTO, Admin>();
            this.CreateMap<Admin, AdminDTO>();

            this.CreateMap<ClassDTO,Class>();
            this.CreateMap<Class, ClassDTO>();

            this.CreateMap<CourseDTO, Course>();
            this.CreateMap<Course, CourseDTO>();

            this.CreateMap<DocumentDTO, Document>();
            this.CreateMap<Document, DocumentDTO>();

            this.CreateMap<GradeDTO, Grade>();
            this.CreateMap<Grade, GradeDTO>();

            this.CreateMap<PositionDTO, Position>();
            this.CreateMap<Position, PositionDTO>();

            this.CreateMap<ScheduleDTO, Schedule>();
            this.CreateMap<Schedule, ScheduleDTO>();

            this.CreateMap<ScheduleCourseDTO, ScheduleCourse>();
            this.CreateMap<ScheduleCourse, ScheduleCourseDTO>();

            this.CreateMap<SchoolYearDTO, SchoolYear>();
            this.CreateMap<SchoolYear, SchoolYearDTO>();

            this.CreateMap<SemesterDTO, Semester>();
            this.CreateMap<Semester, SemesterDTO>();

            this.CreateMap<StudentDTO, Student>();
            this.CreateMap<Student, StudentDTO>();

            this.CreateMap<TestCategoryDTO,TestCategory>();
            this.CreateMap<TestCategory,TestCategoryDTO>();

            this.CreateMap<TestDetailDTO, TestDetail>();
            this.CreateMap<TestDetail, TestDetailDTO>();

            this.CreateMap<TestDTO, Test>();
            this.CreateMap<Test, TestDTO>();

            this.CreateMap<TestPointDTO, TestPoint>();
            this.CreateMap<TestPoint, TestPointDTO>();

            this.CreateMap<TranscriptDTO, Transcript>();
            this.CreateMap<Transcript, TranscriptDTO>();
        }
    }
}
