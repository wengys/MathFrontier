using System;

namespace MathFrontier.Exceptions
{
    /// <summary>
    /// 表达式格式错误
    /// </summary>
    public class SyntaxErrorException : Exception
    {
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="phase">阶段</param>
        /// <param name="message">信息</param>
        public SyntaxErrorException(string phase, string message)
            : base($"{phase} {message}")
        {
        }
    }
}