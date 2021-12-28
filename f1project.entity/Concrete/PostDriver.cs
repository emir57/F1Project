namespace f1project.entity.Concrete
{
    public class PostDriver
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int DriverId { get; set; }
        public F1Driver Driver { get; set; }
    }
}