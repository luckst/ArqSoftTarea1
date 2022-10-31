using ArqSoftware.CRUD.Business.Services;
using ArqSoftware.CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ArqSoftware.CRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client client;
            try
            {
                var result = _clientService.Get(id);
                client = result;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Ocurrió un error en la aplicación, intente mas tarde." + ex.Message);
            }

            return Ok(client);

        }

        [HttpGet("")]
        public IActionResult Get()
        {
            List<Client> clients;
            try
            {
                var result = _clientService.Get();
                clients = result;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Ocurrió un error en la aplicación, intente mas tarde." + ex.Message);
            }

            return Ok(clients);
        }

        [HttpPost("")]
        public IActionResult Add([FromBody] Client client)
        {
            Client result;
            try
            {
                result = _clientService.Add(client);
                if (result is null)
                {
                    return StatusCode((int)HttpStatusCode.BadRequest, "Error creando el cliente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Ocurrió un error en la aplicación, intente mas tarde." + ex.Message);
            }

            return Ok(result);
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Client client)
        {
            try
            {
                _clientService.Update(client);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Ocurrió un error en la aplicación, intente mas tarde." + ex.Message);
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _clientService.Delete(id);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Ocurrió un error en la aplicación, intente mas tarde." + ex.Message);
            }

            return Ok();
        }
    }
}
