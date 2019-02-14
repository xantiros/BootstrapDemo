namespace DataLibrary.Models
{
    public class EmployeeModel
    {//do mapowania mozna uzyc AutoMapera
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
