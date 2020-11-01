using System;
using Serilog;

namespace ModularDotNet.Core.Managers
{
    public static class LogManager
    {
        #region Properties

        private static ILogger _Logger { get; set; }

        private static LoggerConfiguration _LoggerConfiguration { get; }

        #endregion

        #region Constructor

        static LogManager()
        {
            _LoggerConfiguration = new LoggerConfiguration(); // NOSONAR
        }

        #endregion

        #region Methods

        private static void CreateLoggerIfNotExist()
        {
            if (_Logger != null)
            {
                return;
            }

            _Logger = _LoggerConfiguration.CreateLogger();
            Log.Logger = _Logger;
        }

        public static void End()
        {
            Log.CloseAndFlush();
        }

        public static LoggerConfiguration GetConfiguration()
        {
            return _LoggerConfiguration;
        }

        public static void Verbose(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Verbose(messageTemplate);
        }

        public static void Verbose(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Verbose(exception, messageTemplate);
        }

        public static void Verbose(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Verbose(messageTemplate, propertyValues);
        }

        public static void Verbose(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Verbose(exception, messageTemplate, propertyValues);
        }

        public static void Verbose<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T>(messageTemplate, propertyValue);
        }

        public static void Verbose<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T>(exception, messageTemplate, propertyValue);
        }

        public static void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Verbose<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Verbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Verbose<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Verbose<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Debug(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Debug(messageTemplate);
        }

        public static void Debug(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Debug(exception, messageTemplate);
        }

        public static void Debug(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Debug(messageTemplate, propertyValues);
        }

        public static void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Debug(exception, messageTemplate, propertyValues);
        }

        public static void Debug<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T>(messageTemplate, propertyValue);
        }

        public static void Debug<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T>(exception, messageTemplate, propertyValue);
        }

        public static void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Debug<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Information(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Information(messageTemplate);
        }

        public static void Information(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Information(exception, messageTemplate);
        }

        public static void Information(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Information(messageTemplate, propertyValues);
        }

        public static void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Information(exception, messageTemplate, propertyValues);
        }

        public static void Information<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Information<T>(messageTemplate, propertyValue);
        }

        public static void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Information<T>(exception, messageTemplate, propertyValue);
        }

        public static void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Information<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Information<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Information<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Information<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Warning(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Warning(messageTemplate);
        }

        public static void Warning(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Warning(exception, messageTemplate);
        }

        public static void Warning(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Warning(messageTemplate, propertyValues);
        }

        public static void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Warning(exception, messageTemplate, propertyValues);
        }

        public static void Warning<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T>(messageTemplate, propertyValue);
        }

        public static void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T>(exception, messageTemplate, propertyValue);
        }

        public static void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Warning<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Error(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Error(messageTemplate);
        }

        public static void Error(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Error(exception, messageTemplate);
        }

        public static void Error(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Error(messageTemplate, propertyValues);
        }

        public static void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Error(exception, messageTemplate, propertyValues);
        }

        public static void Error<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Error<T>(messageTemplate, propertyValue);
        }

        public static void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Error<T>(exception, messageTemplate, propertyValue);
        }

        public static void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Error<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Error<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Error<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Error<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Fatal(string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Fatal(messageTemplate);
        }

        public static void Fatal(Exception exception, string messageTemplate)
        {
            CreateLoggerIfNotExist();
            Log.Fatal(exception, messageTemplate);
        }

        public static void Fatal(string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Fatal(messageTemplate, propertyValues);
        }

        public static void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            CreateLoggerIfNotExist();
            Log.Fatal(exception, messageTemplate, propertyValues);
        }

        public static void Fatal<T>(string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T>(messageTemplate, propertyValue);
        }

        public static void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T>(exception, messageTemplate, propertyValue);
        }

        public static void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T0, T1>(messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T0, T1>(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public static void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T0, T1, T2>(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public static void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            CreateLoggerIfNotExist();
            Log.Fatal<T0, T1, T2>(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        #endregion
    }
}
