using lab13;

namespace TestLab13
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TEST1()
        {
            string s1 = "привет мой друг";
            string s2 = "привет мой недруг";

            string[] res = Logic.FindWords(s1, s2);
            string[] a = new string[] { "привет", "мой" };

            CollectionAssert.AreEqual(a, res);
        }

        [TestMethod]
        public void TEST2()
        {
            string s1 = "я люблю майнкрафт";
            string s2 = "ты любишь террарию";

            string[] res = Logic.FindWords(s1, s2);
            string[] a = new string[] { };

            CollectionAssert.AreEqual(a, res);
        }

        [TestMethod]
        public void TEST3()
        {
            string s1 = "кошка собака кошка птичка";
            string s2 = "собака рыбка кошка";

            string[] res = Logic.FindWords(s1, s2);
            string[] a = new string[] { "кошка", "собака" };

            CollectionAssert.AreEqual(a, res);
        }

        [TestMethod]
        public void TEST4()
        {
            string s1 = "один";
            string s2 = "один один один";

            string[] res = Logic.FindWords(s1, s2);
            string[] a = new string[] { "один" };

            CollectionAssert.AreEqual(a, res);
        }

        
    }
}
