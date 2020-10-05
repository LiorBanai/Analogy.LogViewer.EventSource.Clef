using System;
using System.Collections.Generic;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;

namespace Analogy.LogViewer.EventSource.Clef
{
    public class EventSourceProviderFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; set; } = EventSourceFactory.Id;
        public string Title { get; set; } = "Clef EventSource Provider";

        public IEnumerable<IAnalogyDataProvider> DataProviders => new List<IAnalogyDataProvider>
        {
            new EventSourceDataProvider(),
        };
    }
}
