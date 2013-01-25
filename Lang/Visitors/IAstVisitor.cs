﻿using Lang.AST;

namespace Lang.Visitors
{
    public interface IAstVisitor
    {
        void Visit(Conditional ast);
        void Visit(Expr ast);
        void Visit(FuncInvoke ast);
        void Visit(VarDeclrAst ast);
        void Visit(MethodDeclr ast);
        void Visit(WhileLoop ast);
        void Visit(ScopeDeclr ast);
        void Visit(ForLoop ast);
    }
}