/* Copyright © SperoSophia, 2016 */
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boov
{
    public class Parser
    {
        public IEnumerable<Token> Tokens { get; set; }
        private Lexer lexer { get; set; }

        public Parser()
        {
            lexer = new Lexer();
            lexer.AddDefinition(new TokenDefinition("(operator)", new Regex(@"\*|\/|\+|\-")));
            lexer.AddDefinition(new TokenDefinition("(literal)", new Regex(@"\d+")));
            lexer.AddDefinition(new TokenDefinition("(white-space)", new Regex(@"\s+"), true));  
        }

        public void Parse(string str)
        {
            Tokens = new List<Token>();
            Tokens = lexer.Tokenize(str);
        }
    }
}
