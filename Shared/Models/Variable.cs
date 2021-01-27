using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace cstranslator.Shared.Models
{
    public class Variable
    {
        // Attributes
        public string Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        // Constructors
        public Variable (string type, string name, string value)
        {
            if (CanSave(type, value))
            {
                this.Type = type;
                this.Name = name;
                this.Value = value;
            } else {
                this.Type = null;
                this.Name = null;
                this.Value = null;
            }
        }

        // Methods

        /* LogEntry CheckName(Variable variable, List<Variable> list)
        *
        *   Receives a single "Variable" object and a list of th same type, checks to see if name is taken.
        *   Retuns a LogEntry object, with "0-(...)" if taken/error and "1-(...)" if available */
        public LogEntry CheckName(Variable variable, List<Variable> list) {
            foreach (Variable saved in list)
            {
                if (saved.Name == variable.Name) return new LogEntry("0", "A variable with that name already exists");
            }
            return new LogEntry("1",$"Variable ({variable.Type}) {variable.Name} created with value of {variable.Value}");
        }

        /* Boolean CanSave(string type, string value)
        *
        *   Receives a type and value for a "Variable" object candidate to check if is valid.
        *   Checks value based on type received */
        private Boolean CanSave(string type, string value) {
            switch (type)
            {
                case "int":
                    try {
                        int temp1 = int.Parse(value, NumberStyles.AllowLeadingSign);
                        return (temp1.GetType().Equals(typeof(int))) ? true : false;
                    } catch {
                        return false;
                    }
                
                case "double":
                    double temp2 = Convert.ToDouble(value);
                    return (temp2.GetType().Equals(typeof(double))) ? true : false;

                case "string":
                    return (value.GetType().Equals(typeof(string))) ? true : false;

                case "bool":
                    bool temp4 = true;
                    if (value == "false") temp4 = false;
                    return (temp4.GetType().Equals(typeof(bool))) ? true : false;

                default:
                    return false;
            }
                
        }
    }
}
