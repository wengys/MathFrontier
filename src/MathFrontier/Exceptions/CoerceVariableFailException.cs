using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFrontier.Exceptions
{
    /// <summary>
    /// 变量正则化异常
    /// </summary>
    public class CoerceVariableFailException : Exception
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public CoerceVariableFailException(string id, double? value)
            : base($"无法正则化值 {id} (Variable): 当前值为 {value}")
        {
        }
    }
}