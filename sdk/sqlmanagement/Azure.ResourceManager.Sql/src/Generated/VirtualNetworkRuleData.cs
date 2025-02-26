// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the VirtualNetworkRule data model. </summary>
    public partial class VirtualNetworkRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkRuleData. </summary>
        public VirtualNetworkRuleData()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkSubnetId"> The ARM resource id of the virtual network subnet. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Create firewall rule before the virtual network has vnet service endpoint enabled. </param>
        /// <param name="state"> Virtual Network Rule State. </param>
        internal VirtualNetworkRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier virtualNetworkSubnetId, bool? ignoreMissingVnetServiceEndpoint, VirtualNetworkRuleState? state) : base(id, name, resourceType, systemData)
        {
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            State = state;
        }

        /// <summary> The ARM resource id of the virtual network subnet. </summary>
        public ResourceIdentifier VirtualNetworkSubnetId { get; set; }
        /// <summary> Create firewall rule before the virtual network has vnet service endpoint enabled. </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
        /// <summary> Virtual Network Rule State. </summary>
        public VirtualNetworkRuleState? State { get; }
    }
}
