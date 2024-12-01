namespace Clean_Code_Architecture.Domain
{
    public record ProcessOrderResult
    {
        private ProcessOrderResult(long orderId , string message)
        {
            OrderId = orderId;
            Message = message;
        }

        public long OrderId { get; init; }
        public string Message { get; init; }
        public static ProcessOrderResult NotProcessable(long orderId)
        {
            return ( $"This order {orderId} is not processable.");
        }
    }

}