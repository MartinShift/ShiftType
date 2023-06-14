using ModelLibrary.DbModels;
using Server.DbModels;

namespace ModelLibrary.DbModels
{
    public class Client
    {
        public Client() 
        {
            Results = new HashSet<TestResult>();
        }
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Login { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public byte[]? Logo { get; set; }
        public virtual ICollection<TestResult> Results { get; set; }
    }
}