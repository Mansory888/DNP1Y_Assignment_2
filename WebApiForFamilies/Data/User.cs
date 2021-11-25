using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment_1.Data
{
    public class User
    {
        [Key]
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        
        
        [JsonPropertyName("password")]
        public string pass { get; set; }
        
        
        [JsonPropertyName("BirthYear")]
        public int BirthYear { get; set; }
        
        
        [JsonPropertyName("SecurityLevel")]
        public int SecurityLevel { get; set; }
    }
}