using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProCalc.Lib.Lexer
{
    /// <summary>
    /// Equation lexer.
    /// </summary>
    /// <remarks>
    /// TODO: are there more efficient ways of doign this? does it matter?
    /// </remarks>
    public class Lexer
    {
        private static readonly Regex R = new Regex(
            @"(?<num>       [0-9]([ \t0-9]*[0-9])?([ \t]*\.[ \t0-9]*[0-9])?
            )|(?<id>        [a-zA-Z][0-9a-zA-Z]*
            )|(?<op>        \+|\-|\*|\/
            )|(?<ob>        \(
            )|(?<cb>        \)
            )|(?<comma>     ,
            )|(?<sp>        \s+
            )|(?<err>       .
            )",
            RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.CultureInvariant);

        private static readonly KeyValuePair<int, TokenType>[] GroupToType = new []
        {
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("num"), TokenType.Number),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("id"), TokenType.Identifier),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("op"), TokenType.Operator),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("ob"), TokenType.OpenParen),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("cb"), TokenType.CloseParen),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("comma"), TokenType.Comma),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("sp"), TokenType.Whitespace),
            new KeyValuePair<int, TokenType>(R.GroupNumberFromName("err"), TokenType.Invalid),
        };

        public static IEnumerable<Token> Lex(string input, bool skipWhitespace = true)
        {
            foreach (var m in R.Matches(input).Cast<Match>())
            {
                TokenType type = TokenType.Invalid;
                foreach (var gtot in GroupToType)
                {
                    if (m.Groups[gtot.Key].Success)
                    {
                        type = gtot.Value;
                        break;
                    }
                }

                if (skipWhitespace && type == TokenType.Whitespace)
                    continue;

                yield return new Token(type, m.Index, m.Length, input);
            }

            yield return new Token(TokenType.EOF, input.Length, 0, input);
        }
    }
}
