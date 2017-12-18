using System;

namespace ConsoleApp.Logic.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RegExpAttribute: Attribute
    {
        public string Expression { get; set; }

        public RegExpAttribute(string expression)
        {
            this.Expression = expression;
        }
    }
}
