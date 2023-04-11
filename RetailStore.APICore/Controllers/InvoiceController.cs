using Microsoft.AspNetCore.Mvc;
using RetailStore.APICore.Classes;
using RetailStore.APICore.Models;

namespace RetailStore.APICore.Controllers
{
    [ApiController]
    [Route("api/invoice")]
    public class InvoiceController : ControllerBase
    {
        [HttpPost]
        [Route("discount")]
        public async Task<IActionResult> Discount([FromBody] InvoiceCustomerModel model)
        {
            var response = await DiscountCalculator.CalculateDiscountAsync(model);
            return Ok(response);
        }
    }
}