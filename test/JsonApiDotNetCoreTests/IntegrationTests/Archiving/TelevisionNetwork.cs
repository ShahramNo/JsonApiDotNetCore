using System.Collections.Generic;
using JetBrains.Annotations;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApiDotNetCoreTests.IntegrationTests.Archiving
{
    [UsedImplicitly(ImplicitUseTargetFlags.Members)]
    public sealed class TelevisionNetwork : Identifiable
    {
        [Attr]
        public string Name { get; set; }

        [HasMany]
        public ISet<TelevisionStation> Stations { get; set; }
    }
}