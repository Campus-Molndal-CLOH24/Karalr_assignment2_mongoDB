using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("cookingTime", 30);
var update = Builders<BsonDocument>.Update.Mul("cookingTime", 2);

collection.UpdateMany(filter, update);
