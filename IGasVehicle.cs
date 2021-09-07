using System;

public interface IGasVehicle
{
    double FuelCapacity { get; set; }
    int MaximumOccupancy { get; set; }
    
    void RefuelTank();
    void CurrentTankPercentage();
}