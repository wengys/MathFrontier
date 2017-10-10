using MathFrontier.Impl.Executors;
using System;
using System.Threading;
using System.Threading.Tasks;
using MathFrontier.Impl.Interpreters;

namespace MathFrontier.Impl
{
    /// <summary>
    /// 公式执行器
    /// </summary>
    public class FormulaEvaluator : IFormulaEvaluator
    {
        private readonly Type availableMethodsType;
        private static readonly FormulaCSInterpreter interpreter = new FormulaCSInterpreter();
        private readonly CSharpExecutor executor;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="availableMethodsType">包含公式中可用静态方法的类型</param>
        /// <param name="variableCoercisonStrategy">默认变量值约束策略</param>
        public FormulaEvaluator(
            Type availableMethodsType,
            IVariableCoercionStrategy variableCoercisonStrategy)
        {
            this.availableMethodsType = availableMethodsType;
            this.executor = new CSharpExecutor(availableMethodsType,variableCoercisonStrategy);
        }

        /// <summary>
        /// 执行表达式
        /// </summary>
        /// <param name="formula">表达式</param>
        /// <param name="context">执行上下文</param>
        /// <returns></returns>
        public Task<double> EvalAsync(string formula, FormulaEvaluatingContext context)
        {
            var scriptToExecute = interpreter.Interpret(formula, availableMethodsType);
            return executor.EvalAsync(scriptToExecute, context);
        }
    }
}