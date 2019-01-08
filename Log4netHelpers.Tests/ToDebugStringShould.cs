using System.Collections.Generic;
using Log4netHelpers.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Log4netHelpers.Tests
{
    [TestClass]
    public class ToDebugStringShould
    {
        [DataTestMethod]
        [DataRow(null, "null")]
        [DataRow(new string[] { "Text1" }, "[\"Text1\"]")]
        [DataRow(new string[] { "Text1", "Text2", "Text3" }, "[\"Text1\",\"Text2\",\"Text3\"]")]
        public void HanldeIEnumerableString(IEnumerable<string> testObject, string expected)
        {
            // Act
            var actual = testObject.ToDebugString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
