using HelpMyStreet.Contracts.UserService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelpMyStreet.Handlers.UserService
{
    public class FunctionAHandler : IRequestHandler<FunctionARequest, FunctionAResponse>
    {
        public Task<FunctionAResponse> Handle(FunctionARequest request, CancellationToken cancellationToken)
        {
            var response = new FunctionAResponse()
            {
                Status = "Active"
            };
            return Task.FromResult(response);
        }
    }
}
