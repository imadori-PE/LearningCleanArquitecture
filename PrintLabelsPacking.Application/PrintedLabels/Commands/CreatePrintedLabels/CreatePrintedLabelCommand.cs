using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Application.PrintedLabels.Commands.CreatePrintedLabels
{
    public record CreatePrintedLabelCommand(string CodeSectorVariety, string CodeLabel, string TypeProduct, string CodePallet, 
        int NumberBoxes, Guid UserId):IRequest<Guid>;
}
