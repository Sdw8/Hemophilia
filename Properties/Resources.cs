using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Hemophilia.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Hemophilia.Properties.Resources.resourceMan == null)
                    Hemophilia.Properties.Resources.resourceMan = new ResourceManager("Hemophilia.Properties.Resources", typeof(Hemophilia.Properties.Resources).Assembly);
                return Hemophilia.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => Hemophilia.Properties.Resources.resourceCulture;
            set => Hemophilia.Properties.Resources.resourceCulture = value;
        }
    }
}
