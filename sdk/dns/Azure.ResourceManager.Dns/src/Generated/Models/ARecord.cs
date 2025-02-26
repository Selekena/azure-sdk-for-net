// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> An A record. </summary>
    public partial class ARecord
    {
        /// <summary> Initializes a new instance of ARecord. </summary>
        public ARecord()
        {
        }

        /// <summary> Initializes a new instance of ARecord. </summary>
        /// <param name="iPv4Address"> The IPv4 address of this A record. </param>
        internal ARecord(string iPv4Address)
        {
            IPv4Address = iPv4Address;
        }

        /// <summary> The IPv4 address of this A record. </summary>
        public string IPv4Address { get; set; }
    }
}
