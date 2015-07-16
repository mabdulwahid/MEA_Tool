using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MEA_Test
{
    public class Airplane
    {
        // General instance variables
        private String name;
        private String planeType;
        private Subsystem[] subsystem;

        // Aircraft input instance variables
        private String aircraftBleedArchitecture;
        private double aircraftMiscPowerUsage;
        private double aircraftCabinThermConductivity;
        private double aircraftSkinTempHeatLoad;
        private int aircraftPAX;

        // Aircraft output instance variables 
        // These will be set through methods based on given parameters
        private double aircraftWeight;
        private double aircraftMfgCost;
        private double aircraftDMC;
        private double aircraftDAndC;
        private double aircraftOperatingCost;
        private double aircraftPowerConsumption;

        // Airplane constructor
        // Airplane object is constructed given the Aircraft Inputs
        public Airplane(String bleedArch, double miscPowerUsage, double cabinThermConductivity,
            double skinTempHeatLoad, int pax)
        {
            // Initializing all the inputs of the aircraft that will be passed in by the user
            this.aircraftBleedArchitecture = bleedArch;
            this.aircraftMiscPowerUsage = miscPowerUsage;
            this.aircraftCabinThermConductivity = cabinThermConductivity;
            this.aircraftSkinTempHeatLoad = skinTempHeatLoad;
            this.aircraftPAX = pax;

            // Initializing all the output variables that will later be calculated based on the inputs
            this.aircraftWeight = 0.0;
            this.aircraftMfgCost = 0.0;
            this.aircraftDMC = 0.0;
            this.aircraftDAndC = 0.0;
            this.aircraftOperatingCost = 0.0;
            this.aircraftPowerConsumption = 0.0;
        }

        //Airplace constructor with only pax parameter
        public Airplane(int pax)
        {
            this.aircraftPAX = pax;
        }

    }
}
