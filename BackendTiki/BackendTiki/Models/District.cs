namespace BackendTiki.Models
{
    public class District
    {
        private string districtId;
        private string provinceId;
        private string nameDistrict;
        
        private Province province;
        private ICollection<Wards> wards;
        public string DistrictId { get => districtId; set => districtId = value; }
        public string ProvinceId { get => provinceId; set => provinceId = value; }
        public string NameDistrict { get => nameDistrict; set => nameDistrict = value; }
        
        public Province Province { get => province; set => province = value; }
        public ICollection<Wards> Wards { get => wards; set => wards = value; }
    }
}
