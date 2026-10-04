namespace CodeTranspiler.AST
{
    public class FunctionCallNode : ASTNode
    {
        public string FunctionName { get; set; }
        public string Argument { get; set; }

        public FunctionCallNode(string functionName, string argument)
        {
            FunctionName = functionName;
            Argument = argument;
        }

        public override string Accept(Generators.ICodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}