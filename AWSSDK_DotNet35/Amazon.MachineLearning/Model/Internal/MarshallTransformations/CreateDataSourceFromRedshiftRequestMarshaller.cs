/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataSourceFromRedshift Request Marshaller
    /// </summary>       
    public class CreateDataSourceFromRedshiftRequestMarshaller : IMarshaller<IRequest, CreateDataSourceFromRedshiftRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataSourceFromRedshiftRequest)input);
        }

        public IRequest Marshall(CreateDataSourceFromRedshiftRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MachineLearning");
            string target = "AmazonML_20141212.CreateDataSourceFromRedshift";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeStatistics())
                {
                    context.Writer.WritePropertyName("ComputeStatistics");
                    context.Writer.Write(publicRequest.ComputeStatistics);
                }

                if(publicRequest.IsSetDataSourceId())
                {
                    context.Writer.WritePropertyName("DataSourceId");
                    context.Writer.Write(publicRequest.DataSourceId);
                }

                if(publicRequest.IsSetDataSourceName())
                {
                    context.Writer.WritePropertyName("DataSourceName");
                    context.Writer.Write(publicRequest.DataSourceName);
                }

                if(publicRequest.IsSetDataSpec())
                {
                    context.Writer.WritePropertyName("DataSpec");
                    context.Writer.WriteObjectStart();

                    var marshaller = RedshiftDataSpecMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSpec, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleARN())
                {
                    context.Writer.WritePropertyName("RoleARN");
                    context.Writer.Write(publicRequest.RoleARN);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}