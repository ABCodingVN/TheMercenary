namespace BackendTiki.Models
{
    public class Province
    {
        private string provinceId;
        private string nameProvince;

        private ICollection<District> districts;
        public string ProvinceId { get => provinceId; set => provinceId = value; }
        public string NameProvince { get => nameProvince; set => nameProvince = value; }
        public ICollection<District> Districts { get => districts; set => districts = value; }
    }
}
