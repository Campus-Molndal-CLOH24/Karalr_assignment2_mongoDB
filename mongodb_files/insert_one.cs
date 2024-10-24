using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var recipe = new BsonDocument
{
    { "name", "Pancakes" },
    { "cookingTime", 20 },
    { "ingredients", new BsonArray { "Flour", "Milk", "Eggs", "Sugar" } },
    { "steps", new BsonArray { "Mix ingredients", "Cook on pan", "Serve hot" } }
};

collection.InsertOne(recipe);
