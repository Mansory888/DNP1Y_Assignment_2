using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_1.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApiForFamilies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase
    {
        private ITFamilyManager FamilyManager;

        public FamilyController(ITFamilyManager familyManager)
        {
            this.FamilyManager = familyManager;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> getFamilies([FromQuery] int? familyId)
        {
            try
            {
                IList<Family> families = await FamilyManager.getFamilies();

                if (familyId != null)
                {
                    families = families.Where(f=>f.Id==familyId).ToList();
                }

                return Ok(families);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {
            try
            {
                Family familyToAdd = await FamilyManager.AddFamily(family);
                return Created($"/{family.Id}", family);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        public async Task<ActionResult> DeleteFamily([FromQuery] int id)
        {
            try
            {
                await FamilyManager.RemoveFamily(id);
                return Ok();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        public async Task<ActionResult<Family>> UpdateFamily([FromBody] Family family)
        {
            try
            {
                Family Update = await FamilyManager.UpdateFamily(family);
                return Ok(Update);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }


    }
}