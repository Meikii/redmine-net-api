﻿/*
   Copyright 2011 - 2019 Adrian Popescu.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Redmine.Net.Api.Types;
using Xunit;

namespace redmine.net.api.Tests.Tests.Sync
{
	[Trait("Redmine-Net-Api", "Trackers")]
	[Collection("RedmineCollection")]
    public class TrackerTests
    {
        public TrackerTests(RedmineFixture fixture)
        {
            this.fixture = fixture;
        }

        private readonly RedmineFixture fixture;

        [Fact]
        public void RedmineTrackers_ShouldGetAllTrackers()
        {
	        const int NUMBER_OF_TRACKERS = 2;

            var trackers = fixture.RedmineManager.GetObjects<Tracker>();

            Assert.NotNull(trackers);
            Assert.All(trackers, t => Assert.IsType<Tracker>(t));
            Assert.True(trackers.Count == NUMBER_OF_TRACKERS, "Trackers count(" + trackers.Count + ") != " + NUMBER_OF_TRACKERS);
        }
    }
}