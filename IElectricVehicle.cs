using System;

public interface IElectricVehicle
{
    double BatteryKWh { get; set; }
    void ChargeBattery();
    void CurrentChargePercentage();
}