using System;
using System.Collections.Generic;
using Data = Yatter.UI.ListBuilder.Framework;
using Component = Yatter.UI.Blazor.Components.ListItems;

namespace Yatter.UI.Blazor.Components.Framework
{
    public static class ComponentMetadataInfo
    {

        public static Dictionary<string, Data.ComponentMetadata> ComponentMetadataDictionary => _componentMetadata;

        private static readonly Dictionary<string, Data.ComponentMetadata> _componentMetadata =
            new()
            {
                {
                    "H1",
                    new Data.ComponentMetadata
                    {
                        Name = "H1",
                        Type = typeof(Component.H1)
                    }
                },
                {
                    "H2",
                    new Data.ComponentMetadata
                    {
                        Name = "H2",
                        Type = typeof(Component.H2)
                    }
                },
                {
                    "H3",
                    new Data.ComponentMetadata
                    {
                        Name = "H3",
                        Type = typeof(Component.H3)
                    }
                },
                {
                    "H4",
                    new Data.ComponentMetadata
                    {
                        Name = "H4",
                        Type = typeof(Component.H4)
                    }
                },
                {
                    "H5",
                    new Data.ComponentMetadata
                    {
                        Name = "H5",
                        Type = typeof(Component.H5)
                    }
                },
                {
                    "Label",
                    new Data.ComponentMetadata
                    {
                        Name = "Label",
                        Type = typeof(Component.Label)
                    }
                },
                {
                    "Base64Image",
                    new Data.ComponentMetadata
                    {
                        Name = "Base64Image",
                        Type = typeof(Component.Base64Image)
                    }
                },
                {
                    "Entry",
                    new Data.ComponentMetadata
                    {
                        Name = "Entry",
                        Type = typeof(Component.Entry)
                    }
                }
            };

    }
}

