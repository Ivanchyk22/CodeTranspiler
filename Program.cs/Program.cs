using System;
using CodeTranspiler.AST;
using CodeTranspiler.Parsers;
using CodeTranspiler.Generators;

namespace CodeTranspiler
{
    class Program
    {
        static void Main()
        {
            string sourceCode = "Console.WriteLine(\"Hello, World!\");";

            // 1. Парсимо рядок у Дерево (AST)
            SimpleParser parser = new SimpleParser();
            ProgramNode ast = parser.Parse(sourceCode);

            // 2. Генеруємо C-код через Visitor
            ICodeVisitor cGenerator = new CGenerator();
            string cResult = ast.Accept(cGenerator);

            // 3. Виводимо результат
            Console.WriteLine("--- Результат генерації ---");
            Console.WriteLine(cResult);
        }
    }
}