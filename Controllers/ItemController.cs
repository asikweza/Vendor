using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendor.DataAccess;
using Vendor.Entities;

namespace Vendor.Controllers
{
    [ApiController]
    [Route("item")]
    public class ItemController : Controller
    {
        [HttpGet("/all")]

        public async Task <IActionResult> GetAllItemsAsync()
        {
            return Ok(await VendorDataAccess.GetAllItemsAsync().ConfigureAwait(false));
        }
        /*
        [HttpGet("/read/additional")]

        public async Task<IActionResult> ReadAdditionalItemsAsync()
        {
            await VendorDataAccess.ReadAdditionalItemsAsync().ConfigureAwait(false);
            return Ok();
        }
        */
        [HttpPost("/add")]

        public async Task <IActionResult> AddAdditionalItemsAsync([FromBody]Item item)
        {
            await VendorDataAccess.AddAdditionalItemsAsync(item).ConfigureAwait(false);
            return Ok();
        }

        [HttpPost("/purchase")]

        public async Task<IActionResult> PurchaseItemAsyc([FromBody] Item item)
        {
            await VendorDataAccess.PurchaseItemAsyc(item).ConfigureAwait(false);
            return Ok();
        }

        [HttpGet("/history")]

        public async Task<IActionResult> ReadItemHistoryAsync()
        {
            
            return Ok(await VendorDataAccess.ReadItemHistoryAsync().ConfigureAwait(false));
        }


        [HttpPost("from/{from}/to/{to}")]

        public async Task<IActionResult> GetPurchaseHistoryOfItemInRangeAsync( [FromBody] Item item, DateTime from, DateTime to)
        {
            
            return Ok(await VendorDataAccess.GetPurchaseHistoryOfItemInRangeAsync(item, from, to).ConfigureAwait(false));
        }
    }
}
