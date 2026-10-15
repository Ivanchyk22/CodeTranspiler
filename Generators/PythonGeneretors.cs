using System.Text;
using CodeTranspiler.AST;

namespace CodeTranspiler.Generators
{
    public class PythonGeneretors : ICodeVisitors
    {
        public string Visit(ProgramNode node)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var stmt in node.Statements)
            {
                sb.AppendLine(stmt.Accept(this));
            }
            return sb.ToString().TrimEnd();
        }

        public string Visit(FunctionCallNode node)
        {
            return $"print({node.Argument})";
        }
    }
}