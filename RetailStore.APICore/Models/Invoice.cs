namespace RetailStore.APICore.Models
{
    public class Invoice
    {
        public int Id { get; set; }                                 // ID
        public int CustomerId { get; set; }                         // Müşteri ID
        public DateTime InvoiceDate { get; set; }                   // Fatura Tarihi
        public List<Product> Products { get; set; }                 // Fatura Ürünleri
        public decimal SubTotal { get; set; }                       // Ara Toplam
        public decimal DiscountAmount { get; set; }                 // İndirim Tutarı
        public decimal TotalAmount { get; set; }                    // Toplam Tutar
    }
}