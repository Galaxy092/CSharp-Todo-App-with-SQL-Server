namespace C__Todo_App_with_SQL_Server.Classes
{
    public class Todo
    {
        // Field
        private string title;
        private string description;

        // Default Constructor
        public Todo() { }

        // COnstrutor with parameter
        public Todo(string title, string description)
        {
            Title = title;
            Description = description;
        }

        // Property
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
