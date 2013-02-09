namespace ReadAThonEntry.ViewModels
{
    using System;

    public class TimeBlock
    { 
        public   DateTime StartTime { get; set; }
        public   DateTime EndTime { get; set; }  
        public decimal Hours()
        {
            return  StartTime.HoursTo( EndTime);
        }
        public   string Department {get; set; }
        public string Comments { get; set; }
    }
}
