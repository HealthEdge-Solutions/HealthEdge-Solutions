using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class BillingInvoice
    {
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }

        // Конструктор за замовчуванням
        public BillingInvoice()
        {
            InvoiceId = 0;
            PatientId = 0;
            Amount = 0;
            IssuedDate = DateTime.MinValue;
            DueDate = DateTime.MinValue;
        }

        // Конструктор з параметрами
        public BillingInvoice(int invoiceId, int patientId, decimal amount, DateTime issuedDate, DateTime dueDate)
        {
            InvoiceId = invoiceId;
            PatientId = patientId;
            Amount = amount;
            IssuedDate = issuedDate;
            DueDate = dueDate;
        }
    }
}
