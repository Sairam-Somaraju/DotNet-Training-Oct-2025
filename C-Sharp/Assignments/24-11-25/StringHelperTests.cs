using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class StringHelper
    {
        public string ToUpper(string input) => input.ToUpper();
    }
    internal class StringHelperTests
    {
        [Test]
        public void TestStringHelper()
        {
            StringHelper st= new StringHelper();
            string input = "hello";

            string result = st.ToUpper(input);
 
                Assert.That(result.Length, Is.EqualTo(5));
                Assert.That(result[0], Is.EqualTo('H'));
                Assert.That(result, Is.EqualTo("HELLO"));
         }
    }
}
