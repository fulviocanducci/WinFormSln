using System;
namespace Models
{
    public class People
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
