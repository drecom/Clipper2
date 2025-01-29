using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Drecom.Clipper2Lib.UnitTests
{

  [TestClass]
  public class TestOffsets
  {

    [TestMethod]
    public void TestOffsetEmpty()
    {
      Paths64 solution = new();

      ClipperOffset offset = new ClipperOffset();
      offset.Execute(10, solution);
    }
  }
}
