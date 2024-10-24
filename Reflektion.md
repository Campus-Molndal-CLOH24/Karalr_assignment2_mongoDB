Databasdesign
Beskriv hur du har strukturerat din data i MongoDB
--- Skriv ovanför och ta inte bort denna raden ---
I MongoDB har jag använt en samling (collection) som heter "recipes", där varje recept lagras som ett dokument. Varje dokument innehåller fält som namn, tillagningstid, ingredienser och tillagningssteg. Ingredienser och tillagningssteg är representerade som fält med värden av typen array, vilket gör det möjligt att lagra flera värden för dessa attribut.

Jämför kort hur denna struktur skiljer sig från hur du skulle ha gjort i en relationsdatabas
--- Skriv ovanför och ta inte bort denna raden ---
I en relationsdatabas skulle jag ha strukturerat detta i flera tabeller. Exempelvis skulle en tabell innehålla receptinformation (namn, tillagningstid) och en annan tabell skulle hantera ingredienser, där varje ingrediens är kopplad till ett recept via en främmande nyckel (foreign key). Detta skiljer sig från MongoDB där all data om ett recept kan lagras som ett enda dokument.

Nämn några skillnader mellan relationsdatabaser och dokumentdatabaser
--- Skriv ovanför och ta inte bort denna raden ---
Struktur: Relationsdatabaser använder tabeller med rader och kolumner medan dokumentdatabaser (som MongoDB) lagrar data som dokument i samlingar.
Datamodell: Relationsdatabaser kräver ett schema, medan dokumentdatabaser är schemalösa, vilket ger större flexibilitet i hur data organiseras.
Prestanda: Dokumentdatabaser kan vara snabbare vid hantering av ostrukturerad eller semi-strukturerad data, medan relationsdatabaser ofta är bättre på att hantera komplexa frågor och relationer.

Förklara vad collection, document och field är
--- Skriv ovanför och ta inte bort denna raden ---
Collection: En samling i MongoDB är en grupp av dokument, liknande en tabell i en relationsdatabas.
Document: Ett dokument är en enhet som innehåller data och motsvarar en rad i en tabell. Det är ett BSON-objekt som består av fält och värden.
Field: Ett fält är en nyckel i ett dokument som lagrar ett specifikt värde, ungefär som en kolumn i en tabell.

Beskriv vad det är för skillnad på BSON och JSON
--- Skriv ovanför och ta inte bort denna raden ---
BSON (Binary JSON): BSON är ett binärt format för att representera JSON-liknande dokument. Det används av MongoDB eftersom det är mer effektivt för lagring och överföring, och det tillåter snabbare uppslag.
JSON (JavaScript Object Notation): JSON är ett textbaserat format som används för att överföra och lagra data. BSON innehåller extra metadata och stöd för fler datatyper än JSON.

Analys och reflektion
Analysera databasdesignen och nämn några fördelar och några nackdelar med denna typ av databas
--- Skriv ovanför och ta inte bort denna raden ---
Fördelar: MongoDB
schemalösa natur gör det lättare att anpassa sig till förändrade databehov, och dess förmåga att lagra komplexa dokument i ett fält (som arrays) gör det mer flexibelt än relationsdatabaser. Det är också mycket skalbart för stora dataset.
Nackdelar: Avsaknaden av fasta relationer kan göra det svårare att upprätthålla dataintegritet, och komplexa frågor kan vara svårare att implementera än i en relationsdatabas. Dessutom kan lagringseffektiviteten bli sämre eftersom varje dokument måste inkludera sitt schema i varje instans.

Reflektera över möjligheter och begränsningar i MongoDB
--- Skriv ovanför och ta inte bort denna raden ---
Möjligheter: MongoDB erbjuder stor flexibilitet i datamodellering och kan hantera stora mängder data med hög prestanda genom sin distribuerade arkitektur. Det är också lämpligt för applikationer med snabbt föränderliga krav och dynamiska datastrukturer.
Begränsningar: MongoDB saknar inbyggt stöd för avancerade transaktioner och relationella dataoperationer som är enklare att hantera i relationsdatabaser.

Reflektion och utvärdering
Vad lärde du dig genom att genomföra projektet?
--- Skriv ovanför och ta inte bort denna raden ---
Genom att genomföra detta projekt lärde jag mig hur MongoDB fungerar i praktiken, hur CRUD-operationer implementeras, och hur en dokumentdatabas skiljer sig från relationsdatabaser. Jag fick också en bättre förståelse för fördelarna och nackdelarna med schemalös design.

Vilka möjligheter ser du för framtida projekt baserat på denna erfarenhet?
--- Skriv ovanför och ta inte bort denna raden ---
 Med den erfarenhet jag har fått kan jag se potentialen att använda MongoDB för att bygga flexibla och skalbara lösningar för applikationer som behöver hantera ostrukturerad data. Jag ser också möjligheten att kombinera MongoDB med andra tekniker för att bygga hybridlösningar där vissa delar av systemet använder relationsdatabaser och andra delar använder dokumentdatabaser.
