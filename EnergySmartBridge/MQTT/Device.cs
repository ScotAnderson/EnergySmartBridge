﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySmartBridge.MQTT
{
    public class Device
    {
        public string name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string state_topic { get; set; }

        public string availability_topic { get; set; } = "energysmart/status";
    }
}
