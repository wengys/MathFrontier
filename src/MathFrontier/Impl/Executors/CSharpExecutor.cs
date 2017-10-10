using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Threading.Tasks;

namespace MathFrontier.Impl.Executors
{
    /// <summary>
    /// C#公式执行器
    /// </summary>
    public class CSharpExecutor : IFormulaEvaluator
    {
        private readonly Type availableMethodsType;
        private readonly IVariableCoercionStrategy variableCoercisonStrategy;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="availableMethodsType">包含公式中可用静态方法的类型</param>
        /// <param name="variableCoercisonStrategy">默认变量值约束策略</param>
        public CSharpExecutor(
            Type availableMethodsType,
            IVariableCoercionStrategy variableCoercisonStrategy)
        {
            this.availableMethodsType = availableMethodsType;
            this.variableCoercisonStrategy = variableCoercisonStrategy;
        }

        /// <summary>
        /// 执行表达式
        /// </summary>
        /// <param name="formula">表达式</param>
        /// <param name="context">执行上下文</param>
        /// <returns></returns>
        public async Task<double> EvalAsync(string formula, FormulaEvaluatingContext context)
        {
            try
            {
                double result = await CSharpScript.EvaluateAsync<double>(
                    formula,
                    ScriptOptions.Default
                        //.WithImports("System")
                        .WithImports(availableMethodsType.Namespace)
                        .WithReferences(
                            typeof(System.Math).Assembly,
                            typeof(System.Double).Assembly,
                            typeof(Nullable<>).Assembly,
                            typeof(CSharpFormulaGlobal).Assembly,
                            availableMethodsType.Assembly
                        ),
                    new CSharpFormulaGlobal(variableCoercisonStrategy, context)
                );
                if (Double.IsInfinity(result))
                {
                    throw new DivideByZeroException($"公式 {formula} 发生除数为零异常");
                }
                return result;
            }
            catch (CompilationErrorException e)
                when (e.Message.Contains("CS0020"))
            {
                throw new DivideByZeroException($"公式 {formula} 发生除数为零异常");
            }
        }
    }

    /// <summary>
    /// 公式执行上下文
    /// </summary>
    public class CSharpFormulaGlobal
    {
        private readonly IVariableCoercionStrategy variableCoercisonStrategy;
        private readonly FormulaEvaluatingContext context;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="variableCoercisonStrategy">默认变量值约束策略</param>
        /// <param name="context">公式执行上下文</param>
        public CSharpFormulaGlobal(
            IVariableCoercionStrategy variableCoercisonStrategy,
            FormulaEvaluatingContext context)
        {
            this.variableCoercisonStrategy = variableCoercisonStrategy;
            this.context = context;
        }

        /// <summary>
        /// 获取变量值
        /// </summary>
        /// <param name="variableName">变量名</param>
        /// <returns></returns>
        public async Task<double> Var(string variableName)
        {
            double? rawValue = await GetRawValue(variableName, context);
            double value = CoerceValue(variableName, rawValue);
            return value;
        }

        /// <summary>
        /// 约束变量值
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="rawValue"></param>
        /// <returns></returns>
        private double CoerceValue(string variableName, double? rawValue)
        {
            var value = variableCoercisonStrategy.CoerceValue(variableName, rawValue);
            return value;
        }

        /// <summary>
        /// 从变量源获取原始值
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<double?> GetRawValue(string variableName, FormulaEvaluatingContext context)
        {
            return await context.VariableProvider.GetVarAsync(variableName);
        }
    }
}