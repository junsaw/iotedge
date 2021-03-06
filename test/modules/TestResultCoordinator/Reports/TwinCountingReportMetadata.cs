// Copyright (c) Microsoft. All rights reserved.
namespace TestResultCoordinator.Reports
{
    using Microsoft.Azure.Devices.Edge.ModuleUtil;

    class TwinCountingReportMetadata : CountingReportMetadata
    {
        public TwinCountingReportMetadata(string expectedSource, string actualSource, TestReportType testReportType, TwinTestPropertyType twinTestPropertyType)
            : base(expectedSource, actualSource, TestOperationResultType.Twin, testReportType)
        {
            this.TwinTestPropertyType = twinTestPropertyType;
        }

        public TwinTestPropertyType TwinTestPropertyType { get; }
    }
}
