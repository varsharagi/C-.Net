namespace MyApp.Model
{
    public class AddEmployeeDto
    {
        public string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        
        public decimal Salary { get; set; }
    }
}
