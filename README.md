# MathFrontier - 一个简单的公式引擎

## 背景

本库用于满足项目中数值公式计算需求

## Hello World
```csharp
var formulaEvaluator = new FormulaEvaluator(
    typeof(MyMath), // 设置可以在公式中使用的静态方法
    new DefaultValueStrategy() // 设置变量值null时策略
);
var context = new FormulaEvaluatingContext
{
    VariableProvider = new MyVariableProvider() // 设置变量值来源
};
double result = await formulaEvaluator.EvalAsync("1+${Foo}", context);
```

## 公式示例

* 支持数字字面量
```
1     // 整形
1.234 // 浮点数
100%  // 百分数
```

* 支持变量
```
${变量}
```

* 支持加减乘除以及任意层次的括号
```
(1+(2-3))*4/5
```

* 支持方法调用
```
Math.Abs(${变量})
```

## 线程安全

`FormulaEvaluator`为线程安全的，可以在多个线程中使用