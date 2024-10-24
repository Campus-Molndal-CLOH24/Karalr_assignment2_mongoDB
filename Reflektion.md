--- Skriv ovanför och ta inte bort denna raden ---

**Beskriv hur du har strukturerat din data i MongoDB**  
Jag har strukturerat data genom att skapa en samling som heter "recipes", där varje enskilt recept lagras som ett dokument. Varje receptdokument innehåller fält för namn, tillagningstid, ingredienser och tillagningssteg. Ingredienser och tillagningssteg är lagrade som array-fält, vilket tillåter flera värden för dessa attribut.

--- Skriv ovanför och ta inte bort denna raden ---

**Jämförelse med en relationsdatabas**  
I en relationsdatabas hade jag skapat flera tabeller, där en tabell skulle innehålla grundläggande information om receptet (som namn och tillagningstid), och andra tabeller skulle användas för att hantera ingredienser och tillagningssteg. Dessa tabeller skulle kopplas samman med främmande nycklar, vilket skulle skapa en tydligare databasstruktur, men samtidigt kräva fler relationer och tabeller än i MongoDB.

--- Skriv ovanför och ta inte bort denna raden ---

**Skillnader mellan relationsdatabaser och dokumentdatabaser**  
- **Schema och flexibilitet**: Relationsdatabaser har ett fast schema, vilket innebär att du måste definiera exakt vilka kolumner och datatyper som ska användas. MongoDB har ett schemalöst tillvägagångssätt, vilket innebär att strukturen på data kan variera från ett dokument till ett annat i samma samling.
- **Prestanda vid skalning**: Dokumentdatabaser som MongoDB är designade för horisontell skalning, vilket gör det enklare att distribuera data över flera servrar. Relationsdatabaser kan också skalas, men horisontell skalning är svårare att implementera.
- **Relationshantering**: I relationsdatabaser är det lättare att hantera relationer mellan data, exempelvis genom att använda främmande nycklar och relationstabeller. I MongoDB måste relationer hanteras genom att lägga till referenser i dokument, vilket kan vara mer manuellt.

--- Skriv ovanför och ta inte bort denna raden ---

**Vad är collection, document och field?**  
- **Collection**: En samling (collection) är en grupp dokument i MongoDB, ungefär som en tabell i en relationsdatabas.
- **Document**: Ett dokument är en enhet som innehåller data och motsvarar en rad i en tabell. Varje dokument består av fält och värden, och det kan ha olika strukturer inom samma samling.
- **Field**: Ett fält (field) är en nyckel i ett dokument som lagrar ett specifikt värde, som kan vara av olika typer (t.ex. strängar, siffror, arrays, eller till och med andra dokument).

--- Skriv ovanför och ta inte bort denna raden ---

**Skillnad på BSON och JSON**  
BSON (Binary JSON) är ett binärt format som MongoDB använder för att lagra data. Det liknar JSON, men är mer kompakt och effektivt för att lagra stora mängder data. BSON stöder även fler datatyper än JSON, vilket gör det mer användbart i en databas. JSON å andra sidan är ett lättviktigt textformat som används för att utbyta data mellan system, men saknar vissa av de optimeringar som BSON har.

--- Skriv ovanför och ta inte bort denna raden ---

**Analys och reflektion**  
- **Fördelar**: MongoDB är väldigt flexibelt eftersom det inte kräver ett fördefinierat schema, vilket gör det lättare att hantera ostrukturerad data och snabbt ändra strukturen på dokument utan att behöva ändra hela databasen. Dessutom är det bra för att hantera stora datamängder och att skala upp horisontellt när belastningen ökar.
- **Nackdelar**: Avsaknaden av fasta relationer kan göra det svårt att upprätthålla dataintegritet, särskilt när man har mycket beroenden mellan olika dokument. Dessutom kan det vara svårare att göra komplexa frågor och analys, eftersom MongoDB inte har samma avancerade frågefunktioner som SQL.

--- Skriv ovanför och ta inte bort denna raden ---

**Möjligheter och begränsningar i MongoDB**  
- **Möjligheter**: MongoDB är bra för applikationer där flexibilitet är viktigt och där strukturen på data förändras ofta. Det passar även för realtidsapplikationer där snabb åtkomst till stora mängder data är avgörande. Dess schemalösa natur gör att man snabbt kan lägga till nya funktioner och anpassa sig efter förändrade behov.
- **Begränsningar**: MongoDB är inte det bästa valet för applikationer där komplexa transaktioner och starka relationer mellan data är nödvändiga. Stöd för avancerade funktioner som joins och ACID-egenskaper är begränsat i jämförelse med relationsdatabaser.

--- Skriv ovanför och ta inte bort denna raden ---

**Vad lärde du dig genom att genomföra projektet?**  
Jag lärde mig mycket om hur MongoDB fungerar och hur man hanterar data i en dokumentorienterad databas. Jag fick också en bättre förståelse för hur man strukturerar data utan att behöva definiera ett strikt schema, och hur detta kan användas i projekt som kräver hög flexibilitet.

--- Skriv ovanför och ta inte bort denna raden ---

**Vilka möjligheter ser du för framtida projekt baserat på denna erfarenhet?**  
Denna erfarenhet öppnar upp för användning av MongoDB i projekt där data kan vara dynamisk och där skalbarhet är viktigt. Jag kan se att det skulle vara användbart i applikationer som hanterar realtidsdata, till exempel i IoT-lösningar eller sociala medieplattformar, där stora mängder data behöver bearbetas snabbt och flexibelt.
