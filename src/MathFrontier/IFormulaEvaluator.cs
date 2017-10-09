using System;
using System.Threading.Tasks;
using MathFrontier.Exceptions;

namespace MathFrontier
{
    /// <summary>
    /// 表身一个公式执行器
    /// </summary>
    public interface IFormulaEvaluator
    {
        /// <summary>
        /// 执行公式
        /// </summary>
        /// <param name="formula">公式</param>
        /// <param name="context">执行上下文</param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException">除数为0</exception>
        /// <exception cref="CoerceVariableFailException">变量值约束异常</exception>
        Task<double?> EvalAsync(string formula, FormulaEvaluatingContext context);
    }

    /// <summary>
    /// 公式执行上下文
    /// </summary>
    public struct FormulaEvaluatingContext
    {
        /// <summary>
        /// 变量源
        /// </summary>
        public IVariableProvider VariableProvider { get; set; }
    }
}