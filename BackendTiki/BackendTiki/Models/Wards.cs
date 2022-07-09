namespace BackendTiki.Models
{
    public class Wards
    {
        private string wardsId;
        private string districtId;
        private string nameWards;
      /*  private District district;*/
        public string WardsId { get => wardsId; set => wardsId = value; }
        public string DistrictId { get => districtId; set => districtId = value; }
        public string NameWards { get => nameWards; set => nameWards = value; }
/*        public District District { get => district; set => district = value; }*/
    }
}
