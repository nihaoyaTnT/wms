﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nodes.Entities.HttpEntity.CycleCount
{
    public class JsonListChangedLocations:BaseResult
    {
        public JsonListChangedLocationsResult[] result { get; set; }
    }
}
