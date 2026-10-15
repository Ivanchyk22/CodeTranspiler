using CodeTranspiler.Generators;

namespace CodeTranspiler.AST
{
    public abstract class ASTNode
    {
        public abstract string Accept(ICodeVisitors visitor);
    }
}