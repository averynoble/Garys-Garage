using System;

public interface IWaterVehicle
{
    double FuelCapacity { get; set; }
    int MaximumOccupancy { get; set; }
    
    void RefuelTank();
    void AmountOfWater();
    void DockVehicle();
}