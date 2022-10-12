namespace DesignPatterns.Structural.Facade.Domain;

/// <summary>
/// Domain Service using the OnlinePaymentServiceFacade
/// </summary>
public class OnlinePaymentService : IPayment
{
    private readonly IOnlinePaymentServiceFacade _onlinePaymentFacade;

    public OnlinePaymentService(IOnlinePaymentServiceFacade onlinePaymentServiceFacade)
    {
        _onlinePaymentFacade = onlinePaymentServiceFacade;
    }

    public string DoPayment(Order order, Payment payment)
    {
        payment.Value = order.Products.Sum(p => p.Price);
        Console.WriteLine($"Starting payment - Total ${payment.Value}");

        if (_onlinePaymentFacade.DoPayment(order, payment))
        {

            string transactionResult = payment.PaymentMethod switch
            {
                PaymentMethods.CreditCard => "Successfully paid via Credit Card",
                PaymentMethods.DebitCard => "Successfully paid via Debit Card",
                _ => "Method not accepted."
            };

            return transactionResult;
        }

        return "Sorry. Your card was declined!";            
    }
}