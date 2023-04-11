using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetailStore.Classes;
using RetailStore.Models;

namespace RetailStore.Tests
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void CalculateDiscount_ShouldReturnToTotalAmount()
        {
            var invoice = new Invoice
            {
                Id = 1,
                CustomerId = 1,
                InvoiceDate = DateTime.Now,
                Products = new List<Product>
                {
                    new Product { ProductName = "Ürün 4", Quantity = 1, Price = 100m, IsGrocery = true },
                    new Product { ProductName = "Ürün 5", Quantity = 1, Price = 50m, IsGrocery = false },
                    new Product { ProductName = "Ürün 6", Quantity = 1, Price = 200m, IsGrocery = false }
                },
                SubTotal = 350m,
                DiscountAmount = 0m,
                TotalAmount = 350m
            };

            var customer = new Customer
            {
                Id = 1,
                NameSurname = "Rahim Aydın",
                IsEmployee = false,
                IsMember = true,
                FirstPurchaseDateAsCustomer = new DateTime(2022, 05, 09)
            };

            var calculatedInvoice = DiscountCalculator.CalculateDiscount(invoice, customer);

            Assert.IsNotNull(calculatedInvoice.TotalAmount);
        }

        [TestMethod]
        public void CalculateDiscount_ShouldReturnToDiscountAmount()
        {
            var invoice = new Invoice
            {
                Id = 1,
                CustomerId = 1,
                InvoiceDate = DateTime.Now,
                Products = new List<Product>
                {
                    new Product { ProductName = "Ürün 7", Quantity = 1, Price = 140m, IsGrocery = false },
                    new Product { ProductName = "Ürün 8", Quantity = 1, Price = 80m, IsGrocery = false },
                    new Product { ProductName = "Ürün 9", Quantity = 1, Price = 100m, IsGrocery = true }
                },
                SubTotal = 320m,
                DiscountAmount = 0m,
                TotalAmount = 320m
            };

            var customer = new Customer
            {
                Id = 1,
                NameSurname = "Rahim Aydın",
                IsEmployee = false,
                IsMember = true,
                FirstPurchaseDateAsCustomer = new DateTime(2019, 04, 08)
            };

            var calculatedInvoice = DiscountCalculator.CalculateDiscount(invoice, customer);

            Assert.IsNotNull(calculatedInvoice.DiscountAmount);
        }
    }
}