﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }

        [CascadingParameter(Name = "HeadingColor")]
        public string Color { get; set; }
    }
}
