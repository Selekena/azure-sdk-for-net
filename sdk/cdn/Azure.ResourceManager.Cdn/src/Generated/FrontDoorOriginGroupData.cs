// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the FrontDoorOriginGroup data model. </summary>
    public partial class FrontDoorOriginGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of FrontDoorOriginGroupData. </summary>
        public FrontDoorOriginGroupData()
        {
        }

        /// <summary> Initializes a new instance of FrontDoorOriginGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="profileName"> The name of the profile which holds the origin group. </param>
        /// <param name="loadBalancingSettings"> Load balancing settings for a backend pool. </param>
        /// <param name="healthProbeSettings"> Health probe settings to the origin that is used to determine the health of the origin. </param>
        /// <param name="trafficRestorationTimeInMinutes"> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </param>
        /// <param name="sessionAffinityState"> Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        internal FrontDoorOriginGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string profileName, LoadBalancingSettings loadBalancingSettings, HealthProbeSettings healthProbeSettings, int? trafficRestorationTimeInMinutes, EnabledState? sessionAffinityState, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus) : base(id, name, resourceType, systemData)
        {
            ProfileName = profileName;
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            TrafficRestorationTimeInMinutes = trafficRestorationTimeInMinutes;
            SessionAffinityState = sessionAffinityState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
        }

        /// <summary> The name of the profile which holds the origin group. </summary>
        public string ProfileName { get; }
        /// <summary> Load balancing settings for a backend pool. </summary>
        public LoadBalancingSettings LoadBalancingSettings { get; set; }
        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeSettings HealthProbeSettings { get; set; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeInMinutes { get; set; }
        /// <summary> Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? SessionAffinityState { get; set; }
        /// <summary> Provisioning status. </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
    }
}
