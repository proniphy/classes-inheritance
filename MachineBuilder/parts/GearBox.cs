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
        public Gear Gear { get; private set; }
        public GearBox()
        {
            Gear = Gear.None;
        }
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
