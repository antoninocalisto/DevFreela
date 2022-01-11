using Microsoft.AspNetCore.Mvc;
using DevFreela.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value; 
        }
        
        [HttpGet]
        public IActionResult Get(string query)
        {
            //Buscar todos ou filtrar
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Buscar o servidor
            //Not found - Caso não exista um servidor

            return Ok();

        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            //Buscar o servidor
            //Not found - Caso não exista um servidor

            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 100)
            {
                return BadRequest();
            }


            //Atualizo o objeto

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existe, retorna NotFound

            //Remover

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComments(int id, [FromBody] CreateCommentModel createCommentModel)
        {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
