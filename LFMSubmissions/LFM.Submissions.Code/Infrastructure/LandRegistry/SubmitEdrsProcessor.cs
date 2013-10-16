using System;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsProcessor : IHandleMessages<SubmitEdrs>
    {
		
		public void Handle(SubmitEdrs message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitEdrs message);

		public IBus Bus { get; set; }

    }
}
