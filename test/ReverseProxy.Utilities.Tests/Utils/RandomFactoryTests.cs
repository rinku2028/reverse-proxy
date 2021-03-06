﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using FluentAssertions;
using Xunit;

namespace Microsoft.ReverseProxy.Utilities
{
    public class RandomFactoryTests
    {
        [Fact]
        public void RandomFactory_Work()
        {
            // Set up the factory.
            var factory = new RandomFactory();

            // Create random class object.
            var random = factory.CreateRandomInstance();

            // Validate.
            random.Should().NotBeNull();
            random.GetType().Should().Be(typeof(RandomWrapper));

            // Validate functionality
            var num = random.Next(5);
            num.Should().BeInRange(0, 5);
        }
    }
}
