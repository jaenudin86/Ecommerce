﻿using MrCMS.Web.Apps.Ecommerce.Entities.Orders;
using PayPal.PayPalAPIInterfaceService.Model;
using System.Linq;

namespace MrCMS.Web.Apps.Ecommerce.Payment.PayPalExpress
{
    public class GetExpressCheckoutResponse : PayPalResponse
    {
    }
    public class DoExpressCheckoutPaymentResponse : PayPalResponse
    {
        public DoExpressCheckoutPaymentResponseDetailsType Details { get; set; }

        public void UpdateOrder(Order order)
        {
            order.AuthorisationToken = Details.Token;
            var paymentInfo = Details.PaymentInfo.FirstOrDefault();
            if (paymentInfo != null)
            {
                order.PaymentStatus = paymentInfo.PaymentStatus.GetPaymentStatus();
                order.CaptureTransactionId = paymentInfo.TransactionID;
            }
        }
    }
}