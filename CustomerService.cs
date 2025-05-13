namespace CustomerServiceApp
{
    public class CustomerService
    {
        private readonly List<Customer> _queue = new();
        public int MaxSize { get; }

        public CustomerService(int maxSize)
        {
            MaxSize = maxSize <= 0 ? 10 : maxSize;
        }

        public bool AddNewCustomer(string name, string id, string problem)
        {
            if (_queue.Count >= MaxSize)
            {
                Console.WriteLine("Maximum Number of Customers in Queue.");
                return false;
            }

            var customer = new Customer(name, id, problem);
            _queue.Add(customer);
            return true;
        }

        public Customer? ServeCustomer()
        {
            if (_queue.Count == 0)
            {
                Console.WriteLine("No customers to serve.");
                return null;
            }

            var customer = _queue[0];
            _queue.RemoveAt(0);
            return customer;
        }

        public int GetQueueSize() => _queue.Count;

        private class Customer
        {
            public string Name { get; }
            public string AccountId { get; }
            public string Problem { get; }

            public Customer(string name, string accountId, string problem)
            {
                Name = name;
                AccountId = accountId;
                Problem = problem;
            }

            public override string ToString() => $"{Name} ({AccountId}) : {Problem}";
        }
    }
}
