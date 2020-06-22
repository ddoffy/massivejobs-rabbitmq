﻿namespace MassiveJobs.RabbitMqBroker
{
    public static class Constants
    {
        public const string ExchangeName = "massivejobs.direct";

        public const string ImmediateQueueNameTemplate = "massivejobs.worker.{0:#00}";
        public const string ScheduledQueueNameTemplate = "massivejobs.scheduled.{0:#00}";
        public const string PeriodicQueueName = "massivejobs.periodic";
        public const string ErrorQueueName = "massivejobs.error";
        public const string FailedQueueName = "massivejobs.failed";
        public const string StatsQueueName = "massivejobs.stats";
    }
}
