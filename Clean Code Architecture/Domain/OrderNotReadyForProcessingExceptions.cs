namespace Clean_Code_Architecture.Domain
{
    public sealed class OrderNotReadyForProcessingExceptions : Exception
    {
        public OrderNotReadyForProcessingExceptions(int orderId) : base($"The order {orderId}is ready to process.")
        {
            orderId = OrderId;
        }
        public int OrderId { get; }
    }
}
