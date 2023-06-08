namespace Garage
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        double CurrentChargePercentage { get; set; }
        string MainColor { get; set; }

    }

    public interface IGasVehicle
    {
        void RefuelTank();
        double CurrentTankPercentage { get; set;}
        string MainColor { get; set; }

    }

}