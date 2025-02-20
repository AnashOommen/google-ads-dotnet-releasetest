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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupFeedServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAdGroupFeedsRequestObject()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupFeedsRequestObjectAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse responseCallSettings = await client.MutateAdGroupFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupFeedsResponse responseCancellationToken = await client.MutateAdGroupFeedsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAdGroupFeeds()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupFeedsAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse responseCallSettings = await client.MutateAdGroupFeedsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupFeedsResponse responseCancellationToken = await client.MutateAdGroupFeedsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
