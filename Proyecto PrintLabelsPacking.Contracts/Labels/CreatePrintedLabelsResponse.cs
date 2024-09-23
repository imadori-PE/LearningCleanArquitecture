using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Contracts.Labels
{
    public record CreatePrintedLabelsResponse(Guid Id, TypeProduct TypeProduct);
}
