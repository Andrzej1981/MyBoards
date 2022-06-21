namespace MyBoards.Entities
{
    public class WorkItem
    {
        public string State { get; set; }
        public string Area { get; set; }
        public string IterationPath { get; set; }
        public int Priority { get; set; }
        //Epic
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //Isue
        public decimal Efford { get; set; }
        //Task
        public string Activyty { get; set; }
        public decimal RemaningWork { get; set; }
        public string Type { get; set; }


    }
}
