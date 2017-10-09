using System;
using System.Threading.Tasks;

namespace MathFrontier
{
    /// <summary>
    /// 表示一个变量源
    /// </summary>
    public interface IVariableProvider
    {
        /// <summary>
        /// 获取变量值
        /// </summary>
        /// <param name="varName"></param>
        /// <returns>如果无值, 则为null</returns>
        Task<double?> GetVarAsync(String varName);
    }
}