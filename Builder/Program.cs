using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise
{
    class Program
    {
        static void Main()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
            Console.ReadLine();
        }
    }

    public class CodeBuilder
    {
        private readonly string className;
        private List<Field> fields;

        public CodeBuilder(string className)
        {
            this.className = className;
            fields = new List<Field>();
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            var field = new Field(fieldName, fieldType);
            fields.Add(field);
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {this.className}");
            sb.AppendLine("{");
            foreach(var f in this.fields) {
                sb.AppendLine($"  {f}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        public class Field
        {
            private string name, type;

            public Field(string name, string type)
            {
                this.name = name;
                this.type = type;
            }

            public override string ToString()
            {
                return $"public {this.type} {this.name};";
            }
        }
    }
}
