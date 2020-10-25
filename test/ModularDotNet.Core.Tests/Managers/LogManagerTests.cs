using System;
using ModularDotNet.Core.Managers;
using Serilog;
using Serilog.Sinks.TestCorrelator;
using Xunit;

namespace ModularDotNet.Core.Tests.Managers
{
    public class LogManagerTests
    {
        #region Fields

        private static Random _Seed = new Random();

        #endregion

        #region Constructor

        public LogManagerTests()
        {
            LogManager.GetConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.TestCorrelator();
        }

        #endregion

        #region Methods

        [Fact]
        public void LogManager_WriteVerbose()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (var context = TestCorrelator.CreateContext())
            {
                LogManager.Verbose(randomString);
                
                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Verbose
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        [Fact]
        public void LogManager_WriteDebug()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (TestCorrelator.CreateContext())
            {
                LogManager.Debug(randomString);

                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Debug
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        [Fact]
        public void LogManager_WriteInformation()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (TestCorrelator.CreateContext())
            {
                LogManager.Information(randomString);

                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Information
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        [Fact]
        public void LogManager_WriteWarning()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (TestCorrelator.CreateContext())
            {
                LogManager.Warning(randomString);

                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Warning
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        [Fact]
        public void LogManager_WriteError()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (TestCorrelator.CreateContext())
            {
                LogManager.Error(randomString);

                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Error
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        [Fact]
        public void LogManager_WriteFatal()
        {
            var randomString = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true, true, true, true, true, true, true);

            using (TestCorrelator.CreateContext())
            {
                LogManager.Fatal(randomString);

                Assert.Collection(TestCorrelator.GetLogEventsFromCurrentContext(), item =>
                {
                    Assert.True(item.Level == Serilog.Events.LogEventLevel.Fatal
                        && item.MessageTemplate.Text.Equals(randomString));
                });
            }
        }

        #endregion
    }
}
