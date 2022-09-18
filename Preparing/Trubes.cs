using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparing
{

    public class Tube
    {
        public double Thickness { get; set; }
        public double Length { get; set; }
        public double OuterDiameter { get; set; }
        public double InnerDiameter { get; set; }
        public double Density { get; set; }
        public bool IsDefectLength(double measuredLength)
        {
            if (measuredLength > Length + Length * 0.01 || measuredLength < Length + Length * 0.01)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public double GetWeight() => (Math.PI * (OuterDiameter - Thickness) * Thickness * (Length / 10) * Density) / 1000;
        
    }
    public class PN10 : Tube, IMDefect
    {
        public void Defect(double measuredThickness, double measuredLength)
        {
            if(IsDefectLength(measuredLength))
                Console.WriteLine("Defect");
            else if (measuredThickness > Thickness + Thickness * 0.1 || measuredThickness < Thickness + Thickness * 0.1 ||
                measuredThickness > Thickness + Thickness * 0.11 || measuredThickness < Thickness + Thickness * 0.11)
                Console.WriteLine("Defect");
            else
                Console.WriteLine("Not defect");
        }
    }
    public class PN16 : Tube, IMDefect
    {
        public void Defect(double measuredThickness, double measuredLength)
        {
            if (IsDefectLength(measuredLength))
                Console.WriteLine("Defect");
            else if (measuredThickness > Thickness + Thickness * 0.135 || measuredThickness < Thickness + Thickness * 0.135 ||
                     measuredThickness > Thickness + Thickness * 0.14 || measuredThickness < Thickness + Thickness * 0.14)
                Console.WriteLine("Defect");
            else
                Console.WriteLine("Not defect");
        }
    }
    public class PN20 : Tube, IMDefect
    {
        public void Defect(double measuredThickness, double measuredLength)
        {
            if (IsDefectLength(measuredLength))
                Console.WriteLine("Defect");
            else if (measuredThickness > Thickness + Thickness * 0.165 || measuredThickness < Thickness + Thickness * 0.165 ||
                     measuredThickness > Thickness + Thickness * 0.17 || measuredThickness < Thickness + Thickness * 0.17)
                Console.WriteLine("Defect");
            else
                Console.WriteLine("Not defect");
        }
    }
    public class PN25 : Tube, IMDefect
    {
        public void Defect(double measuredThickness, double measuredLength)
        {
            if (IsDefectLength(measuredLength))
                Console.WriteLine("Defect");
            else if (measuredThickness > Thickness + Thickness * 0.165 || measuredThickness < Thickness + Thickness * 0.165 ||
                     measuredThickness > Thickness + Thickness * 0.17 || measuredThickness < Thickness + Thickness * 0.17)
                Console.WriteLine("Defect");
            else
                Console.WriteLine("Not defect");
        }
    }
}