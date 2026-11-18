
using System;

public static class PayrollCalculator
{
    // Calculates the employee's basic pay
    public static decimal CalculateBasicPay(
        decimal dailyRate, int daysWorked)
    {
        if (dailyRate < 0 || daysWorked < 0)
        {
            throw new ArgumentException(
                "Daily rate and days worked cannot be negative."
            );
        }

        return dailyRate * daysWorked;
    }

    // Calculates the employee's overtime pay
    public static decimal CalculateOvertimePay(
        decimal overtimeRate, decimal overtimeHours)
    {
        if (overtimeRate < 0 || overtimeHours < 0)
        {
            throw new ArgumentException(
                "Overtime rate and hours cannot be negative."
            );
        }

        return overtimeRate * overtimeHours;
    }

    // Calculates the employee's total gross pay
    public static decimal CalculateGrossPay(
        decimal basicPay, decimal overtimePay)
    {
        if (basicPay < 0 || overtimePay < 0)
        {
            throw new ArgumentException(
                "Pay amounts cannot be negative."
            );
        }

        return basicPay + overtimePay;
    }
}
