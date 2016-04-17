using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning.Concepts
{
    //also called Univaritate(one variable) linear regression 
    // h(x) = theta0 + theta1 * x; <- this is a linear function, a line that goes in a straight line
    // theta0 = y intercept point
    // theta1 = slope, for every 1 unit on the x axis how far does the y axis go  .5 means that x goes over 1 and y goes up .5
    // h(x) = y
    public class LinearRegressionWithOneVariable
    {
        
        Model[] trainingSet;
        public LinearRegressionWithOneVariable(Model[] trainingSet)
        {
            this.trainingSet = trainingSet;
        }
        public double RunSimple(double theta1)
        {
            return SimpleCostFuntion(trainingSet.Length,theta1);
        }
        /// <summary>
        /// the cost function is refered to as J but in code i just call it by its full name
        /// also sometimes called the squared error function
        /// </summary>
        /// <param name="theta0"></param>
        /// <param name="theta1"></param>
        double CostFunction(int m, double theta0, double theta1)
        {
            
            /*
            iterate each value in the training set
            send x into the hypothesis function
            subtract y from that result and then square that
            accumlate sum of the result 
            multiply the accumulation by 1 / (2 * m)
            */
            //h is suppose to be the function for a linear line , theta0 + theta1(x)
            Func<double, double> h = (x) => {
                //all this is doing is calculating y point on the graph for any given x point as per the y intercept theta0 and slope theta1
                var y =  theta0 + theta1 * x;
                return y;
            };
            double total = 0;
            foreach (var set in trainingSet) {
                total += (double)Math.Pow((h(set.X) - set.Y), 2);
            }

            var j =  (1.0 / (2.0 * m)) * total;
            return j;
        }

        /// <summary>
        /// hard code theta0 to zero, this means the line intercepts y at 0
        /// </summary>
        /// <param name="theta1"></param>
        double SimpleCostFuntion(int m, double theta1)
        {
            return CostFunction(m,0, theta1);
        }

    }
}
