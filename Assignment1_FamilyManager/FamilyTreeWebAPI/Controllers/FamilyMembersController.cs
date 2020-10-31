using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models.Family.Child;
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
        [Route("/adults")]
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
        
        [HttpPost]
        [Route("/adults")]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult added = await _familyMembersService.AddAdultAsync(adult);
                return Created($"/{added.Id}",added); // return newly added to-do, to get the auto generated id
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("/Children")]
        public async Task<ActionResult<IList<Child>>> GetChildrenAsync()
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