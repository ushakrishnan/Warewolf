﻿using System.Collections.Generic;
using System.Diagnostics;
using Dev2.Common;
using Dev2.Common.Interfaces.Monitoring;
using System;

namespace Dev2.PerformanceCounters.Counters
{
    public class WarewolfCurrentExecutionsPerformanceCounter : IPerformanceCounter, IDisposable
    {

        PerformanceCounter _counter;
        bool _started;
        readonly WarewolfPerfCounterType _perfCounterType;

        public WarewolfCurrentExecutionsPerformanceCounter()
        {
            _started = false;
            IsActive = true;
            _perfCounterType = WarewolfPerfCounterType.ConcurrentRequests;
        }

        public WarewolfPerfCounterType PerfCounterType => _perfCounterType;

        public IList<CounterCreationData> CreationData()
        {

            var totalOps = new CounterCreationData
            {
                CounterName = Name,
                CounterHelp = Name,
                CounterType = PerformanceCounterType.NumberOfItems32

            };
            return new[] { totalOps };
        }

        public bool IsActive { get; set; }
        public void Reset()
        {
            if (_counter != null)
            {
                _counter.RawValue = 0;
            }
        }
        #region Implementation of IPerformanceCounter

        public void Increment()
        {
   
                if (IsActive)
            {
                _counter.Increment();
            }
        }

        public void IncrementBy(long ticks)
        {

            if(IsActive)
            {
                _counter.IncrementBy(ticks);
            }
        }

        public void Setup()
        {
            if (!_started)
            {
                _counter = new PerformanceCounter(GlobalConstants.Warewolf, Name, GlobalConstants.GlobalCounterName)
                {
                    MachineName = ".",
                    ReadOnly = false,
                    InstanceLifetime = PerformanceCounterInstanceLifetime.Global
                };
                _started = true;
            }
        }

        public void Decrement()
        {

            if (IsActive && _counter.RawValue > 0)
            {

                _counter.Decrement();
            }

        }

        public void Dispose()
        {
            _counter.Dispose();
        }

        public string Category => "Warewolf";
        public string Name => "Concurrent requests currently executing";

        #endregion
    }
}

