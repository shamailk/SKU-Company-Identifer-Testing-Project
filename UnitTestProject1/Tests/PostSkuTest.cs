//GetSkuIDTest.cs
using NUnit.Framework;

/*These will be where all tests for the POST endpoint will be held */
namespace Test
{
        [TestFixture]
        public class PostSKUSTest : TestBase
        {
                [Test]
                public void PostSkuTest()
                {
                        resources.PostSkuInfoResource.SendRequestAndValidateResponse();
                }
        }
}
