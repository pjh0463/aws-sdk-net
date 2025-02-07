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
    /// The model registry settings for the SageMaker Canvas application.
    /// </summary>
    public partial class ModelRegisterSettings
    {
        private string _crossAccountModelRegisterRoleArn;
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property CrossAccountModelRegisterRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only
        /// to register model versions created by a different SageMaker Canvas AWS account than
        /// the AWS account in which SageMaker model registry is set up.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CrossAccountModelRegisterRoleArn
        {
            get { return this._crossAccountModelRegisterRoleArn; }
            set { this._crossAccountModelRegisterRoleArn = value; }
        }

        // Check to see if CrossAccountModelRegisterRoleArn property is set
        internal bool IsSetCrossAccountModelRegisterRoleArn()
        {
            return this._crossAccountModelRegisterRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether the integration to the model registry is enabled or disabled in
        /// the Canvas application.
        /// </para>
        /// </summary>
        public FeatureStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}