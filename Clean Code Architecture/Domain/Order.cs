namespace Clean_Code_Architecture.Domain
{
    public class Order
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public bool IsOrderVerified { get; set; }
        public bool IsProcessed { get; set; }
        public List<Items> Items { get; set; }=new List<Items>();
    }
}
