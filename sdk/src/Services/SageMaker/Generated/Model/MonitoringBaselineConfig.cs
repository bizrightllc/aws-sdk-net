/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for monitoring constraints and monitoring statistics. These baseline
    /// resources are compared against the results of the current job from the series of jobs
    /// scheduled to collect data periodically.
    /// </summary>
    public partial class MonitoringBaselineConfig
    {
        private MonitoringConstraintsResource _constraintsResource;
        private MonitoringStatisticsResource _statisticsResource;

        /// <summary>
        /// Gets and sets the property ConstraintsResource. 
        /// <para>
        /// The baseline constraint file in Amazon S3 that the current monitoring job should validated
        /// against.
        /// </para>
        /// </summary>
        public MonitoringConstraintsResource ConstraintsResource
        {
            get { return this._constraintsResource; }
            set { this._constraintsResource = value; }
        }

        // Check to see if ConstraintsResource property is set
        internal bool IsSetConstraintsResource()
        {
            return this._constraintsResource != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticsResource. 
        /// <para>
        /// The baseline statistics file in Amazon S3 that the current monitoring job should be
        /// validated against.
        /// </para>
        /// </summary>
        public MonitoringStatisticsResource StatisticsResource
        {
            get { return this._statisticsResource; }
            set { this._statisticsResource = value; }
        }

        // Check to see if StatisticsResource property is set
        internal bool IsSetStatisticsResource()
        {
            return this._statisticsResource != null;
        }

    }
}