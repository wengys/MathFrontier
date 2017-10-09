using MathFrontier.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFrontier.Impl.VariableCoercisonStrategies
{
    /// <summary>
    /// 如果变量值为null, 则抛出异常
    /// </summary>
    /// <exception cref="CoerceVariableFailException">变量值为null</exception>
    public class NullNotAllowedStrategy : IVariableCoercionStrategy
    {
        /// <summary>
        /// 约束值
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rawValue"></param>
        /// <returns></returns>
        public double CoerceValue(string id, double? rawValue)
        {
            if (rawValue.HasValue)
            {
                return rawValue.Value;
            }
            throw new CoerceVariableFailException(id, rawValue);
        }
    }
}