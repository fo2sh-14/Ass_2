namespace Ass_2;

internal class Shipment
{
    #region Property
    public string TrackingCode;
    public string Description;
    public decimal Weight;
    public decimal DeliveryFee;
    public DeliveryAddress Destination { get; set; }
    #endregion

    #region Constractor 
    public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, default)
    {
        //Description = "Unknown";
        //Weight = 1;
        //DeliveryFee = 50;
        //Destination = default;
    }
    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        Destination = destination;
    }
    #endregion

    #region Getter - Setter
    public string trackingCode
    {
        get { return TrackingCode; }

    }
    public string description
    {
        get { return Description; }
        set
        {
            if (value != null)
                Description = value;
        }
    }
    public decimal weight
    {
        get { return Weight; }
        set
        {
            if (value >= 0)
                Weight = value;
        }
    }
    public decimal deliveryFee
    {
        get { return DeliveryFee; }
        private set
        {
            if (value >= 0)
                DeliveryFee = value;
        }
    }
    #endregion

    #region Methods
    public decimal EstimatedCost()
    {
        return DeliveryFee + (Weight * 5) ;
    }
    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee >= 0)
            DeliveryFee = newFee;
    }
    public override string ToString()
    {
        return $"TrackingCode => {TrackingCode} \nDescription => {Description}\nWeight = {Weight}\nDeliveryFee = {DeliveryFee}" +
            $"\nDestination => {Destination}\nEstimatedCost = {EstimatedCost()}";
    }
    #endregion



    }

