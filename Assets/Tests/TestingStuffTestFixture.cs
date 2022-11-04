using System.Collections;
using NUnit.Framework;
[TestFixture]
public static class TestingStuffTestFixture
{
    public static IEnumerable TestingStuffSource {
        get {
            yield return new TestCaseData("Hello!!!");
            yield return new TestCaseData("World???");
        }
    }

    [Test, TestCaseSource(typeof(TestingStuffTestFixture), nameof(TestingStuffSource))]
    public static void WithFixture(string testString) {
        Assert.True(true, $"TestingStuff: {testString}");
    }
}