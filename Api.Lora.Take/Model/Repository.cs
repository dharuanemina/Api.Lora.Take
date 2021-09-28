using System.Text.Json.Serialization;

namespace Api.Lora.Take.Model
{
    public class Repository
    {
        [JsonPropertyName("full_name")]
        public string FullName { set { Title = value; } }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description_oldName { set { Description = value; } }

        [JsonPropertyName("Descript")]
        public string Description { get; set; }

        [JsonPropertyName("owner")]
        public User Owner_oldName { set { Owner = value; } }

        [JsonPropertyName("User")]
        public User Owner { get; set; }
    }
}
