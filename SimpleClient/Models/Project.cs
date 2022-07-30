using System.ComponentModel.DataAnnotations;

namespace SimpleClient.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string? projectName { get; set; }
        public string? clientEmail { get; set; }
        public int projectPrice { get; set; }
        public DateTime projectDeadline { get; set; }
        public string? projectDescription { get; set; }
        public int projectSize { get; set; }
        public string? concludingNotes { get; set; }
    }
}