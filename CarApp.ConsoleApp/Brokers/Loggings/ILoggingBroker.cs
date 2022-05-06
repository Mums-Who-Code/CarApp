// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

namespace CarApp.ConsoleApp.Brokers.Loggings
{
    internal partial interface ILoggingBroker
    {
        void LogError(Exception exception);
    }
}