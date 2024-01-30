using Xunit;
using API;

public class StartupTests
{
    private readonly Startup _startup;

    public StartupTests()
    {
        _startup = new Startup();
    }

    [Theory]
    [InlineData("abc", "dgf")]
    [InlineData("ABC", "DGF")]
    [InlineData("123", "123")]

    
    
    
    public void Encrypt_GivenValidInput_ReturnsExpectedOutput(string input, string expectedOutput)
    {
        string result = _startup.Encrypt(input);
        Assert.Equal(expectedOutput, result);
    }

    [Theory]
    [InlineData("dgf", "abc")]
    [InlineData("DGF", "ABC")]
    [InlineData("123", "123")]

    
    public void Decrypt_GivenValidInput_ReturnsExpectedOutput(string input, string expectedOutput)
    {
        string result = _startup.Decrypt(input);
        Assert.Equal(expectedOutput, result);
    }
}
