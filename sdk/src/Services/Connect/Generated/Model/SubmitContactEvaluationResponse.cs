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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the SubmitContactEvaluation operation.
    /// </summary>
    public partial class SubmitContactEvaluationResponse : AmazonWebServiceResponse
    {
        private string _evaluationArn;
        private string _evaluationId;

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact evaluation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluationArn
        {
            get { return this._evaluationArn; }
            set { this._evaluationArn = value; }
        }

        // Check to see if EvaluationArn property is set
        internal bool IsSetEvaluationArn()
        {
            return this._evaluationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A unique identifier for the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string EvaluationId
        {
            get { return this._evaluationId; }
            set { this._evaluationId = value; }
        }

        // Check to see if EvaluationId property is set
        internal bool IsSetEvaluationId()
        {
            return this._evaluationId != null;
        }

    }
}