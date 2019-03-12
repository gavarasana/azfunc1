using System;

namespace ravi.learn.af.one.Models
{
    public class TodoModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class TodoCreateModel
    {
        public string Description { get; set; }
    }

    public class TodoUpdateModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
