using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("name", "Pancakes");
var update = Builders<BsonDocument>.Update.Set("cookingTime", 25);

collection.UpdateOne(filter, update);
