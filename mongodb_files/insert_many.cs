using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var recipes = new List<BsonDocument>
{
    new BsonDocument
    {
        { "name", "Spaghetti" },
        { "cookingTime", 30 },
        { "ingredients", new BsonArray { "Spaghetti", "Tomato Sauce", "Cheese" } },
        { "steps", new BsonArray { "Boil water", "Cook spaghetti", "Serve with sauce" } }
    },
    new BsonDocument
    {
        { "name", "Salad" },
        { "cookingTime", 15 },
        { "ingredients", new BsonArray { "Lettuce", "Tomatoes", "Cucumber", "Olive Oil" } },
        { "steps", new BsonArray { "Chop vegetables", "Mix ingredients", "Serve fresh" } }
    },
    new BsonDocument
    {
        { "name", "Grilled Chicken" },
        { "cookingTime", 30 },
        { "ingredients", new BsonArray { "Chicken", "Spices", "Oil" } },
        { "steps", new BsonArray { "Marinate chicken", "Grill for 30 mins", "Serve hot" } }
    }
};

collection.InsertMany(recipes);
