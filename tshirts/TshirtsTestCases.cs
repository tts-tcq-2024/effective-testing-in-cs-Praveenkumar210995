using Xunit;
using TshirtSpace;

public class TshirtTestCases
{  
    [Fact]
    public void InputLessThan_38_ShouldReturn_S_Size() 
    {
        int input = 37;
        string result = Tshirt.Size(input);
        Assert.Equal("S", result);
    }

    [Fact]
    public void InputBetween_38and40_ShouldReturn_M_Size() 
    {
        int input = 40;
        string result = Tshirt.Size(input);
        Assert.Equal("M", result);
    }

    [Fact]
    public void InputGreaterThan_42_ShouldReturn_L_Size() 
    {
        int input = 43;
        string result = Tshirt.Size(input);
        Assert.Equal("L", result);
    }

    [Fact]
    public void HandleEdgeCaseofSize_38() 
    {
        int input = 38;
        string result = Tshirt.Size(input);
        Assert.Equal("M", result);
    }
}
