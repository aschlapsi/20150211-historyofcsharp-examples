using System;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ParseExpression(num => num < 5);
            CompileExpression(num => num < 5);
        }

        private static void ParseExpression(Expression<Func<int, bool>> exprTree)
        {
            ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];
            BinaryExpression operation = (BinaryExpression)exprTree.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",
                param.Name, left.Name, operation.NodeType, right.Value);
        }

        private static void CompileExpression(Expression<Func<int, bool>> exprTree)
        {
            Func<int, bool> result = exprTree.Compile();
            Console.WriteLine(result(4));

            Console.WriteLine(exprTree.Compile()(4));
        }
    }
}
