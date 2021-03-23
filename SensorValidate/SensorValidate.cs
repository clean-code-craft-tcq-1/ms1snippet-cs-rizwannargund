using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        private static bool IsValueSuddenJumped(double value, double maxDelta) => !(value > maxDelta);
        public static bool ValidateSOCReadings(List<Double> values) => IsAnyValueSuddenJumped(values ?? throw new ArgumentNullException("values cannot be null."), 0.05);
        public static bool ValidateCurrentReadings(List<Double> values) => IsAnyValueSuddenJumped(values ?? throw new ArgumentNullException("values cannot be null."), 0.1);
        private static bool IsAnyValueSuddenJumped(List<Double> values, double maxDelta)
        {
            for (int i = 0; i < (values.Count - 1); i++)
            {
                if (!IsValueSuddenJumped(values[i + 1] - values[i], maxDelta))
                    return false;
            }
            return true;
        }

    }
}
