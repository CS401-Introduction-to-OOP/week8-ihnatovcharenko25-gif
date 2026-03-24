namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; private set; }
    public double Weight { get; private set; }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"TrackingNumber: {TrackingNumber};\nWeight: {Weight}");
    }
}