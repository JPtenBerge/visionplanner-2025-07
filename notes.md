# Notes

## Architectuur

Frontend?

- voorkant
- zichtbare van lamborghini

Backend?

- achterkant
- onder de motorkap

Paradigmas der webdevelopment:

- MPA - traditionele webapplicatie. Libraries/frameworks:
  - ASP.NET WebForms/MVC/Core
  - Spring (Java)
  - PHP
- SPA - webapp met hoog niveau aan interactiviteit en gebruiksvriendelijkheid. Libraries/frameworks:
  - React
  - Angular
  - Vue
  - Svelte
  - AngularJS
  - Knockout
  - Solid
  - Qwik
  - Blazor <== C# 2020 "hello world" 7MB
- Server-Side Rendering (SSR)
  - complementair aan de SPA
  - server rendert de allereerste pagina
  - libraries: Next.js (React), Nuxt.js (Vue), @angular/ssr, SolidStart, QwikCity ASP.NET Core
- Static Site Generation (SSG)
  - .html-bestandjes
  - catalogus
  - bol.com wehkamp
    - bol.com/product/auto-1i4i83923
      => database
      => template renderen
    - tijdens de build/pipeline `auto-1i4i83.html` genereren

Qua termen, API (Application Programming Interface) heeft meerdere betekenissen:

- deze library die ik gebruik, heeft een methode `Bla` met `x` en `y` en `z` parameters
- endpoint die JSON/XML ontvangt/terugstuurt
  - REST API

### HTTP

- HTTP/1.1 - gaat al even mee
- HTTP/2 - SPDY
  - alleen maar HTTPS
  - multiplexing - TCP-kanaal hergebruiken
- HTTP/3 - Quality UDP Internet Connections
  - alternatief op TCP
    - TCP checkt of berichten goed aan zijn gekomen, maar wel op een wat trage manier

Data over de lijn tussen front- en backend is nog altijd "gewoon" HTTP. De data zelf is meestal JavaScript Object Notation (JSON), soms nog XML:

```json
{
  "name": "JP",
  "age": 38
}
```

Ook kunnen we tegenwoordig realtime communicatie inzetten:

- WebSocket `ws://` `wss://`
  - libraries: socket.io SignalR <== WebSocket
- WebTransport (experimenteel)

REpresentational State Transfer

HTTP verbs

- GET ophalen
- POST toevoegen
- DELETE verwijderen
- PATCH stuk/deel wijzigen
- PUT geheel wijzigen

PUT api/v1/car/wq7r489er8cvuoxic { make: '...', model: '...' }

C10K problem

Statuscodes:

- 2xx - SUCCESS
  - 200 OK
  - 201 Created
  - 204 No content DELETE
- 3xx - redirects
  - 301/302 temporary/permanent
- 4xx - client error (het ligt aan JOU)
  - 401 Unauthorized
  - 403 Forbidden
  - 404 Not Found
  - 405 Method Not Allowed - PUT => endpoint die geen PUT verwerkt
  - 409 Conflict
  - 415 MediaType not supported - XML => endpoint die geen XML parset
  - 418 I'm a teapot
- 5xx - server error (het ligt aan MIJ als server)
  - 500 Internal Server Error
  - 502 Gateway error

## AI

Artificial General Intelligence

- zelf doen / autonoom
- zo slim als een mens, kan wat een gemiddeld mens zou kunnen

Artificial Super Intelligence

- Terminator's Skynet
- ruim slimmer op elk intellectueel/emotioneel vlak

"vibe coding"

- achterover leunen en de AI het werk laten doen
- hier is men eigenlijk alleen maar geinteresseerd in het resultaat, niet in de code erachter.
  - voor hobbyprojectjes of een snel proof-of-conceptje, prima
  - voor professionele projecten die jarenlang onderhouden worden door 10 man _vind ik_ dit geen reele werkwijze

## C#

- object-georienteerde taal
- gebruikt objecten
- legoblokjes
- heul veul classes
  - functioneel: Fiets Muis Laptop Product
  - technisch: endpoint, validator, databasecontext, middleware, services met DI, DbContext, configuratie van entities, converters, parsers, serializers, ...

## Vuistregels "netjes programmeren"

Bij "grote" webapplicaties van bijv. 300 pagina's is hergebruik van code erg belangrijk. Paar simpele vuistregels voor hoe je code structureert:

- max. 300 regels per bestand
- ik wil niet verticaal/horizontaal moeten scrollen voor 1 methode
- pas [never nesting](https://www.youtube.com/watch?v=CFRhGnuXG-4) toe

Verder kunnen SOLID-principes helpen:

- Single responsibility
- Open-closed principle
- Liskov substitution
- Interface segregation
  - kleine interfaces!
- Dependency inversion "low coupling, high cohesion"
  - testing mocken

## Object-orientatie

Pilaren van OO:

- abstractie
- encapsulatie <== vaak gerealiseerd middels properties
- polymorphisme
- inheritance

## C# technisch

### visibility modifiers

- `public` - iedereen
- `internal` - binnen het project
- `private` - alleen de class zelf
- `protected` - subclasses

datatypes:

- `string`: text "hallo daar"
- `long` 2^64
- `int`: getal 2^32
  - -2.147.xxx.xxx - +2.147.xxx.xxx
- `uint`: 0 - 4294967296
- `bool`: true/false
- datatype in arrayvorm: `string[]` `int[]` `Human[]`
- `char` 'a'

kommagetallen:

- `float`: 2^32
- `double`: 2^64
- `decimal`: 2^128

### Value en reference types

**Value types**

- worden op de stack opgeslagen
  - moet dus bekend hoeveel bits/bytes ze in beslag nemen
- alle getallen
- `bool`
- `char`
- `enum`

**Reference types**

- alles wat geen value type is
- `string`
- alle classes

## Overig

`static` is niet evil, maar is wel vervelend om te mocken bij het testen. Design pattern singleton kan daar uitkomst bieden:

```cs
public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
```
