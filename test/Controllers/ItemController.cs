using Microsoft.AspNetCore.Mvc;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Application.Dto;

namespace OrderApp2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IItemService _ItemService;

        public ItemController(IItemService ItemService)
        {
            _ItemService = ItemService;
        }

        [HttpGet("/GetItemsINOrder")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ItemDto>))]
        public IActionResult GetItemsInOrder(int OrderId)
        {
            return Ok(_ItemService.GetItemsByOrder(OrderId));
        }

        [HttpGet("/CheckItem/{ItemId}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        public IActionResult ItemExists(int ItemId)
        {
            return Ok(_ItemService.ItemExists(ItemId));
        }

        [HttpGet("/getItems")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ItemDto>))]
        public IActionResult GetItems()
        {
            return Ok(_ItemService.GetAllItems());
        }

        [HttpGet("/GetItemBy/{ItemId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetItem(int ItemId)
        {
            if (!_ItemService.ItemExists(ItemId))
                return NotFound();
            return Ok(_ItemService.GetItem(ItemId));
        }

        [HttpPut("/PutItem")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateItem([FromBody] ItemDto updatedItem)
        {
            if (!_ItemService.ItemExists(updatedItem.ItemId))
                return NotFound();
            if (!_ItemService.UpdateItem(updatedItem))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully updated");
        }

        [HttpPost("/PostItems")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult CreateItem([FromBody] ItemDto newItem)
        {
            if (newItem == null)
                return BadRequest(ModelState);
            if (!_ItemService.CreateItem(newItem))
            {
                ModelState.AddModelError("", "something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpDelete("/DeleteItem/{ItemId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteItem(int ItemId)
        {
            if (!_ItemService.ItemExists(ItemId))
                return NotFound();
            if (!_ItemService.DeleteItem(ItemId))
            {
                ModelState.AddModelError("", "something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully deleted");
        }
    }
}