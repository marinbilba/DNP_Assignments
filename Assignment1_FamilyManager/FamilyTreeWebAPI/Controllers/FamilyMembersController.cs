using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Data.AddFamilyMembersService;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace FamilyTreeWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyMembersController : ControllerBase
    {
        private IAddFamilyMembersService _familyMembersService;

        public FamilyMembersController(IAddFamilyMembersService familyMembersService)
        {
            _familyMembersService = familyMembersService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdultsAsync()
        {
            try
            {
                IList<Adult> adults = await _familyMembersService.GetListOfAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}