﻿using System;
using GitHub.Services;
using Microsoft.TeamFoundation.Git.Controls.Extensibility;
using NSubstitute;
using Xunit;
using GitHub.Extensions;

public class URITests
{
    public class TheGetUserMethod
    {
        [Theory]
        [InlineData("git://test/athing", null)]
        [InlineData("git://test/user/athing", "user")]
        public void OnlyParsesUrlsWithThreeParts(string uri, string expected)
        {
            Assert.Equal(new Uri(uri).GetUser(), expected);
        }
    }

    public class TheGetRepoMethod
    {
        [Theory]
        [InlineData("git://test/athing", null)]
        [InlineData("git://test/user/athing", "athing")]
        public void OnlyParsesUrlsWithThreeParts(string uri, string expected)
        {
            Assert.Equal(new Uri(uri).GetRepo(), expected);
        }
    }
}