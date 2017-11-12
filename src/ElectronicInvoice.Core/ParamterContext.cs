﻿using ElectronicInvoice.Core.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicInvoice.Core.Infrastructure
{
    public partial class ParamterContext
    {
        private DESCrypHelper help = new DESCrypHelper();

        public string UUID
        {
            get
            {
                return "9774d56d682e549c";
            }
        }

        public string GovAPIKey
        {
            get
            {
                return help.DecryptData(new ConfigHelper().GovAPIKey);
            }
        }

        public string GovAppId
        {
            get
            {
                return help.DecryptData(new ConfigHelper().GovAppId);
            }
        }

        public string TimeStamp
        {
            get
            {
                return (CommonHelper.GetTimeStamp() + 15).ToString();
            }
        }

        public string TimeStampMAX
        {
            get
            {
                return (CommonHelper.GetTimeStamp() + 10000).ToString();
            }
        }
    }
}