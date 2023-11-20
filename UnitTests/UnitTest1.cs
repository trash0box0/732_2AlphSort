using _732_2AlphSort;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sort_54321_12345()
        {
            string input = "54321";
            string expected = "12345";

            Sorter sorter = new Sorter();
            string result = sorter.MakeSort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sort_CBA_ABC()
        {
            string input = "CBA";
            string expected = "ABC";

            Sorter sorter = new Sorter();
            string result = sorter.MakeSort(input);

            Assert.AreEqual(expected, result);
        }
    }
}