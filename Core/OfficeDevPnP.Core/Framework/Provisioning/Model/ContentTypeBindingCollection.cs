﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    public partial class ContentTypeBindingCollection : ProvisioningTemplateCollection<ContentTypeBinding>
    {
        public ContentTypeBindingCollection(ProvisioningTemplate parentTemplate) : base(parentTemplate)
        {

        }
    }
}