using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task12;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 3, 2 };
            TreeSort tree = new TreeSort(arr);
            Assert.AreEqual('3', tree.ToString().Trim()[tree.ToString().Trim().Length-1]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 1, 3, 2 };
            ShellSort sort = new ShellSort();
            sort.Sort(arr);
            Assert.AreEqual(3, arr[2]);
        }
    }
}
