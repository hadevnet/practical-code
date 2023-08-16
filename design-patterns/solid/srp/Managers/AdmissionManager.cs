using SRP.Models;

namespace SRP.Managers;

public class AdmissionManager
{
    public void AdmitPatient(Patient patient)
    {
        // Logic for admitting a patient
        Console.WriteLine($"Patient {patient.Name} admitted.");
    }

    public void DischargePatient(Patient patient)
    {
        // Logic for discharging a patient
        Console.WriteLine($"Patient {patient.Name} discharged.");
    }
}