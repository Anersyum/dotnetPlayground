﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace DictionaryVsHashset;

public sealed class Config : ManualConfig
{
    public Config() => AddJob(Job.MediumRun.WithToolchain(InProcessNoEmitToolchain.Instance));
}
