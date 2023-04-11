namespace RetailStore.Models
{
    public class Product
    {
        public string ProductName { get; set; }                     // Ürün Adı
        public decimal Price { get; set; }                          // Fiyat
        public float Quantity { get; set; }                         // Miktar
        public bool IsGrocery { get; set; }                         // Bakkaliye Ürünü Mü ?
    }
}