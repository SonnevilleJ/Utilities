using System;
using NUnit.Framework;

namespace Sonneville.Utilities.Test
{
    [TestFixture]
    public class PlatformTest
    {
        [Test]
        public void FailIfOnMono()
        {
            if (Type.GetType("Mono.Runtime") != null)
            {
                Assert.Fail();
            }
        }
    }
}