using NUnit.Framework;

namespace Range_Test
{
    [TestFixture]
    public class Range_Test
    {
        [Test]
        public void RangeClosed2Open6ContainsNumbers2and4()
        {
            int rangeFirst = 2;
            int rangeLast = 6; 
            int[] numbers = { 2, 4 };
            if ((numbers[0] <= rangeFirst && numbers[0] > rangeLast) && (numbers[1] <= rangeFirst && numbers[1] > rangeLast))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void RangeClosed2Open6ContainsNumbersNegative1and1and6and10() 
        {
            int rangeFirst = 2;
            int rangeLast = 6;
            int[] numbers = { -1, 1, 6, 10 };
            if (numbers[0] <= rangeFirst && numbers[3] > rangeLast)
            {
                Assert.Fail();
            }
        }
    }
}
