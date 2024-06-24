using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace mongodbTry.data
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }
        DateTime CreatedOn { get; }
        string? OrgId { get; set; }
    }
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedOn => Id.CreationTime;
        public string? OrgId { get; set; }
    }
    public class Document<T> :MongoRepository<T>, IMongoRepository<T> where T : IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedOn => Id.CreationTime;
        public string? OrgId { get; set; }
    }
  


}
