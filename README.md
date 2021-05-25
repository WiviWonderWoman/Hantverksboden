# Hantverksboden - Dynamiska Webbsystem 1 - December 2020
## Inlämning: Hantverksboden 1.0 
100/100 (G)
### Scenario
I denna uppgift ska du skapa din första riktiga webbapplikation i C#, kunden är i detta fallet en mycket skicklig hantverkare som i många år sålt sina skapelser lokalt, men nu vill nå ut till en bredare publik, och därför anlitat dig som webbutvecklare.

Hantverkarn, d.v.s. din kund i denna uppgift, vill komma igång snabbt med en hemsida där hen kan visa upp sina skapade altser i en digital hantverksbod - ungefär som tillgängliga produkter i en vanlig webbbutik. I framtiden kommer ni vidareutveckla hemsidan med stöd för beställningar - men klart till denna inlämning vill hen först sen en ganska enkel sida.

Ditt mål i denna uppgift är att utveckla en dynamisk webbapplikation med ASP.NET och designmönstret MVC.

Du bestämmer själv vilken typ av Hantverkare som är din kund och vilka alster som finns tillgängliga på hemsidan.
### Kravlista
* Lösningen ska bestå av en applikation skriven i C# som är körbar med .NET Core
* Applikationen använder ASP.NET för att starta en webbserver
* En sida som går att besöka från webbservern listar samtliga alster (hantverk) som finns tillgängliga i hantverksboden
* En annan sida som går att besöka från webbservern listar hantverksbodens kontaktuppgifter
* Applikationen ska vara vara strukturerad med designmönstret "Model, View, Controller" (MVC)
* Dom tillgängliga hantverken är skapade med en lämplig *datastruktur* och på en lämplig plats för att senare uppdatera programmet.

## Inlämning: Hantverksboden 2.0
95/100 (VG)
### Scenario
Du ska i denna uppgift fortsätta att förbättra hemsidan du skapat till hantverkaren från föregående inlämningsuppgift i modul ett. Hantverkaren har lämnat dig följande meddelande:
> Hej kära utvecklare! 
> Jag önskar att det var enklare att jobba med flera olika typer produkter, vi kanske kan särskilja dem med olika "kategorier", jag gör ju många olika konstverk i min hantverksbod. Jag har förstått att vi inte har någon databas? Kanske vore bra att lägga till! Dessutom skulle jag vilja att vi började räkna antalet besök till sidan... så vi vet hur många personer jag når ut till.
> 
> Mvh Din Hantverkare

Att tänka på vid detta förändringsarbete
Läsa hela uppgiftsbeskrivningen innan du börjar förändra din kod, och använd GIT flitligt för att ev. kunna backa din kod till en fungerande version. Någonstans i din kod behäver databasen fyllas med data, och olika produkter ska gå att visa baserad på deras "kategori". Det är lämpligt att tydligt sklja på vad som är domänlogik och vad som tillhör användargränssnittet, för att göra din kod testbar - exempelvis bör filtreringen enligt kategori vara en del av domänlogiken. En kategori-sida kan exempelvis vara en för tavlor, en annan för skulpturer och en tredje för smycken.

#### Uppdatering: Använda "UseInMemoryDatabase" för Entity Framework
Som krav i uppgiften finns att använda Entity Framework med UseInMemoryDatabase i Startup.cs
#### Uppdatering: Räkna antalet besökare?
Hantverkaren ber i sitt brev om funktionalitet för att räkna antalet besökare, detta var tidigare en del av kravlistan men togs bort, du behöver alltså inte skapa funktionalitet för detta. Följ nedanstående kravlista. Scenariot är till för att ge en starkare koppling till vad bakgrunden till uppgiften skulle kunna vara yrkeslivet.
### Kravlista
* Lösningen ska vid inlämning vara körbar med .NET Core (version 3 eller 5)
* Den inlämnade lösningenen är en vidareutveckling av inlämning i föregående uppgift
* Minst fyra ytterligare sidor ska ha lagts till i lösningen, samtliga ska visa produkter av en given kategori.
* Produkterna som visas på alla 5 sidor ska vara hämtade från en databas via Entity Framework
* Entity Framework ska vara användas med databaskoppling till en tillfällig databas via metoden `UseInMemoryDatabase` i Startup.cs
* Minst två enhetstester har skapats till lösningen
* Ett enhetstest kontrollerar så att en produkter av en given kategori kan filtreras ut från domänlogiken
* Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf
* reflections-filen ska under rubrik "Ursprung" innehålla en kort analys (1-3 paragrafer) över hur applikaten var uppbyggd i början av arbetet. Svara på vilka delar som var svåra respektiva enkla att uppdatera i detta arbete.
* reflections-filen ska under rubriken "Resultat" en kort analys över förändringarna i kodstrukturen när du lämnar in, fokusera på nya funktioner och egenskaper som underlättar underhåll samt vidareutveckling. Kom ihåg att motivera dina ställningstaganden! (2-4 paragrafer).
* reflections-filen innehåller en lista över skapade Enhetstester samt motiverar på vilket sätt de bidarar till att göra applikatenen enklare att underhålla och vidareutveckla
