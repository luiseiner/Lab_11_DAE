namespace Lab_11.Models
{
    public class Invoice
    {
        public int IdInvoices { get; set; }
        public int Customers_IdCustomers { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        public Customer Customer { get; set; }
        public IList<Detail> Details { get; set; } = new List<Detail>();
    }
}
