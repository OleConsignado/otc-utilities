using System;
using Xunit;

namespace Otc.Utilities.Tests
{
    public class UtilitiesTests
    {
        [Theory]
        [InlineData(
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam auctor iaculis lorem vel commodo. Cras ut pretium erat. Ut eu sollicitudin diam. Nullam elementum leo ut elit imperdiet, commodo efficitur dui aliquet. Nam faucibus aliquam porta. Suspendisse laoreet rutrum est a accumsan. Vivamus aliquet lacus in enim tempor bibendum. Aliquam rhoncus posuere diam, ac congue dui tristique eu. Ut vitae quam nibh. Aliquam erat volutpat. Maecenas rutrum elementum dolor nec dignissim. Curabitur eu fermentum magna. Curabitur malesuada orci eu ullamcorper dapibus. Maecenas consequat elementum augue nec pretium. Nulla viverra egestas lacus, a blandit dolor semper vel. Aliquam erat volutpat. Ut molestie magna id quam efficitur lobortis. Cras porta enim et tellus vehicula, nec varius arcu egestas. Maecenas sollicitudin nisi eu lectus tristique tincidunt. Donec at enim condimentum diam mattis placerat a quis ipsum. Cras dolor est, efficitur in varius non, condimentum at risus. Duis congue vitae neque sed ullamcorper posuere.",
            50, "Lorem ipsum dolor sit amet, consec ... [TRUNCATED]")]
        [InlineData("", 50, "")]
        [InlineData(null, 50, null)]
        [InlineData("abcdefgh", 3, " ... [TRUNCATED]")]
        public void TestStringUtil_TruncateIfLengthExceeds(string input, int maxLength, string expected)
        {
            Assert.Equal(expected, StringUtil.TruncateIfLengthExceeds(input, maxLength));
        }
    }
}
