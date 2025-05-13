namespace TeachLib;

public class CustomerService
{
    private List<Customer> _queue = new List<Customer>();
    private int _maxSize;

    public int MaxSize => _maxSize;
    public int QueueCount => _queue.Count;

    public CustomerService(int maxSize)
    {
        _maxSize = maxSize > 0 ? maxSize : 10;
    }

    public string AddNewCustomer(string name, string id, string problem)
    {
        if (_queue.Count >= _maxSize)
            return "Maximum Number of Customers in Queue.";

        _queue.Add(new Customer(name, id, problem));
        return "Customer added.";
    }

    public string ServeCustomer()
    {
        if (_queue.Count == 0)
            return "No customers in the queue.";

        var customer = _queue[0];
        _queue.RemoveAt(0);
        return $"Serving: {customer}";
    }
}
