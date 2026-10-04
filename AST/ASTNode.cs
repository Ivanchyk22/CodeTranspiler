namespace CodeTranspiler.AST
{
    public abstract class ASTNode
    {
        public abstract string Accept(Generators.ICodeVisitor visitor);
    }
}