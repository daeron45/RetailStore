namespace RetailStore.APICore.Models
{
    public class Customer
    {
        public int Id { get; set; }                                 // Müşteri Id
        public string NameSurname { get; set; }                     // Müşteri AdıSoyadı
        public bool IsEmployee { get; set; }                        // Çalışan Mı ?
        public bool IsMember { get; set; }                          // Üye Mi ?
        public DateTime FirstPurchaseDateAsCustomer { get; set; }   // Müşteri olarak ilk alış yaptığı tarih
        public bool IsOldCustomer() => (DateTime.Now - FirstPurchaseDateAsCustomer).TotalDays > 730; // 365 * 2 // İlk alış tarihi 2 yıldan fazlaysa 'true' değilse 'false';
    }
}