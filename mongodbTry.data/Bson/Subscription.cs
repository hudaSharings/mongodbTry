using mongodbTry.core;

namespace mongodbTry.data.Bson
{
    [BsonCollection("subscription")]
    public class Subscription: Document<Subscription>, IDocument
    {
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public subscriptionInfo info { get; set; }
    }

    public class subscriptionInfo
    {
        public string endpoint { get; set; }
        public DateTime? expirationTime { get; set; }
        public SubscriptionKey Keys { get; set; }
    }
    public class SubscriptionKey
    {
        public string auth { get; set; }
        public string p256dh { get; set; }
    }
}
