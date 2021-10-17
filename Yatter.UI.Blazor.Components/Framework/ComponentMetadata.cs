using System;
using System.Collections.Generic;
using Data = Yatter.UI.ListBuilder.Framework;
using Component = Yatter.UI.Blazor.Components.ListItems;

namespace Yatter.UI.Blazor.Components.Framework
{
    public class ComponentMetadataInfo
    {
        private static List<Data.ComponentMetadata> CustomComponents = new List<Data.ComponentMetadata>();

        public static void Add(Data.ComponentMetadata component)
        {
            CustomComponents.Add(component);
        }

        public List<Data.ComponentMetadata> GetLibraryComponentsMetadata()
        {
            var list = new List<Data.ComponentMetadata>();

            list.AddRange(CustomComponents);

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
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.IconTitle).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.IconTitle)
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

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.WebPage).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.WebPage)
                });

            list.Add(
                new Data.ComponentMetadata
                {
                    Name = typeof(Yatter.UI.ListBuilder.ListItems.YouTubeVideo).ToString(),
                    Type = typeof(Yatter.UI.Blazor.Components.ListItems.YouTubeVideo)
                });

            return list;
        }
    }
}

