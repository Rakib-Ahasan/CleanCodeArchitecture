namespace Clean_Code_Architecture.Domain
{
    public class OrderProcessor
    {
        public void Process(Order? order)
        {
            if (order != null)
            {
                if (order.IsOrderVerified)
                {
                    if (order.Items.Count > 0)
                    {
                        if(order.Items.Count > 15)
                        {
                            throw new Exception("The order " + order.Id + "has too many items.");
                        }
                        if(order.Status == "ReadyToProcess")
                        {
                            throw new Exception("The order " + order.Id + "is ready to process.");                        }
                    }
                }
                return IsProcessed = true;
            }
        }
    }
}
