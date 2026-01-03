using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clasess
{
    public class Subscription
    {
        [Key] [Required]   
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("service_name")] public string? ServiceName { get; set; }
        [JsonPropertyName("amount")] public decimal Amount { get; set; }
        [JsonPropertyName("currency")] public string? Currency { get; set; }
        [JsonPropertyName("billing_cycle")] public string? BillingCycle { get; set; }
        [JsonPropertyName("category")] public string? Category { get; set; }
        [JsonPropertyName("next_billing_date")] public DateTime NextBillingDate { get; set; }
        [JsonPropertyName("status")] public string? Status { get; set; }
        [JsonPropertyName("is_trial")] public bool IsTrial { get; set; }
        [JsonPropertyName("auto_payment")]  public bool AutoPayment { get; set; }

        [JsonPropertyName("reminder_days")] public int Recordatorio { get; set; }


        public List<Payment> Payments { get; set; } = new();

    }

}
