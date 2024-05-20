namespace AnyarT.ViewModels.Sliders
{
    public class GetSliderAdminVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Subtitle1 { get; set; }

        public string Subtitle2 { get; set; }

        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedTime { get; set; }
        public string UpdatedTime { get; set; }
    }
}
