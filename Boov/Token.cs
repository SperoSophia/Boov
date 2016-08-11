/* Copyright © SperoSophia, 2016 */
using System.Text.RegularExpressions;

namespace Boov
{
    public class Token
    {
        public Token(string type, string value, TokenPosition position) {
            Type = type;
            Value = value;
            Position = position;
        }

        public TokenPosition Position { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("Token: {{ Type: \"{0}\", Value: \"{1}\", Position: {{ Index: \"{2}\", Line: \"{3}\", Column: \"{4}\" }} }}", Type, Value, Position.Index, Position.Line, Position.Column);
        }
    }

    public class TokenDefinition {
        public TokenDefinition(string type, Regex regex) : this(type, regex, false) { }

        public TokenDefinition(string type, Regex regex, bool isIgnored) {
            Type = type;
            Regex = regex;
            IsIgnored = isIgnored;
        }

        public bool IsIgnored { get; private set; }
        public Regex Regex { get; private set; }
        public string Type { get; private set; }
    }

    public class TokenPosition {
        public TokenPosition(int index, int line, int column) {
            Index = index;
            Line = line;
            Column = column;
        }

        public int Column { get; private set; }
        public int Index { get; private set; }
        public int Line { get; private set; }
    }
}
