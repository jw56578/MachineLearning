using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MachineLearning.Concepts;
using System.Collections.Generic;
using System.Linq;

namespace MachineLearning
{
    [TestClass]
    public class LinearRegressionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //what is the minimized value of this test set,
            LinearRegressionWithOneVariable lr = new LinearRegressionWithOneVariable(new Model[] {
                new Model { X=1,Y=1},
                new Model { X=2,Y=2},
                new Model { X=3,Y=3}
            });
            Assert.AreEqual(lr.RunSimple(1),0);
            Assert.AreEqual(lr.RunSimple(0.5), 0.58333333333333326);
            var result = lr.RunSimple(0);

            List<double> jResults = new List<double>();
            for (double i = -30; i < 30; i++)
            {
                result = lr.RunSimple(i);
                jResults.Add(result);
            }

            var min = jResults.Min();

            Assert.AreEqual(min, 0);

        }
    }
}
