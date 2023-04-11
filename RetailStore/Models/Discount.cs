namespace RetailStore.Models
{
    public class Discount
    {
        public string DiscountType { get; set; }                    // İndirim Tipi
        public decimal Percentage { get; set; }                     // İndirim Yüzdesi
        public bool IsApplicableToGroceries { get; set; }           // Bakkaliye Ürünlerine Uygulanabilir Mi ?
    }
}