﻿//
// Copyright (c) 2010-2011 Jeff Wilcox
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;

namespace JeffWilcox.FourthAndMayor
{
    using System.Globalization;

    public static class UnixDate
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static string ToString(DateTimeOffset time)
        {
            var ts = (TimeSpan)(time - UnixEpoch);
            return Convert.ToInt64(ts.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTime(string unixSecondsAsString)
        {
            ulong ul;
            if (ulong.TryParse(unixSecondsAsString, out ul))
            {
                return UnixEpoch.Add(TimeSpan.FromSeconds(ul));
            }
            else
            {
                DateTime dt;

                if (DateTime.TryParse(unixSecondsAsString, out dt))
                {
                    return dt;
                }
            }

            return DateTime.MinValue;
        }
    }
}
