using System;
using System.Collections.Generic;
using Jace.Execution;

namespace Jace
{
    /// <summary>
    /// The Jace Calculation Engine.
    /// 
    /// This interface has been extracted to make the engine mockable in tests.
    /// </summary>
    public interface ICalculationEngine
    {
        IEnumerable<FunctionInfo> Functions { get; }
        IEnumerable<ConstantInfo> Constants { get; }
        double Calculate(string formulaText);

        /// <summary>
        /// Calculates the given formulas without verifications. This is faster, but leaves the responsibility to sanitize the formulas and variable names to the caller.
        /// </summary>
        /// <param name="formulaText">The formula which should be calculated. Must be lowercase.</param>
        /// <param name="variables">The variable dictionary. Variable names must be lowercase and must not collide with the constants or function names registered in this CalculationEngine.</param>
        /// <returns>The evaluated result of the formula and the variables.</returns>
        double CalculateUnsafe(string formulaText, IDictionary<string, double> variables);

        void VerifyFormulas(string formulaText, IDictionary<string, double> variables);
        double Calculate(string formulaText, IDictionary<string, double> variables);
        FormulaBuilder Formula(string formulaText);

        /// <summary>
        /// Build a .NET func for the provided formula.
        /// </summary>
        /// <param name="formulaText">The formula that must be converted into a .NET func.</param>
        /// <returns>A .NET func for the provided formula.</returns>
        Func<IDictionary<string, double>, double> Build(string formulaText);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double, double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double, double, double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double, double, double, double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double, double, double, double, double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName, Func<double, double, double, double, double, double> function);

        /// <summary>
        /// Add a function to the calculation engine.
        /// </summary>
        /// <param name="functionName">The name of the function. This name can be used in mathematical formulas.</param>
        /// <param name="function">The implemenation of the function.</param>
        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double>
                function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double, double>
                function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double, double,
                double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double, double,
                double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double, double,
                double, double, double> function);

        void AddFunction(string functionName,
            Func<double, double, double, double, double, double, double, double, double, double, double, double, double,
                double, double, double, double> function);

        void AddFunction(string functionName, DynamicFunc<double, double> functionDelegate);

        /// <summary>
        /// Add a constant to the calculation engine.
        /// </summary>
        /// <param name="constantName">The name of the constant. This name can be used in mathematical formulas.</param>
        /// <param name="value">The value of the constant.</param>
        void AddConstant(string constantName, double value);
    }
}