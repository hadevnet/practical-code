using SRP.Managers;
using SRP.Models;

Patient patient = new() { Name = "John Doe", Age = 30 };

AdmissionManager admissionManager = new();
admissionManager.AdmitPatient(patient);

BillingManager billingManager = new();
billingManager.GenerateBill(patient);
