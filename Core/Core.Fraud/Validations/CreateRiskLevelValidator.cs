﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFT.RegoV2.Core.Fraud.Validations
{
    public class CreateRiskLevelValidator : RiskLevelValidatorBase
    {
        public CreateRiskLevelValidator(IFraudRepository repository)
            : base(repository)
        { }

    }
}
