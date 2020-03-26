using HelpMyStreet.Contracts.UserService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelpMyStreet.Handlers.UserService
{
    public class FunctionBHandler : IRequestHandler<FunctionBRequest, FunctionBResponse>
    {
        public Task<FunctionBResponse> Handle(FunctionBRequest request, CancellationToken cancellationToken)
        {
            var response = new FunctionBResponse()
            {
                Status = "Active"
            };
            return Task.FromResult(response);
        }
    }
}
