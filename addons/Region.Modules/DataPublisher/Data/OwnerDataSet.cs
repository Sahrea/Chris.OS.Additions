﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chris.OS.Additions.Region.Modules.DataPublisher.Data
{
    class OwnerDataSet
    {
        [JsonProperty(PropertyName = "Name")]
        public String OwnerName = "";

        [JsonProperty(PropertyName = "UUID")]
        public String OwnerUUID = "";

        [JsonProperty(PropertyName = "HomeURI")]
        public String OwnerHomeURI = "";
    }
}
