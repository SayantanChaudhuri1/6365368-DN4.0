namespace TaskManagement
{
    public class Task
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }

        public Task(string id, string name, string status)
        {
            TaskId = id;
            TaskName = name;
            Status = status;
        }

        public override string ToString()
        {
            return $"{TaskId} | {TaskName} | {Status}";
        }
    }
}
