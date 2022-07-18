using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class Province
    {
        private string provinceId;
        private string nameProvince;

        [JsonIgnore]
        private ICollection<District> districts;
        public string ProvinceId { get => provinceId; set => provinceId = value; }
        public string NameProvince { get => nameProvince; set => nameProvince = value; }
        [JsonIgnore]
        public ICollection<District> Districts { get => districts; set => districts = value; }
    }
}
