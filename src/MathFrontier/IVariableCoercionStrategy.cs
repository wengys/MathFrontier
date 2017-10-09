using MathFrontier.Exceptions;

namespace MathFrontier
{
    /// <summary>
    /// 约变量束值
    /// </summary>
    public interface IVariableCoercionStrategy
    {
        /// <summary>
        /// 约束值为特定范围（或抛出异常）
        /// </summary>
        /// <param name="id">值Id</param>
        /// <param name="rawValue">原始值</param>
        /// <returns>正则化后的值</returns>
        /// <exception cref="CoerceVariableFailException"/>
        double CoerceValue(string id, double? rawValue);
    }
}