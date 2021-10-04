using System.Text.Json;

namespace DataValidator.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }
        public int Income { get; set; }
        public int Score { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}