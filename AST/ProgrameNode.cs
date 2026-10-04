using System.Collections.Generic;

namespace CodeTranspiler.AST
{
    public class ProgramNode : ASTNode
    {
        public List Statements { get; } = new List();

        public override string Accept(Generators.ICodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}