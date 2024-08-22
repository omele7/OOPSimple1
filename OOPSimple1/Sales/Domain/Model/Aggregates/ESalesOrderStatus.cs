namespace OOPSimple1.Sales.Domain.Model.Aggregates;

public enum ESalesOrderStatus
{
    Cancelled,
    PendingPayment,
    ReadyFirShipment,
    Shipped,
    Completed
}