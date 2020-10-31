﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
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
                return Created($"/{added.Id}",added); // return newly added adult
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
                IList<Child> adults = await _familyMembersService.GetListOfChildren();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost]
        [Route("/Children")]
        public async Task<ActionResult<Adult>> AddChildren([FromBody] Child child) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child added = await _familyMembersService.AddChild(child);
                return Created($"/{added.Id}",added); // return newly added child,
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("/Pets")]
        public async Task<ActionResult<IList<Pet>>> GetPetsAsync()
        {
            try
            {
                IList<Pet> pets = await _familyMembersService.GetListOfPets();
                return Ok(pets);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost]
        [Route("/Pets")]
        public async Task<ActionResult<Adult>> AddPet([FromBody] Pet pet) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Pet added = await _familyMembersService.AddPet(pet);
                return Created($"/{added.Id}",added); // return newly added child,
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("/Families")]
        public async Task<ActionResult<IList<Family>>> GetFamiliesAsync()
        {
            try
            {
                IList<Family> families = await _familyMembersService.GetListOfFamilies();
                return Ok(families);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost]
        [Route("/Families")]
        public async Task<ActionResult<Adult>> AddFamily([FromBody] Family family) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Family added = await _familyMembersService.AddFamily(family);
                return Created($"/{added.FamilyName}",added); // return newly added family,
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}