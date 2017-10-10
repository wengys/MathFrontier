grammar Formula;

     formula: //公式（整个语句）
         expression EOF;

     expression //表达式
         :   variableReference #Variable                 // 引用变量 ${表达式名}
         |   numeral #NumeralValue                       // 数字
         |   methodInvocation #MethodInvok               // 方法调用
         |   '(' expression ')' #BracketsExpression      // 括号
         |   expression '*' expression  #ExpressionMult  // *
         |   expression '/' expression  #ExpressionDiv   // /
         |   expression '+' expression #ExpressionPlus   //  +
         |   expression '-' expression #ExpressionMinus  //  -
         ;

     methodInvocation
         :   methodName methodParameterPart
         ;

     methodName
         :   MethodOrPropertyIdentity
         ;

     methodParameterPart
         :   '(' methodParameterList? ')'
         ;

     methodParameterList
         :   methodParameter (',' methodParameter)*
         ;

     methodParameter
         :   expression
         ;


     variableReference
         :   variableReferenceStart variableIndex variableReferenceEnd
         ;

     variableReferenceStart
         :   '${'
         ;

     variableReferenceEnd
         :   '}'
         ;

     variableIndex
         :   Identifier
         ;

     numeral
         :   '-'?NumeralLiteral'%'?
         ;

     NumeralLiteral
         :   DecimalNumeral
         |   FloatingPointNumeral
         ;


     Identifier
         :   Letter LetterOrDigit*
         ;



     MethodOrPropertyIdentity
         :   Identifier'.'Identifier
         ;

     fragment
     Letter
         :   [a-zA-Z$_]
         |   ~[\u0000-\u007F\uD800-\uDBFF]
         ;

     fragment
     LetterOrDigit
         :   [a-zA-Z0-9$_]
         |   ~[\u0000-\u007F\uD800-\uDBFF]
         ;

     fragment
     DecimalNumeral
         :   '0'
         |   NonZeroDigit Digits?
         ;

     fragment
     FloatingPointNumeral
         :   Digits '.' Digits
         ;

     fragment
     Digits
         :   Digit+
         ;

     fragment
     Digit
         :   '0'
         |   NonZeroDigit
         ;

     fragment
     NonZeroDigit
         :   [1-9]
         ;

     fragment
     Sign
         :   [+-]
         ;

     WS  :  [ \t\r\n\u000C]+ -> skip
         ;