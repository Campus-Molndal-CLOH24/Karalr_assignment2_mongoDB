

Struktur och Implementering av MongoDB-filer

1. **insert_one.cs** (Lägga till ett recept)

```csharp
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
```

2. **find.cs** (Visa alla recept)

```csharp
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
```

3. **update_one.cs** (Uppdatera tillagningstiden för "Pancakes")

```csharp
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("name", "Pancakes");
var update = Builders<BsonDocument>.Update.Set("cookingTime", 25);

collection.UpdateOne(filter, update);
```

4. **delete_one.cs** (Ta bort receptet "Pancakes")

```csharp
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("name", "Pancakes");
collection.DeleteOne(filter);
```

5. **insert_many.cs** (Lägga till exakt 3 recept)

```csharp
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
```

6. **update_many.cs** (Uppdatera tillagningstiden för alla recept med 30 minuter)

```csharp
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("cookingTime", 30);
var update = Builders<BsonDocument>.Update.Mul("cookingTime", 2);

collection.UpdateMany(filter, update);
```

7. **delete_many.cs** (Ta bort alla recept med tillagningstid på 60 minuter)

```csharp
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

var filter = Builders<BsonDocument>.Filter.Eq("cookingTime", 60);
collection.DeleteMany(filter);
```

8. **delete_all.cs** (Ta bort alla recept med wildcard)

```csharp
using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("recipeDB");
var collection = database.GetCollection<BsonDocument>("recipes");

collection.DeleteMany(new BsonDocument());
```
