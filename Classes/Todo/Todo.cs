using System;

namespace C__Todo_App_with_SQL_Server.Classes
{
    public class Todo
    {
        public int TodoID { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string completed { get; set; }

        public string Description { get; set; }

        public Todo() { }

        public Todo(int todoID, string title, DateTime date, string completed, string description)
        {
            TodoID = todoID;
            Title = title;
            Date = date;
            this.completed = completed;
            Description = description;
        }
    }
}
