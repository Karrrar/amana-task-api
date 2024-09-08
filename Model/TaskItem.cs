using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace Amana_Api.Model
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }

    }

    public enum Priority
    {
        Hight = 0,
        Medium = 1,
        Low = 2,
    }
}
