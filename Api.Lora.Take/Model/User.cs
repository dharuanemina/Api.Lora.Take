using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Lora.Take.Model
{
    public class User
    {
        [JsonPropertyName("avatar_url")]
        public string Avatar_oldName { set { Avatar = value; } }

        [JsonPropertyName("AvatarUrl")]
        public string Avatar { get; set; }
    }
}
