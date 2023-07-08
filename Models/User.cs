using System.Collections.Generic;
using TaskManagerApi.Models;


namespace TaskManagerApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Task> Task { get; set; }

    }
}
