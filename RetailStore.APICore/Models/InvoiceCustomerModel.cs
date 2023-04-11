namespace RetailStore.APICore.Models;

public class InvoiceCustomerModel
{
    public Invoice Invoice { get; set; }
    public Customer Customer { get; set; }
}