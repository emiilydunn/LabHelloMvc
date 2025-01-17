namespace LabHelloMvc.Models
{
    public class Person
    {
        //Primary key
        public int PersonID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        //Navigation property
        //public List<Person> 
    }
}
