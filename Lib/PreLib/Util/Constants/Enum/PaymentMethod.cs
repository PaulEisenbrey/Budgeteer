using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum PaymentMethod
{
    [Description("PaymentMethodDirectPay")]
    DirectPay = -1,

    [Description("PaymentMethodCreditCard")]
    CreditCard = 1,

    [Description("PaymentMethodACH")]
    ACH = 2,

    [Description("PaymentMethodCash")]
    Cash = 3,

    [Description("PaymentMethodCorporate")]
    Corporate = 4,

    [Description("PaymentMethodManual")]
    Manual = 5,

    [Description("PaymentMethodEFT")]
    EFT = 6,

    [Description("PaymentMethodCheck")]
    Check = 7,

    [Description("PaymentMethodPayPal")]
    PayPal = 8,

    [Description("PaymentMethodAmazonWallet")]
    AmazonWallet = 9,

    [Description("PaymentMethodZuora")]
    Zuora = 10
}
