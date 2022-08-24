using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Wrappers;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<ActionResult<ServiceResponse<List<ProductViewDto>>>> Get()
        {
            var request = new GetAllProductsQuery();

            return await _mediator.Send(request);
        }

        [HttpPost("")]
        public async Task SaveAsync(CreateProduct command)
        {
            await _mediator.Send(command);
        }


        [HttpGet("id")]
        public async Task<ActionResult<ServiceResponse<ProductViewDto>>> GetByIdAsync([FromRoute] Guid Id)
        {
           
            return await _mediator.Send(new GetProductByIdQuery { Id=Id});
        }

    }
}
