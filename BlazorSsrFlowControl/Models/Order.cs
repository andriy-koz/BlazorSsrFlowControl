namespace BlazorSsrFlowControl.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCompleted { get; set; }
        public string? SectorName { get; set; }
        public string? ModelName { get; set; }
        public string? Part { get; set; }
        public int? GoalQuantity { get; set; }
        public int? ActualQuantity { get; set; }
        public int? QuantityPerDelivery { get; set; }
        public int? StartHour { get; set; }
        public int? StartMinute { get; set; }
        public int? EndHour { get; set; }
        public int? EndMinute { get; set; }
        public int? Day {  get; set; }
        public int? Month { get; set; }
    }
}
