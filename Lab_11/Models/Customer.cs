namespace Lab_11.Models
{
    public class Customer
    {
        public int IdCustomers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }

        public IList<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
