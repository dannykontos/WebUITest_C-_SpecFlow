using System;

namespace ToolsQA
{
    internal class AndAttribute : Attribute
    {
        private string v;

        public AndAttribute(string v)
        {
            this.v = v;
        }
    }
}