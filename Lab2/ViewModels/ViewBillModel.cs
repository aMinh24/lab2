using Lab2.Models;

namespace Lab2.ViewModels
{
    public class ViewBillModel
    {
        public SubscriptionType SubscriptionType { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
        public Subscription Subscription { get; set; }
    }
}
