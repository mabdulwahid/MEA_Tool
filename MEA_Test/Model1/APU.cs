using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEA_Test
{
    public class APU : Subsystem
    {
        // System Driving Characteristic Instance Variable
        private double APUReqPower;

        // Internal System Characteristic Instance Variables
        private double APUWeight;
        private double APUMfgCost;
        private double APUMTBF;
        private double APUMaxHeatLoad;
        private double APUDMC;
        private double APUDandC;
        private double APUOperatingCost;

        // Constructor
        public APU(double reqPower)
        {
            this.APUReqPower = reqPower;
        }

        // setWeight method
        public void setWeight(double reqPower)
        {
            // Link this to the database and have it set the weight depending on what the user inputs?
            this.APUWeight = 800.0;
        }


    }
}
