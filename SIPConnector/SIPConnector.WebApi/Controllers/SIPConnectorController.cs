using MediatR;
using Microsoft.AspNetCore.Mvc;
using SIPConnector.Application.Buy.Commands;
using System.Dynamic;

namespace SIPConnector.WebApi.Controllers
{
    public class SIPConnectorController : Controller
    {
        private readonly IMediator _mediatr;

        public SIPConnectorController(IMediator mediatr)
        { 
            _mediatr = mediatr;
        }

        [HttpGet("buy")]
        public async Task<IActionResult> buy([FromBody] CreateBuyCommand command)
        {
            var response = await _mediatr.Send(command);
            return Ok(new { id = response });
        }
    }
}
