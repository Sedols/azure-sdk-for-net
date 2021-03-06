// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The InfluxDBDataFeedPatch. </summary>
    internal partial class InfluxDBDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of InfluxDBDataFeedPatch. </summary>
        public InfluxDBDataFeedPatch()
        {
            DataSourceType = DataFeedDetailPatchDataSourceType.InfluxDB;
        }

        public InfluxDBParameter DataSourceParameter { get; set; }
    }
}
