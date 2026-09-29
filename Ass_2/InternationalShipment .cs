namespace Ass_2;

internal class InternationalShipment : Shipment
{
    public string DestinationCountry 
    {
        get
        {
            return DestinationCountry;
        }
        set 
        {
            if (value != null)
                DestinationCountry = value;
        } 
    }

    public decimal CustomsFee
            
    {
        get { return CustomsFee; }
        set
        {
            if (value >= 0)
                CustomsFee = value;
        }
    }

    public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal customsFee)
: base(trackingCode, description, weight, deliveryFee, destination)
    {
        CustomsFee = customsFee;
    }

    public decimal EstimatedCost_2()
    {
        return EstimatedCost() + CustomsFee;
    }



}
