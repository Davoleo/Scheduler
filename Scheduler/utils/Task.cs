namespace Scheduler.Utils
{
    class Task
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public EnumStatus Status { get; set; }
        public string Info { get; set; }

        public Task(int id, string name, EnumStatus status, string info)
        {
            ID = id;
            ProjectName = name;
            Status = status;
            Info = info;
        }

    }
}
