using KalleSoft.Extensions.Maneys;


namespace KalleSoft.Extensions.Tests.Money
{
    public class MoneyExtensionTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ShowldConvertDecimalToInt()
        {
            decimal value = Convert.ToDecimal("1690.00");
            var actual = 169000;
            var cents = value.ToCents();
            
            Assert.That(actual, Is.EqualTo(cents));
        }
    }
}