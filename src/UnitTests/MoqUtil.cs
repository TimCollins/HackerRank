using Domain.Interfaces;
using Moq;

namespace UnitTests
{
    internal class MoqUtil
    {
        internal static IConsoleReader SetupRandMock(params string[] values)
        {
            Mock<IConsoleReader> mockReader = new Mock<IConsoleReader>();
            mockReader.Setup(m => m.ReadLine()).ReturnsInOrder(values);

            return mockReader.Object;
        }
    }
}
