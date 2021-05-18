using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Direnc context = new Direnc("sarı-mor-kırmızı-altın");
            List<Expression> expressions = new List<Expression>(3);

            expressions.Add(new Kusak1_2());
            expressions.Add(new Kusak3());
            expressions.Add(new Kusak4());

            foreach (Expression expression in expressions)
                expression.Interpreter(context);

            Console.WriteLine(context.Output);
        }
    }
}
