using System.Text;
using CodeTranspiler.AST;

namespace CodeTranspiler.Generators
{
    public class CGeneretors : ICodeVisitors
    {
        public string Visit(ProgramNode node)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#include <stdio.h>");
            sb.AppendLine();
            sb.AppendLine("int main() {");

            foreach (var stmt in node.Statements)
            {
                sb.AppendLine($"    {stmt.Accept(this)}");
            }

            sb.AppendLine("    return 0;");
            sb.AppendLine("}");

            return sb.ToString();
        }

        public string Visit(FunctionCallNode node)
        {
            return $"printf({node.Argument});";
        }
    }
}