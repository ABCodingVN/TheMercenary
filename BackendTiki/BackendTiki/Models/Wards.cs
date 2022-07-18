using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class Wards
    {
        private string wardsId;
        private string districtId;
        private string nameWards;

        [JsonIgnore]
        private District district;
        [JsonIgnore]
        private ICollection<User> users;
        public string WardsId { get => wardsId; set => wardsId = value; }
        public string DistrictId { get => districtId; set => districtId = value; }
        public string NameWards { get => nameWards; set => nameWards = value; }
        [JsonIgnore]
        public District District { get => district; set => district = value; }
        [JsonIgnore]
        public ICollection<User> Users { get => users; set => users = value; }
    }
}
