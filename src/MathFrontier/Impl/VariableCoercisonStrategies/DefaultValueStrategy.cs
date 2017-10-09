using System;
using System.Collections.Generic;
using System.Text;

namespace MathFrontier.Impl.VariableCoercisonStrategies
{
    /// <summary>
    /// 如果变量值为null, 则约束为0
    /// </summary>
    public class DefaultValueStrategy : IVariableCoercionStrategy
    {
        /// <summary>
        /// 约束值
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rawValue"></param>
        /// <returns></returns>
        public double CoerceValue(string id, double? rawValue)
        {
            return rawValue.GetValueOrDefault();
        }
    }
}