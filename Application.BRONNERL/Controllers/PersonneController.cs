using Application.BRONNERL.Domain.Entities;
using Application.BRONNERL.Domain.Interfaces;
using Application.BRONNERL.Helpers;
using Application.BRONNERL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.BRONNERL.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        private readonly ILogger<PersonneController> _logger;
        private readonly IPersonnesService _personnesService;

        public PersonneController(ILogger<PersonneController> logger, IPersonnesService personnesService)
        {
            _logger = logger;
            _personnesService = personnesService;
        }

        [HttpGet(Name = "GetAllPersonnes")]
        public async Task<IEnumerable<PersonneDto>> GetAll()
        {
            _logger.LogInformation("Demande de récupération de toutes les personnes");
            return (await _personnesService.GetAll()).Select(p => new PersonneDto
            {
                Nom = p.Nom,
                Prenom = p.Prenom,
                DateDeNaissance = p.DateDeNaissance,
                Age = AgeHelper.GetAge(p)
            });
        }

        [HttpPost(Name = "Add")]
        public async Task<IActionResult> Add([FromBody] Personne personne)
        {
            try
            {
                _logger.LogInformation($"Tentative d'enregistrement de la personne {personne.Nom}");
                await _personnesService.Add(personne);
            }
            catch
            {
                _logger.LogError($"Erreur lors de la tentative d'enregistrement de la personne {personne.Nom}");
                return BadRequest();
            }

            return Ok();
        }
    }
}