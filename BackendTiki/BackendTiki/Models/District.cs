using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class District
    {
        private string districtId;
        private string provinceId;
        private string nameDistrict;
        [JsonIgnore]
        private Province province;
        [JsonIgnore]
        private ICollection<Wards> wards;
        public string DistrictId { get => districtId; set => districtId = value; }
        public string ProvinceId { get => provinceId; set => provinceId = value; }
        public string NameDistrict { get => nameDistrict; set => nameDistrict = value; }
        [JsonIgnore]
        public Province Province { get => province; set => province = value; }
        [JsonIgnore]
        public ICollection<Wards> Wards { get => wards; set => wards = value; }
    }
}
