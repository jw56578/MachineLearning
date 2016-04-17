using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning.Concepts
{
    //create a training set of data
    //m = the number of training examples
    //x's = teh input variables
    //y's = the output variable
    //(x,y) is one training example

        /*
        take the training set and send it through an algorithm to reach a hypothesis
        h= = Hypohesis is the terminology for the function that is used to run the algorithm
        */
    public struct Model
    {
        public double X;
        public double Y;
    }
}
