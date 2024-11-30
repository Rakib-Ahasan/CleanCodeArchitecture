namespace Clean_Code_Architecture.Domain
{
    public class Order
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public bool IsOrderVerified { get; set; }
        public bool IsProcessed { get; set; }
        List<Items> Items { get; set; }
    }
}
