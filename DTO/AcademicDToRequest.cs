namespace AcademicPerformanceAPI.DTO
{
    public class AcademicDToRequest
    {
        public int Id { get; set; }

        public string? StudentName { get; set; }

        public string? ModuleCode { get; set; }

        public double AssignmentMark { get; set; }

        public double TestMark { get; set; }

        public double ExamMark { get; set; }
        
    }
}
