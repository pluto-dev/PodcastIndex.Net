namespace PodcastIndex.Tests;

public class CreateAuthorizationTokenTest
{
    [InlineData("1", "1", "1", "6216f8a75fd5bb3d5f22b6f9958cdede3fc086c2")]
    [InlineData("0", "0", "0", "8aefb06c426e07a0a671a1e2488b4858d694a730")]
    [InlineData(
        "TQ2VG34817XO7BAWQP34",
        "%fze5jNSE6%6gpJZ!#H!N7sCtFH^P&vqQ$np*8%%W",
        "1049469820",
        "6b0875caca7d06e46f0af0b0f42f31929f5fa76b"
    )]
    [InlineData(
        "V72HC991TA2ZJEFRRUY3",
        "dQ!rgNwonQDJP!^HinkveH&*#eiTmu8M^&H5G$Xp4",
        "4722262107",
        "f1499d099d041852f8150bc47f1a839ce08e0ea7"
    )]
    [InlineData(
        "0N48NYRVVV0MR9GY9QUT",
        "E@^3rQMsoHiQsNAW&i%U$2@SjiFnnCT^4@hp7esdy",
        "8038265324",
        "0156587ba52be55397efc596f98c38f86b83bd1f"
    )]
    [InlineData(
        "DK2Z7Z4R7PJPUHTI0XBP",
        "CC#sAPUx#EK272c%$Zb8%k!ZX2D##4T6@qDM%jiJt",
        "0585954617",
        "4c0ad2225239214c3df71f110a851c2dbd94e532"
    )]
    [InlineData(
        "MLKW5FY1BNAU69TXVBO7",
        "xicxz3Q7Lc8&FJGX&@PWEHr2F!G%j$R*9o4b8QQ$x",
        "6603725656",
        "4b44813e0d73232c5f9a33ddd677801a7b59ed7f"
    )]
    [Theory]
    public void CreateAuthorizationToken_Should_ReturnsValidToken(
        string apiKey,
        string apiSecret,
        string timestamp,
        string expectedResult
    )
    {
        //  arrange
        //  act
        var token = Net.Helpers.CreateAuthorizationToken(apiKey, apiSecret, timestamp);

        // assert
        token.Should().Be(expectedResult);
    }

    [InlineData("", "99>", "8556350743")]
    [InlineData("", "X12", "")]
    [InlineData("X99", "", "4521796203")]
    [InlineData("BL3", "", "")]
    [InlineData("BL3", "X12", "")]
    [InlineData("", "", "4521796203")]
    [InlineData("", "", "")]
    [Theory]
    public void CreateAuthorizationToken_Should_Throws_ArgumentExceptions(
        string apiKey,
        string apiSecret,
        string timestamp
    )
    {
        //  arrange
        //  act
        var act = () => Net.Helpers.CreateAuthorizationToken(apiKey, apiSecret, timestamp);

        // assert
        act.Should().ThrowExactly<ArgumentException>();
    }
}