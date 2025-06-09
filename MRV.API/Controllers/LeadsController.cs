using MediatR;
using Microsoft.AspNetCore.Mvc;
using MRV.Application.Leads.Commands;
using MRV.Application.Leads.Queries.GetLeadsAccepted;
using MRV.Application.Leads.Queries.GetLeadsInvited;
using MRV.Domain.Abstractions;

namespace MRV.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public LeadsController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetLeadsInvited()
        {
            var query = new GetLeadsInvitedQuery();
            var leadsInvited = await _mediator.Send(query);
            return Ok(leadsInvited);
        }

        [HttpGet]
        public async Task<IActionResult> GetLeadsAccepted()
        {
            var query = new GetLeadsAcceptedQuery();
            var leadsAccepted = await _mediator.Send(query);
            return Ok(leadsAccepted);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLead(int id, UpdateLeadCommand command)
        {
            command.Id = id;
            var acceptedLead = await _mediator.Send(command);

            return acceptedLead is not null ? Ok(acceptedLead) : NotFound("Lead not found");
        }
    }
}
