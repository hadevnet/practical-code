using SRP.Models;

namespace SRP.Managers;

public class BillingManager
{
    public void GenerateBill(Patient patient)
    {
        // Logic for generating a patient's bill
        decimal totalAmount = CalculateTotalAmount(patient);
        Console.WriteLine($"Generated bill for patient {patient.Name}: {totalAmount:C}");
    }

    public void ProcessPayment(Patient patient, decimal amount)
    {
        // Logic for processing a payment
        Console.WriteLine($"Processed payment of {amount:C} for patient {patient.Name}.");
    }
    
    private decimal CalculateTotalAmount(Patient patient)
    {
        // Calculate total amount based on services provided
        // This is just a placeholder example
        decimal baseCharge = 500;
        decimal servicesCharge = 200;
        decimal medicationCharge = 300;
        return baseCharge + servicesCharge + medicationCharge;
    }
}