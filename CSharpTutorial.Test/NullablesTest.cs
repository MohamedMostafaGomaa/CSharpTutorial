using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CSharpTutorial.Library;

namespace CSharpTutorial.Test
{
    [TestFixture]
    public class NullablesTest
    {
        [Test]
        
        public void CheckNullablesTest()
        {
            Nullables nullables = new Nullables();
            var result = nullables.CheckNullables(); 
        }


        [Test]
        public void CheckCoalescingOperatorTest()
        {
            Nullables nullables = new Nullables();
            var result = nullables.CheckCoalescingOperator();
        }
    }
}
