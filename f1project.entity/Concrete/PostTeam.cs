namespace f1project.entity.Concrete
{
    public class PostTeam
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int TeamId { get; set; }
        public F1Team Team { get; set; }
    }
}