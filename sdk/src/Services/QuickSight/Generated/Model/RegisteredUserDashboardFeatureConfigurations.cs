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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The feature configuration for an embedded dashboard.
    /// </summary>
    public partial class RegisteredUserDashboardFeatureConfigurations
    {
        private StatePersistenceConfigurations _statePersistence;

        /// <summary>
        /// Gets and sets the property StatePersistence. 
        /// <para>
        /// The state persistence settings of an embedded dashboard.
        /// </para>
        /// </summary>
        public StatePersistenceConfigurations StatePersistence
        {
            get { return this._statePersistence; }
            set { this._statePersistence = value; }
        }

        // Check to see if StatePersistence property is set
        internal bool IsSetStatePersistence()
        {
            return this._statePersistence != null;
        }

    }
}