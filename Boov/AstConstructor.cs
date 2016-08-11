/* Copyright © SperoSophia, 2016 */
using System;

/*
  Experimental AST Generator, to define it in a fluent like api with the token definition. 
*/

namespace Boov
{
    public abstract class AST {
        public Token Token;
    }

    public class Expression : AST {
        public AST Operator;
        public AST Left;
        public AST Right;
    }

    public class AstRule
    {
        public TokenDefinition Token { get; set; }
        public AST Result { get; set; }
        public Func<Token, AST> Generate { get; set; }
    }
}
