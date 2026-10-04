using CodeTranspiler.AST;

namespace CodeTranspiler.Generators
{
    public interface ICodeVisitor
    {
        string Visit(ProgramNode node);
        string Visit(FunctionCallNode node);
    }
}