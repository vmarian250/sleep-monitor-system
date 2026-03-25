namespace SleepMonitorWebService.Models
{
    public class SleepFactor
    {
        public int Id { get; set; }
        public int SleepLogId { get; set; } // Legătura cu SleepEntry
        public string Factor { get; set; }
    }
}
