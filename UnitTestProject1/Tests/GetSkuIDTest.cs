//Test.cs
using NUnit.Framework;

/*These will be where all tests for the GET{ID} endpoint will be held */
namespace Test
{
        [TestFixture]
        public class GetSKUSIDTest : TestBase
        {
                [Test]
                public void GetSkuIDTest()
                {
                        resources.GetSkuIDInfoResource.SendRequestAndValidateResponse();
                }
        }
}
