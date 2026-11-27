namespace STEP1_ASP.NET.DTO
{
    public class EmployeeResponseDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public object Email { get; internal set; }
    }
}
