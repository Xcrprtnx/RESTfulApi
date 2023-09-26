namespace momraApi.Models
{
    public class issuesList
    {
        public string AccountExtId { get; set; }
        public string CustomerExtId { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double DeservedBalance { get; set; }
        public double AvailableBalance { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
