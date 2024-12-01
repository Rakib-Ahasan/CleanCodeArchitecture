namespace Clean_Code_Architecture.Domain
{
    public class OrderProcessor
    {
        private const int ProcessableItemOfNumberLine = 15;
        public void Process(Order? order)
        {
            //Now Evaluate or Refactoring this code...
            if (!IsOrderProcessable(order))
            {
                return;
            }
            if (order!.Items.Count > ProcessableItemOfNumberLine)
            {
                throw new TooManyLIneItemExceptions(order.Id);
            }
            if (order.Status == OrderStatus.ReadyToProcess)
            {
                throw new OrderNotReadyForProcessingExceptions(order.Id);
            }

            //This my old code which is not follow the standard procedure..
            //if (order != null)
            //{
            //    if (order.IsOrderVerified)
            //    {
            //        if (order.Items.Count > 0)
            //        {
            //            if(order.Items.Count > 15)
            //            {
            //                throw new Exception("The order " + order.Id + "has too many items.");
            //            }
            //            if(order.Status == "ReadyToProcess")
            //            {
            //                throw new Exception("The order " + order.Id + "is ready to process.");                        }
            //        }
            //    }
            //    return IsProcessed = true;
            //}
        }

        private static bool IsOrderProcessable(Order? order)
        {
            return order is not null && order.IsOrderVerified && order.Items.Any();
        }
    }
}
