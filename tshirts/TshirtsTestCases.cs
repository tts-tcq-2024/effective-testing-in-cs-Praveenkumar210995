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
    public void InputBetween_38and40_ShouldReturn_S_Size() 
    {
        int input = 40;
        string result = Tshirt.Size(input);
        Assert.Equal("M", result);
    }

    [Fact]
    public void Size_ShouldReturn_L_ForInputGreaterThan42() 
    {
        int input = 43;
        string result = Tshirt.Size(input);
        Assert.Equal("L", result);
    }

    [Fact]
    public void Size_ShouldHandleEdgeCaseOf38() 
    {
        int input = 38;
        string result = Tshirt.Size(input);
        Assert.Equal("L", result);
    }

    [Fact]
    public void Size_ShouldReturnM_ForBoundaryCase39() 
    {
        int input = 39;
        string result = Tshirt.Size(input);
        Assert.Equal("M", result);
    }
    
    [Fact]
    public void Size_ShouldReturnL_ForBoundaryCase42() 
    {
        int input = 42;
        string result = Tshirt.Size(input);
        Assert.Equal("L", result);
    }

}
