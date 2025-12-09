using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class NumberHelper
    {
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };
    }
    internal class CollectionAssertion
    {
        [Test]
            public void GetEvenCollections()
            {
                NumberHelper helper= new NumberHelper();

                List<int> result =helper.GetEvenNumbers();

             
                //To Check the length
                Assert.That(result.Count, Is.EqualTo(4));

                //Check elements are in ascending order
                Assert.That(result, Is.Ordered);

                //Check all numbers are even
                Assert.That(result, Is.All.Matches<int>(x => x % 2 == 0));

             }
    }
}
