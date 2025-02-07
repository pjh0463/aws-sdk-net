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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the ListExecutions operation.
    /// </summary>
    public partial class ListExecutionsResponse : AmazonWebServiceResponse
    {
        private List<ListedExecution> _executions = new List<ListedExecution>();
        private string _nextToken;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property Executions. 
        /// <para>
        /// Returns the details for each execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NextToken</b>: returned from a call to several APIs, you can use pass it to a
        /// subsequent command to continue listing additional executions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>StartTime</b>: timestamp indicating when the execution began.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Executions</b>: details of the execution, including the execution ID, initial
        /// file location, and Service metadata.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Status</b>: one of the following values: <code>IN_PROGRESS</code>, <code>COMPLETED</code>,
        /// <code>EXCEPTION</code>, <code>HANDLING_EXEPTION</code>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedExecution> Executions
        {
            get { return this._executions; }
            set { this._executions = value; }
        }

        // Check to see if Executions property is set
        internal bool IsSetExecutions()
        {
            return this._executions != null && this._executions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  <code>ListExecutions</code> returns the <code>NextToken</code> parameter in the output.
        /// You can then pass the <code>NextToken</code> parameter in a subsequent command to
        /// continue listing additional executions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// A unique identifier for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}