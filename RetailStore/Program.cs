using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RetailStore.Models;

namespace RetailStore
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var invoice = new Invoice
            {
                Id = 1,
                CustomerId = 1,
                InvoiceDate = DateTime.Now,
                Products = new List<Product>
                {
                    new Product { ProductName = "Ürün 1", Quantity = 1, Price = 100m, IsGrocery = false },
                    new Product { ProductName = "Ürün 2", Quantity = 1, Price = 50m, IsGrocery = true },
                    new Product { ProductName = "Ürün 3", Quantity = 2, Price = 400m, IsGrocery = false }
                },
                SubTotal = 950m,
                DiscountAmount = 0m,
                TotalAmount = 950m
            };

            var customer = new Customer
            {
                Id = 1,
                NameSurname = "Rahim Aydın",
                IsEmployee = true,
                IsMember = false,
                FirstPurchaseDateAsCustomer = new DateTime(2020, 04, 09)
            };

            var calculatedInvoiceSubTotal = 0M;
            var calculatedInvoiceDiscountAmount = 0M;
            var calculatedInvoiceTotalAmount = 0M;

            // API isteği için gerekli bilgileri ayarla
            var model = new InvoiceCustomerModel { Invoice = invoice, Customer = customer };

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = await client.PostAsync("https://localhost:7147/api/invoice/discount", content);

            // Yanıtı oku
            var responseString = await responseMessage.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<Invoice>(responseString);

            calculatedInvoiceSubTotal = Convert.ToDecimal(responseObject.SubTotal);
            calculatedInvoiceDiscountAmount = Convert.ToDecimal(responseObject.DiscountAmount);
            calculatedInvoiceTotalAmount = Convert.ToDecimal(responseObject.TotalAmount);

            //
            // Ekrana yazdır
            Console.WriteLine($" Tutar          : {calculatedInvoiceSubTotal:n2}");
            Console.WriteLine($" İndirim Tutarı : {calculatedInvoiceDiscountAmount:n2}");
            Console.WriteLine($" Net Tutar      : {calculatedInvoiceTotalAmount:n2}");

            Console.WriteLine();
            Console.WriteLine("Bir tuşa basınız...");
            Console.ReadKey();
        }
    }

    public class InvoiceCustomerModel
    {
        public Invoice Invoice { get; set; }
        public Customer Customer { get; set; }
    }
}

