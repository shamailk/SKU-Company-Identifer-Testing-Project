//GetSkuIDTest.cs
using NUnit.Framework;

/*These will be where all tests for the DELETE{id} endpoint will be held */
namespace Test
{
        [TestFixture]
        public class DeleteSKUSTest : TestBase
        {
                [Test]
                public void DeleteSkuTest()
                {
                        resources.DeleteSkuIDInfoResource.SendRequestAndValidateResponse();
                }
        }
}
