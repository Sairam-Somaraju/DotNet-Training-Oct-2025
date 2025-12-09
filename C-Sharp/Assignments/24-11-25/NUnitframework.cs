using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    internal class NUnitframework
    {
        [Test]
        public void NUnitFrameworkConstraints()
        {
                string text = "NUnitFramework";

                Assert.That(text.StartsWith("N"));
                Assert.That(text.EndsWith("k"));
                Assert.That(text.Contains("Fr"));
            
        }
    }
}
