using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DockerNetCore.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [DisplayName("Book Name")]
        [Required]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        [Required]
        public string Author { get; set; }
    }
}