﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsPacking.Application.Services
{
    public interface IPrintedLabelService
    {
        Guid CreatedPrintedLabels(string CodeSectorVariety, string CodeLabel, string TypeProduct, string CodePallet, int NumberBoxes, Guid UserId);
    }
}
