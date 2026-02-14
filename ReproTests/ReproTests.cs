using Xunit;
using TestHelper;

namespace ReproTests;

public class ReproTests
{
    [Theory]
    [MemberData(nameof(Class1.Languages), MemberType = typeof(Class1))]
    public async Task Test(string locale)
    {
    }
}