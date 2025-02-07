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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the CreateAPIKey operation.
    /// </summary>
    public partial class CreateAPIKeyResponse : AmazonWebServiceResponse
    {
        private string _apiKey;

        /// <summary>
        /// Gets and sets the property APIKey. 
        /// <para>
        /// The generated, encrypted API key. You can copy this for use in your JavaScript CAPTCHA
        /// integration. 
        /// </para>
        ///  
        /// <para>
        /// For information about how to use this in your CAPTCHA JavaScript integration, see
        /// <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string APIKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if APIKey property is set
        internal bool IsSetAPIKey()
        {
            return this._apiKey != null;
        }

    }
}