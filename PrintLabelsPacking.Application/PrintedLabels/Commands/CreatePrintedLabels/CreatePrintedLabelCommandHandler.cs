using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Application.PrintedLabels.Commands.CreatePrintedLabels
{
    public class CreatePrintedLabelCommandHandler : IRequestHandler<CreatePrintedLabelCommand, Guid>
    {
        public Task<Guid> Handle(CreatePrintedLabelCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
