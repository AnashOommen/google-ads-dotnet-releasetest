// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagve = Google.Ads.GoogleAds.V11.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAudienceInsightsServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void GenerateInsightsFinderReportRequestObject()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            GenerateInsightsFinderReportRequest request = new GenerateInsightsFinderReportRequest
            {
                CustomerId = "customer_id3b3724cb",
                BaselineAudience = new BasicInsightsAudience(),
                SpecificAudience = new BasicInsightsAudience(),
                CustomerInsightsGroup = "customer_insights_groupee7d0741",
            };
            GenerateInsightsFinderReportResponse expectedResponse = new GenerateInsightsFinderReportResponse
            {
                SavedReportUrl = "saved_report_url8574fd0f",
            };
            mockGrpcClient.Setup(x => x.GenerateInsightsFinderReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateInsightsFinderReportResponse response = client.GenerateInsightsFinderReport(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task GenerateInsightsFinderReportRequestObjectAsync()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            GenerateInsightsFinderReportRequest request = new GenerateInsightsFinderReportRequest
            {
                CustomerId = "customer_id3b3724cb",
                BaselineAudience = new BasicInsightsAudience(),
                SpecificAudience = new BasicInsightsAudience(),
                CustomerInsightsGroup = "customer_insights_groupee7d0741",
            };
            GenerateInsightsFinderReportResponse expectedResponse = new GenerateInsightsFinderReportResponse
            {
                SavedReportUrl = "saved_report_url8574fd0f",
            };
            mockGrpcClient.Setup(x => x.GenerateInsightsFinderReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateInsightsFinderReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateInsightsFinderReportResponse responseCallSettings = await client.GenerateInsightsFinderReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateInsightsFinderReportResponse responseCancellationToken = await client.GenerateInsightsFinderReportAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void GenerateInsightsFinderReport()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            GenerateInsightsFinderReportRequest request = new GenerateInsightsFinderReportRequest
            {
                CustomerId = "customer_id3b3724cb",
                BaselineAudience = new BasicInsightsAudience(),
                SpecificAudience = new BasicInsightsAudience(),
            };
            GenerateInsightsFinderReportResponse expectedResponse = new GenerateInsightsFinderReportResponse
            {
                SavedReportUrl = "saved_report_url8574fd0f",
            };
            mockGrpcClient.Setup(x => x.GenerateInsightsFinderReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateInsightsFinderReportResponse response = client.GenerateInsightsFinderReport(request.CustomerId, request.BaselineAudience, request.SpecificAudience);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task GenerateInsightsFinderReportAsync()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            GenerateInsightsFinderReportRequest request = new GenerateInsightsFinderReportRequest
            {
                CustomerId = "customer_id3b3724cb",
                BaselineAudience = new BasicInsightsAudience(),
                SpecificAudience = new BasicInsightsAudience(),
            };
            GenerateInsightsFinderReportResponse expectedResponse = new GenerateInsightsFinderReportResponse
            {
                SavedReportUrl = "saved_report_url8574fd0f",
            };
            mockGrpcClient.Setup(x => x.GenerateInsightsFinderReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateInsightsFinderReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            GenerateInsightsFinderReportResponse responseCallSettings = await client.GenerateInsightsFinderReportAsync(request.CustomerId, request.BaselineAudience, request.SpecificAudience, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateInsightsFinderReportResponse responseCancellationToken = await client.GenerateInsightsFinderReportAsync(request.CustomerId, request.BaselineAudience, request.SpecificAudience, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void ListAudienceInsightsAttributesRequestObject()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            ListAudienceInsightsAttributesRequest request = new ListAudienceInsightsAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Dimensions =
                {
                    gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension.Unspecified,
                },
                QueryText = "query_text3b0c4d80",
                CustomerInsightsGroup = "customer_insights_groupee7d0741",
            };
            ListAudienceInsightsAttributesResponse expectedResponse = new ListAudienceInsightsAttributesResponse
            {
                Attributes =
                {
                    new AudienceInsightsAttributeMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAudienceInsightsAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            ListAudienceInsightsAttributesResponse response = client.ListAudienceInsightsAttributes(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task ListAudienceInsightsAttributesRequestObjectAsync()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            ListAudienceInsightsAttributesRequest request = new ListAudienceInsightsAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Dimensions =
                {
                    gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension.Unspecified,
                },
                QueryText = "query_text3b0c4d80",
                CustomerInsightsGroup = "customer_insights_groupee7d0741",
            };
            ListAudienceInsightsAttributesResponse expectedResponse = new ListAudienceInsightsAttributesResponse
            {
                Attributes =
                {
                    new AudienceInsightsAttributeMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAudienceInsightsAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListAudienceInsightsAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            ListAudienceInsightsAttributesResponse responseCallSettings = await client.ListAudienceInsightsAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListAudienceInsightsAttributesResponse responseCancellationToken = await client.ListAudienceInsightsAttributesAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void ListAudienceInsightsAttributes()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            ListAudienceInsightsAttributesRequest request = new ListAudienceInsightsAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Dimensions =
                {
                    gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension.Unspecified,
                },
                QueryText = "query_text3b0c4d80",
            };
            ListAudienceInsightsAttributesResponse expectedResponse = new ListAudienceInsightsAttributesResponse
            {
                Attributes =
                {
                    new AudienceInsightsAttributeMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAudienceInsightsAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            ListAudienceInsightsAttributesResponse response = client.ListAudienceInsightsAttributes(request.CustomerId, request.Dimensions, request.QueryText);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task ListAudienceInsightsAttributesAsync()
        {
            moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient> mockGrpcClient = new moq::Mock<AudienceInsightsService.AudienceInsightsServiceClient>(moq::MockBehavior.Strict);
            ListAudienceInsightsAttributesRequest request = new ListAudienceInsightsAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Dimensions =
                {
                    gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension.Unspecified,
                },
                QueryText = "query_text3b0c4d80",
            };
            ListAudienceInsightsAttributesResponse expectedResponse = new ListAudienceInsightsAttributesResponse
            {
                Attributes =
                {
                    new AudienceInsightsAttributeMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAudienceInsightsAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListAudienceInsightsAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AudienceInsightsServiceClient client = new AudienceInsightsServiceClientImpl(mockGrpcClient.Object, null);
            ListAudienceInsightsAttributesResponse responseCallSettings = await client.ListAudienceInsightsAttributesAsync(request.CustomerId, request.Dimensions, request.QueryText, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListAudienceInsightsAttributesResponse responseCancellationToken = await client.ListAudienceInsightsAttributesAsync(request.CustomerId, request.Dimensions, request.QueryText, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
