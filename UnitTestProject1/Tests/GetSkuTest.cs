//GetSkuIDTest.cs
using NUnit.Framework;

/*These will be where all tests for the GET endpoint will be held */
namespace Test
{
        [TestFixture]
        public class GetSKUSTest : TestBase
        {
                [Test]
                public void GetSkuTest()
                {
                        resources.GetSkuInfoResource.SendRequestAndValidateResponse();
                }
        }
}
