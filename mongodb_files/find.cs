using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var recipes = collection.Find(new BsonDocument()).ToList();
foreach (var recipe in recipes)
{
    Console.WriteLine(recipe);
}
