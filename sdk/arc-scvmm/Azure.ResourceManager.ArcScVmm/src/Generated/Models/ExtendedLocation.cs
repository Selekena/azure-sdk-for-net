// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> The extended location. </summary>
    public partial class ExtendedLocation
    {
        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        public ExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        /// <param name="extendedLocationType"> The extended location type. </param>
        /// <param name="name"> The extended location name. </param>
        internal ExtendedLocation(string extendedLocationType, string name)
        {
            ExtendedLocationType = extendedLocationType;
            Name = name;
        }

        /// <summary> The extended location type. </summary>
        public string ExtendedLocationType { get; set; }
        /// <summary> The extended location name. </summary>
        public string Name { get; set; }
    }
}
