using System.Collections.ObjectModel;

namespace Futura.SignalR.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Futura.SignalR.Areas.HelpPage.ModelDescriptions.ModelDescription" />
    public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}