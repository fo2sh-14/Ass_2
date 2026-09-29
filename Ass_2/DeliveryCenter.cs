namespace Ass_2;

internal class DeliveryCenter
{
    public string? CenterName;
    private Shipment[] shipment;
    public int Size { get; set; }

    public DeliveryCenter()
    {
        Size = 20;
        shipment = new Shipment[20];
    }

    #region Methods 
    public bool AddShipment(Shipment newShipment)
    {
        for (int i = 0; i < shipment.Length; i++)
        {
            if (shipment[i].trackingCode == null)
            {
                shipment[i] = newShipment;
                return true;
            }
        }
        return false;
    }
    public bool RemoveShipment(Shipment newShipment)
    {
        for (int i = 0; i < shipment.Length; i++)
        {
            if (shipment[i].trackingCode == newShipment.trackingCode)
            {
                shipment[i] = null!;
                return true;
            }
        }
        return false;
    }

    public void PrintAllShipments()
    {
        for (int i = 0; i < shipment.Length; i++)
        {
            if (shipment[i] != null)
            {
                Console.WriteLine($"TrackingCode => {shipment[i].TrackingCode}\nDescription => {shipment[i].Description}\nWeight = {shipment[i].Weight}" +
                  $"\nDeliveryFee = {shipment[i].DeliveryFee}\nDestination => {shipment[i].Destination}\nEstimatedCost = {shipment[i].EstimatedCost()}");
            }
        }
    }

    #endregion


    #region Indexer
    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipment.Length)
                return shipment[index];
            return default!;
        }
        set
        {
            if (index >= 0 && index < shipment.Length)
            {
                shipment[index] = value;
            }
        }
    }
    public Shipment this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i].trackingCode == trackingCode)
                {
                    return shipment[i];
                }
            }
            return default!;
        }
    }
    #endregion
}

