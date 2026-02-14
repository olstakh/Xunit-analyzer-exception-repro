using Xunit;

namespace TestHelper;

public static class Class1
{
    public static TheoryData<string> Languages =>
        new TheoryData<string>
            {
                { "en-US" },
                { "es-ES" },
            };
}
