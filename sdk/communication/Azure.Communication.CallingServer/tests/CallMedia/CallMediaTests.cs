﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Communication.CallingServer
{
    public class CallMediaTests : CallAutomationTestBase
    {
        private static readonly IEnumerable<CommunicationIdentifier> _target = new CommunicationIdentifier[]
        {
            new CommunicationUserIdentifier("id")
        };
        private static readonly FileSource _fileSource = new FileSource(new System.Uri("file://path/to/file"));
        private static readonly PlayOptions _options = new PlayOptions()
        {
            Loop = false,
            OperationContext = "context"
        };
        private static readonly RecognizeOptions _recognizeConfigurations = new RecognizeOptions(new CommunicationUserIdentifier("targetUserId"))
        {
            InterruptPrompt = true,
            DtmfOptions = new DtmfOptions()
            {
                InterToneTimeoutInSeconds = TimeSpan.FromSeconds(10),
                MaxTonesToCollect = 5,
                StopTones = new DtmfTone[] { DtmfTone.Pound }
            },
            InitialSilenceTimeoutInSeconds = TimeSpan.FromSeconds(5),
        };

        private static CallMedia? _callMedia;

        [SetUp]
        public void Setup()
        {
            CallAutomationClient callAutomationClient = CreateMockCallAutomationClient(202);
            _callMedia = callAutomationClient.GetCallConnection("callConnectionId").GetCallMedia();
            _fileSource.PlaySourceId = "playSourceId";
        }

        [TestCaseSource(nameof(TestData_PlayOperationsAsync))]

        public async Task MediaOperationsAsync_Return202Accepted(Func<CallMedia, Task<Response>> operation)
        {
            if (_callMedia != null)
            {
                Response result = await operation(_callMedia);
                Assert.IsNotNull(result);
                Assert.AreEqual((int)HttpStatusCode.Accepted, result.Status);
            }
        }

        [TestCaseSource(nameof(TestData_PlayOperations))]

        public void MediaOperations_Return202Accepted(Func<CallMedia, Response> operation)
        {
            if (_callMedia != null)
            {
                Response result = operation(_callMedia);
                Assert.IsNotNull(result);
                Assert.AreEqual((int)HttpStatusCode.Accepted, result.Status);
            }
        }

        [TestCaseSource(nameof(TestData_PlayOperationsAsync))]
        public void MediaOperationsAsync_Return404NotFound(Func<CallMedia, Task<Response>> operation)
        {
            CallAutomationClient callAutomationClient = CreateMockCallAutomationClient(404);
            _callMedia = callAutomationClient.GetCallConnection("callConnectionId").GetCallMedia();

            RequestFailedException? ex = Assert.ThrowsAsync<RequestFailedException>(
                async () => await operation(_callMedia));
            Assert.NotNull(ex);
            Assert.AreEqual(ex?.Status, 404);
        }

        [TestCaseSource(nameof(TestData_PlayOperations))]
        public void MediaOperations_Return404NotFound(Func<CallMedia, Response> operation)
        {
            CallAutomationClient callAutomationClient = CreateMockCallAutomationClient(404);
            _callMedia = callAutomationClient.GetCallConnection("callConnectionId").GetCallMedia();

            RequestFailedException? ex = Assert.Throws<RequestFailedException>(
                () => operation(_callMedia));
            Assert.NotNull(ex);
            Assert.AreEqual(ex?.Status, 404);
        }

        private static IEnumerable<object?[]> TestData_PlayOperationsAsync()
        {
            return new[]
            {
                new Func<CallMedia, Task<Response>>?[]
                {
                   callMedia => callMedia.PlayAsync(_fileSource, _target, _options)
                },
                new Func<CallMedia, Task<Response>>?[]
                {
                   callMedia => callMedia.PlayToAllAsync(_fileSource, _options)
                },
                new Func<CallMedia, Task<Response>>?[]
                {
                   callMedia => callMedia.CancelAllMediaOperationsAsync()
                },
                new Func<CallMedia, Task<Response>>?[]
                {
                   callMedia => callMedia.RecognizeAsync(new CallMediaRecognizeOptions(RecognizeInputType.Dtmf, _recognizeConfigurations))
                }
            };
        }

        private static IEnumerable<object?[]> TestData_PlayOperations()
        {
            return new[]
            {
                new Func<CallMedia, Response>?[]
                {
                   callMedia => callMedia.Play(_fileSource, _target, _options)
                },
                new Func<CallMedia, Response>?[]
                {
                   callMedia => callMedia.PlayToAll(_fileSource, _options)
                },
                new Func<CallMedia, Response>?[]
                {
                   callMedia => callMedia.CancelAllMediaOperations()
                },
                new Func<CallMedia, Response>?[]
                {
                   callMedia => callMedia.Recognize(new CallMediaRecognizeOptions(RecognizeInputType.Dtmf, _recognizeConfigurations))
                }
            };
        }
    }
}
