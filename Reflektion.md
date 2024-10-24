# Inlämningsrapport

## Databasdesign

### Beskriv hur du har strukturerat din data i MongoDB
Jag har strukturerat data genom att skapa en samling ("collection") kallad "recipes", där varje dokument representerar ett enskilt recept. Dokumenten innehåller fält som "name", "cookingTime", "ingredients", och "steps". Varje fält kan ha olika typer av data, till exempel är "ingredients" och "steps" arrays som tillåter flera värden för respektive fält.

### Jämför kort hur denna struktur skiljer sig från hur du skulle ha gjort i en relationsdatabas
I en relationsdatabas skulle jag ha skapat flera tabeller: en för recepten med grundläggande information som namn och tillagningstid, och separata tabeller för ingredienser och tillagningssteg. Dessa tabeller skulle kopplas samman genom främmande nycklar för att skapa relationer, vilket är annorlunda jämfört med MongoDB där alla dessa data kan finnas inom ett enda dokument.

### Nämn några skillnader mellan relationsdatabaser och dokumentdatabaser
- Relationsdatabaser använder ett fast schema, medan dokumentdatabaser är schemalösa och flexibla.
- Dokumentdatabaser som MongoDB är mer skalbara och kan hantera stora datamängder horisontellt, medan relationsdatabaser vanligtvis är vertikalt skalbara.
- I relationsdatabaser kan komplexa frågor utföras enklare tack vare stöd för joins, medan i MongoDB måste relationer hanteras manuellt genom att referera dokument till varandra.

### Förklara vad collection, document och field är
- **Collection**: En samling av dokument i MongoDB, motsvarande en tabell i en relationsdatabas.
- **Document**: En enhet med data i form av nyckel-värde-par, motsvarande en rad i en tabell. Varje dokument kan ha en unik struktur.
- **Field**: Ett fält är ett nyckel-värde-par i ett dokument, där nyckeln är namnet på fältet och värdet är den data som lagras.

### Beskriv vad det är för skillnad på BSON och JSON
BSON är ett binärt format som används av MongoDB för att lagra dokument. Det är mer kompakt än JSON och kan lagra fler datatyper, såsom datum och binär data. JSON är ett textbaserat format som är lätt att läsa och utbyta, men mindre effektivt för lagring och bearbetning i stora datamängder jämfört med BSON.

## Analys och reflektion

### Analysera databasdesignen och nämn några fördelar och några nackdelar med denna typ av databas
- **Fördelar**: MongoDB:s flexibilitet gör att man snabbt kan förändra strukturen utan att påverka tidigare data. Det är också bra för att hantera ostrukturerad eller halvstrukturerad data. Skalbarheten gör det användbart i applikationer med stora datamängder.
- **Nackdelar**: Avsaknaden av starka relationer kan leda till inkonsistens i datan. Dessutom saknar MongoDB en del av den avancerade funktionalitet som finns i relationsdatabaser, såsom komplexa transaktioner och relationshantering.

### Reflektera över möjligheter och begränsningar i MongoDB
MongoDB ger stora möjligheter när det gäller skalbarhet och flexibilitet. Det är perfekt för applikationer där datans struktur inte är fast och kan förändras över tid. En begränsning är att det inte passar bra för system där datarelationer och integritet är viktiga eftersom det saknar stöd för joins och avancerade transaktioner.

## Reflektion och utvärdering

### Vad lärde du dig genom att genomföra projektet?
Jag lärde mig hur man använder MongoDB för att hantera dokumentorienterade databaser och hur flexibel dess schemalösa natur är. Jag fick också en förståelse för fördelarna med att använda dokumentdatabaser för vissa typer av applikationer, särskilt de som kräver hög skalbarhet och snabbhet.

### Vilka möjligheter ser du för framtida projekt baserat på denna erfarenhet?
Denna erfarenhet öppnar upp möjligheter för att använda MongoDB i projekt som hanterar stora datamängder i realtid, såsom IoT, e-handel eller sociala medier. Den flexibilitet och skalbarhet som MongoDB erbjuder gör det möjligt att snabbt utveckla och anpassa applikationer.
