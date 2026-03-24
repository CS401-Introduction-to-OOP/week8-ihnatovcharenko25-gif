namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _deliveries = new List<T>();

    public void Add(T item)
    {
        _deliveries.Add(item);
    }

    public double GetTotalCost()
    {
        double result = 0;
        foreach (var item in _deliveries)
            result += item.CalculateCost();
        return result;
    }
}