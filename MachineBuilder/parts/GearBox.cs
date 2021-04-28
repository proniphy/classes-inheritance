using System;
using System.Collections.Generic;
using System.Text;

namespace MachineBuilder.parts
{
    public enum Gear
    {
        First,
        Second,
        Third,
        Fourth,
        None,
        Rear
    }
    public struct GearBox
    {
        public Gear Gear { get; set; }
        public bool ShiftUp()
        {
            bool isShifted = false;
            int upGear = (int)Gear + 1;
            if ((Gear)upGear <= Gear.Fourth)
            {
                Gear += 1;
                isShifted = true;
            }
            return isShifted;
        }
    }
}
