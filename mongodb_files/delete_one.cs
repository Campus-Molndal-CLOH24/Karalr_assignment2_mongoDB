using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("name", "Pancakes");
collection.DeleteOne(filter);
