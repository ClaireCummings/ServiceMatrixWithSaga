using System;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;
using NServiceBus.Saga;


namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsProcessor : Saga<SubmitEdrsProcessorSagaData>, IAmStartedByMessages<SubmitEdrs>
    {
		
		public void Handle(SubmitEdrs message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitEdrs message);
     }

     public partial class SubmitEdrsProcessorSagaData : IContainSagaData
     {
           public virtual Guid Id { get; set; }
           public virtual string Originator { get; set; }
           public virtual string OriginalMessageId { get; set; }


    }
}
