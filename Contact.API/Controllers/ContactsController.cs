using Contact.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("GetContacts")]
        public IActionResult GetContacts()
        {
            var result = contactService.GetContact();
            return Ok(result);
        }
    }
}
