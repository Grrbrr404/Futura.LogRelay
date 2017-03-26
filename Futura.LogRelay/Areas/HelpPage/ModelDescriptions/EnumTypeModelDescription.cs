using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Futura.SignalR.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Futura.SignalR.Areas.HelpPage.ModelDescriptions.ModelDescription" />
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}