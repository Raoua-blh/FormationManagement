using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using ClubManagement.Entities;
using ClubManagement.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationManagement.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class FormationController : ControllerBase
    {



        private readonly IFormationServices _formationService;



        public FormationController(IFormationServices formationService)
        {
            _formationService = formationService;
        }



        [HttpPost]
        public IActionResult AddFormation([FromBody] Formation formationToSave)
        {
            try
            {
                if (formationToSave == null)
                {
                    return BadRequest("Aucune Formation trouvé!");
                }
                Formation saveResultItem = _formationService.AddFormation(formationToSave);
                return Ok(saveResultItem);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetList()
        {
            try
            {
                List<Formation> List = _formationService.GetListFormations();
                return Ok(List);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }


    }
    }




