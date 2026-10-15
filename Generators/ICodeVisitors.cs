using CodeTranspiler.AST;

namespace CodeTranspiler.Generators
{
    public interface ICodeVisitors
    {
        string Visit(ProgramNode node);
        string Visit(FunctionCallNode node);
    }
}