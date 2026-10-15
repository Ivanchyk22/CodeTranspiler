using System.Collections.Generic;
using CodeTranspiler.Generators;

namespace CodeTranspiler.AST
{
    public class ProgramNode : ASTNode
    {
        public List<ASTNode> Statements { get; } = new List<ASTNode>();

        public override string Accept(ICodeVisitors visitor)
        {
            return visitor.Visit(this);
        }
    }
}