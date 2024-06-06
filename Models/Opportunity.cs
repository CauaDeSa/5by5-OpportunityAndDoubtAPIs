namespace Models;

public class Opportunity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string OutbreakLevel { get; set; }
    public int HoursQuantity { get; set; }
    public long ErrorQuantity { get; set; }
    public long LearningLevel { get; set; }
    public long SleepTime { get; set; }
    public int OffDutyHours { get; set; }
}