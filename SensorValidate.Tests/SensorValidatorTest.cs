using System;
using System.Collections.Generic;

using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void reportsErrorWhenSOCjumps() {
            Assert.False(SensorValidator.ValidateSOCReadings(
                new List<double>{0.0, 0.01, 0.5, 0.51}
            ));
        }
        [Fact]
        public void reportsErrorWhenCurrentjumps() {
            Assert.False(SensorValidator.ValidateCurrentReadings(
                new List<double>{0.03, 0.03, 0.03, 0.33}
            ));
        }
        [Fact]
        public void WhenSOCReadingsHasNoValues()
        {
            Assert.Throws<ArgumentNullException>(() => SensorValidator.ValidateSOCReadings(
                null
            ));
        }
        [Fact]
        public void ErrorWhenCurrentReadingsHasNoValues()
        {
            Assert.Throws<ArgumentNullException>(() => SensorValidator.ValidateCurrentReadings(
                null
            ));
        }
    }
}
