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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsOpenSearchServiceDomainDetails Object
    /// </summary>  
    public class AwsOpenSearchServiceDomainDetailsUnmarshaller : IUnmarshaller<AwsOpenSearchServiceDomainDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsOpenSearchServiceDomainDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsOpenSearchServiceDomainDetails IUnmarshaller<AwsOpenSearchServiceDomainDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsOpenSearchServiceDomainDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsOpenSearchServiceDomainDetails unmarshalledObject = new AwsOpenSearchServiceDomainDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessPolicies", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterConfig", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainClusterConfigDetailsUnmarshaller.Instance;
                    unmarshalledObject.ClusterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainEndpointOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainDomainEndpointOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.DomainEndpointOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainEndpoints", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DomainEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionAtRestOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.EncryptionAtRestOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogPublishingOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainLogPublishingOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.LogPublishingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeToNodeEncryptionOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.NodeToNodeEncryptionOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceSoftwareOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.ServiceSoftwareOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcOptions", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainVpcOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.VpcOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsOpenSearchServiceDomainDetailsUnmarshaller _instance = new AwsOpenSearchServiceDomainDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsOpenSearchServiceDomainDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}