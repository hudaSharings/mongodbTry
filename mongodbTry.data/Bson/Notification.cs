namespace mongodbTry.data.Bson
{
    [BsonCollection("notification")]
    public class Notification : Document<Notification>, IDocument
    {
         public string Name { get; set; }
        public bool IsDefault { get; set; }
    }


}
