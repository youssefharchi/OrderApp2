using Microsoft.AspNetCore.Mvc;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Application.Dto;

namespace OrderApp2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("/CheckCustomer/{customerId}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        public IActionResult CustomerExists(int customerId)
        {
            return Ok(_customerService.CustomerExists(customerId));
        }

        [HttpGet("/getCustomers")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CustomerDto>))]
        public IActionResult GetCustomers()
        {
            return Ok(_customerService.GetAllCustomers());
        }

        [HttpGet("/GetCustomerBy/{customerId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetCustomer(int customerId)
        {
            if (!_customerService.CustomerExists(customerId))
                return NotFound();
            return Ok(_customerService.GetCustomer(customerId));
        }

        [HttpGet("/GetCustomersByItem/{itemId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CustomerDto>))]
        public IActionResult GetCustomersByItem(int itemId)
        {
            return Ok(_customerService.GetCustomersByItem(itemId));
        }

        [HttpPut("/PutCustomer/{customerId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateCustomer(int customerId, [FromBody] CustomerDto updatedCustomer)
        {
            if (!_customerService.CustomerExists(customerId))
                return NotFound();
            if (!_customerService.UpdateCustomer(customerId, updatedCustomer))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully updated");
        }

        [HttpPost("/PostCustomers")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult CreateCustomer([FromBody] CustomerDto newCustomer)
        {
            if (newCustomer == null)
                return BadRequest(ModelState);
            if (!_customerService.CreateCustomer(newCustomer))
            {
                ModelState.AddModelError("", "something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpDelete("/DeleteCostomer/{customerId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteCustomer(int customerId)
        {
            if (!_customerService.CustomerExists(customerId))
                return NotFound();
            if (!_customerService.DeleteCustomer(customerId))
            {
                ModelState.AddModelError("", "something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully deleted");
        }
    }
}