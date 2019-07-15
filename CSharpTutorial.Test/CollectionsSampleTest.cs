using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CSharpTutorial.Library;

namespace CSharpTutorial.Test
{
    /// <summary>
    /// Summary description for CollectionsSampleTest
    /// </summary>
    [TestFixture]
    public class CollectionsSampleTest
    {
        [Test]
        public void HashTableTest()
        {
            CollectionsSample sample = new CollectionsSample();
            sample.Hashtable_Check();
        }
    }
}
