using RetailStore.APICore.Models;

namespace RetailStore.APICore.Classes
{
    public class DiscountCalculator
    {
        public static async Task<Invoice> CalculateDiscountAsync(InvoiceCustomerModel model)
        {
            await Task.Delay(100);

            var invoice = model.Invoice;
            var customer = model.Customer;

            decimal totalDiscountAmount = 0;
            decimal nonGroceryAmount = 0;

            // Bakkaliye ürünleri dikkate alınmayacak şekilde fiyatlar toplanıyor.
            foreach (var product in invoice.Products)
            {
                if (!product.IsGrocery)
                {
                    nonGroceryAmount += product.Price;
                }
            }

            // Müşteri tipine göre indirim hesaplamaları
            if (customer.IsEmployee)
            {
                totalDiscountAmount += nonGroceryAmount * 0.3m;
            }
            else if (customer.IsMember)
            {
                totalDiscountAmount += nonGroceryAmount * 0.1m;
            }
            else if (customer.IsOldCustomer())
            {
                totalDiscountAmount += nonGroceryAmount * 0.05m;
            }

            // Toplam tutara göre her 100$ için 5$ indirim hesabı
            totalDiscountAmount += Math.Floor(invoice.SubTotal / 100) * 5m;

            // İndirim ve Toplam Tutar atanıyor.
            invoice.DiscountAmount = totalDiscountAmount;
            invoice.TotalAmount = invoice.SubTotal - totalDiscountAmount;

            return invoice;
        }
    }
}