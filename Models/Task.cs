﻿using System;
namespace TaskManagerApi.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
