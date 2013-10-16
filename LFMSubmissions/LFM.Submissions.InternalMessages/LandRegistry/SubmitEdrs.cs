using System;
using NServiceBus;

namespace LFMSubmissions.InternalMessages.LandRegistry
{
    public class SubmitEdrs
    {
        public string ApplicationId { get; set; }
    }
}
