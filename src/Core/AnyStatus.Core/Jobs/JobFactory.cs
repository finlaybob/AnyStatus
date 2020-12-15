﻿using Quartz;
using Quartz.Spi;
using System;

namespace AnyStatus.Core.Jobs
{
    public class JobFactory : IJobFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public JobFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            return (IJob)_serviceProvider.GetService(typeof(IJob));
        }

        public void ReturnJob(IJob job) { }
    }
}
