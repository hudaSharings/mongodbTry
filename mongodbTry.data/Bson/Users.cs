namespace mongodbTry.data.Bson
{
    [BsonCollection("users")]
    public class Users : Document<Users>, IDocument
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public List<Organization> Organizations { get; set; }
    }

    


}
