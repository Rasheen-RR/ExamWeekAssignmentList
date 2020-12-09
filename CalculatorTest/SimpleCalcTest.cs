using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{

    [TestClass]
    public class SimpleCalcTests
    {


        //Add method

        [TestMethod]
        public void AddTwoPositives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 10.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddTwoNegatives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = -10.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddOneNgeativeOnePositive()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = 14.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void AddOnePositiveOneZero()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 0.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddTwoZeros()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = 0.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void AddOneZeroOneNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = -10.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddTwoLargeNumbers()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 1973820.0;
            double b = 1256890.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddTwoDecimals()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.123342130;
            double b = 0.123342130;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void AddWholeNumberAndDecimal()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 12.0;
            double b = 0.1230;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void AddDecimalAndNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.120;
            double b = -2.0;

            double ans = a + b;
            double result = simpleCalc.addNumbers(a, b);
            Assert.AreEqual(result, ans);
        }



        // Substract method

        [TestMethod]
        public void SubstractTwoPositives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 10.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractTwoNegatives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = -10.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractOneNgeativeOnePositive()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = 14.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void SubstractOnePositiveOneZero()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 0.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractTwoZeros()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = 0.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void SubstractOneZeroOneNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = -10.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractTwoLargeNumbers()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 1973820.0;
            double b = 1256890.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractTwoDecimals()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.123342130;
            double b = 0.123342130;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void SubstractWholeNumberAndDecimal()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 12.0;
            double b = 0.1230;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void SubstractDecimalAndNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.120;
            double b = -2.0;

            double ans = a - b;
            double result = simpleCalc.substractNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        // Multiply Method


        [TestMethod]
        public void MultilpyTwoPositives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 10.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyTwoNegatives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = -10.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyOneNgeativeOnePositive()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = 14.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void MultilpyOnePositiveOneZero()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 0.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyTwoZeros()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = 0.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void MultilpyOneZeroOneNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = -10.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyTwoLargeNumbers()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 1973820.0;
            double b = 1256890.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyTwoDecimals()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.123342130;
            double b = 0.123342130;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void MultilpyWholeNumberAndDecimal()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 12.0;
            double b = 0.1230;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void MultilpyDecimalAndNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.120;
            double b = -2.0;

            double ans = a * b;
            double result = simpleCalc.mulitplyNumbers(a, b);
            Assert.AreEqual(result, ans);
        }



        // Division Method

        [TestMethod]
        public void DivideTwoPositives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 10.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideTwoNegatives()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = -10.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideOneNgeativeOnePositive()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -10.0;
            double b = 14.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void DivideOnePositiveOneZero()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 0.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideZeroAndPositive()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = 10.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void DivideOneZeroOneNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.0;
            double b = -10.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideTwoLargeNumbers()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 1973820.0;
            double b = 1256890.0;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideTwoDecimals()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 0.123342130;
            double b = 0.13342130;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void DivideWholeNumberAndDecimal()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 12.0;
            double b = 0.1230;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void DivideDecimalAndNegative()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -2.0;
            double b = 0.120;

            double ans = a / b;
            double result = simpleCalc.divideNumbers(a, b);
            Assert.AreEqual(result, ans);
        }



        // Operation Tests

        [TestMethod]
        public void OperationDivision()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 20.0;

            double ans = a / b;
            double result = simpleCalc.OperatorSwitch(a, b, "/");
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void OperationMultiplication()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 20.0;

            double ans = a * b;
            double result = simpleCalc.OperatorSwitch(a, b, "*");
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void OperationAddition()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 10.0;
            double b = 20.0;

            double ans = a + b;
            double result = simpleCalc.OperatorSwitch(a, b, "+");
            Assert.AreEqual(result, ans);
        }

        [TestMethod]
        public void OperationSubstraction()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = 12.0;
            double b = 0.1230;

            double ans = a - b;
            double result = simpleCalc.OperatorSwitch(a, b, "-");
            Assert.AreEqual(result, ans);
        }


        [TestMethod]
        public void OperationDefault()
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            double a = -2.0;
            double b = 0.120;

            double ans = double.NaN;
            double result = simpleCalc.OperatorSwitch(a, b, "0");
            Assert.AreEqual(result, ans);
        }
    }
}
