namespace Ass_2;

internal class ExpressShipment: Shipment
{
    public decimal ExtraFee
    {
        get { return ExtraFee; }
        set
        {
            if (value >= 0)
                ExtraFee = value;

            ExtraFee = 0;
        }
    }


    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , decimal extra)
    : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extra;
    }

    public decimal EstimatedCost_2()
    {
        return EstimatedCost() + ExtraFee;
    }
}
