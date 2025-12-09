namespace _24_11_25
{

    public class Calculator
    {
        public int Square(int a) => a * a;
    }
    public class CalculatorTests
    {
        [Test]
        public void Square_Sum()
        {
            Calculator calculator = new Calculator();

            int result=calculator.Square(2);

            Assert.That(result,Is.EqualTo(4));
        }
         
    }
}
