namespace Clean_Code_Architecture.Domain
{
    public sealed class TooManyLIneItemExceptions : Exception
    {
        public TooManyLIneItemExceptions(int orderId):base($"The order {orderId}has too many items.")
        {
            orderId = OrderId; 
        }
        public int OrderId { get; }
    }
}
