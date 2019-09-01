using System;

namespace ToolsQA
{
    internal class Then : Attribute
    {
        private string v;

        public Then(string v)
        {
            this.v = v;
        }
    }
}