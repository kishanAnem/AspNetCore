﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public sealed class TrimAttribute : Attribute
    {
        public TrimAttribute(TrimType trimType = TrimType.Trim)
        {
            TrimType= trimType;
        }
        public TrimType TrimType { get; set; }
        
    }
}
