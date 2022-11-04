using System.Collections;
using NUnit.Framework;
public static class TestingStuffNoTestFixture
{
    public static IEnumerable TestingStuffSource {
        get {
            yield return new TestCaseData("Hello!!!");
            yield return new TestCaseData("World???");
        }
    }

    [Test, TestCaseSource(typeof(TestingStuffNoTestFixture), nameof(TestingStuffSource))]
    public static void NoFixture(string testString) {
        Assert.True(true, $"TestingStuff: {testString}");
    }
}