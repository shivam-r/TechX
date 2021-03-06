﻿using DCode.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCode.Models.ResponseModels.Requestor
{
    public class Requestor : RequestorSummary, IViewModel
    {
        public string CreatedBy
        {
            get;
            set;
        }

        public DateTime? CreatedOn
        {
            get;
            set;
        }

        public string UpdatedBy
        {
            get;
            set;
        }

        public DateTime? UpdatedOn
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

        public DateTime? StatusDate
        {
            get;
            set;
        }
    }
}
