using System;
using System.Collections.Generic;
using Data = Yatter.UI.ListBuilder.Framework;
using Component = Yatter.UI.Blazor.Components.ListItems;

namespace Yatter.UI.Blazor.Components.Framework
{
    public class ComponentMetadataInfo
    {

        public List<Data.ComponentMetadata> GetLibraryComponentsMetadata()
        {
            var list = new List<Data.ComponentMetadata>();

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.H1).ToString(),    // The Parameters DTO namespace string
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.H1)          // The Custom Component Type (.razor)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.H2).ToString(),    
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.H2)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.H3).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.H3)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.H4).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.H4)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.H5).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.H5)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.Label).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.Label)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.Entry).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.Entry)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.Base64Image).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.Base64Image)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.TextPanel).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.TextPanel)
                });

            return list;
        }
    }
}

