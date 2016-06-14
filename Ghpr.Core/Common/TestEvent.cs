﻿using System;
using Ghpr.Core.Interfaces;
using Newtonsoft.Json;

namespace Ghpr.Core.Common
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TestEvent : ITestEvent
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public DateTime Started { get; set; }
        [JsonProperty]
        public DateTime Finished { get; set; }

        public double Duration => (Finished - Started).TotalSeconds;
        public string DurationString => (Finished - Started).ToString(@"hh\:mm\:ss\:fff");

        public TestEvent()
        {
            Name = "";
            Started = default(DateTime);
            Finished = default(DateTime);
        }

        public TestEvent(string eventName = "", DateTime started = default(DateTime), DateTime finished = default(DateTime))
        {
            Name = eventName;
            Started = started;
            Finished = finished;
        }
    }
}