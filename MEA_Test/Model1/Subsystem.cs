using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEA_Test
{
    public class Subsystem
    {
        // Instance variables
        private String name;
        private List<Parameter> subsystemParameters;

        // default constructor
        public Subsystem(){}

        // Constructor
        public Subsystem(String name, List<Parameter> parameters)
        {
            this.name = name;
            this.subsystemParameters = parameters;
        }

    }   // end Subsystem class
}
