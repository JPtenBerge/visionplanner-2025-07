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

wat de meeste developers belangrijk vinden bij het schrijven van code:

1. Leesbaarheid - als ik het lees, snap ik het?
2. Onderhoudbaarheid - patterns toegepast aanpassingen maken
3. Testbaarheid
4. Veiligheid - kan het gehackt worden?
5. Dat het werkt
6. Performance

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

## .NET

.NET Framework

- 2001
- multi-platform
  - maar Microsoft leverde enkel een runtime voor Windows
  - Mono voor Linux/MacOS

.NET Core

- 2016
- multi-platform MET Microsoft die een runtime leverde voor Windows, MacOS EN Linux
- v1.0 zeer beperkt
- v2.0
- v3 v3.1 v5 => .NET Core vanaf 5 hernoemd naar .NET

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

  - bij tests kun je herhalend initializatiewerk bijv. naar een aparte methode verplaatsen:

    ```cs
    [TestMethod]
    public void Bla_Iets_Success()
    {
      // Arrange
      ArrangePasswordStuff();

      // Act

      // Assert
    }

    public void ArrangePasswordStuff()
    {

    }
    ```

- pas [never nesting](https://www.youtube.com/watch?v=CFRhGnuXG-4) toe

  ```cs
  if (true)
  {
      if (true)
      {
          while (true)
          {

          }
      }
  }
  ```

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

### Interfaces

- Grafisch ding waar je op kan klikken/tappen
- In C#?
  - aangeven wat er geimplementeerd moet worden
  - vs class?
    - Er staat een I voor.
    - beschrijven wat iets heeft
    - geen implementatie
    - contract
    - alle implementaties volledig gescheiden van elkaar

```cs
IOpslagService service;
service.SlaOp();

class FileOpslagService : IOpslagService {}
class AzureOpslagService : IOpslagService {}
class AwsOpslagService : IOpslagService {}

class MockOpslagService : IOpslagService {} // unittesten
```

### Inheritance terminologie

- `class : interface` - implements
- `class : class` - extends
- `interface : interface` - extends
- `class : class, class, class` 🚩❌ - meerdere classes overerven mag niet in C# (gelukkig!)
- `class : class`, interface, interface - extends en implements en implements

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

### Typische opzet class

```cs
class Bla
{
	// fields
	// properties

	// constructors

	// methods
	// - happy flow main method
	// - supporting stuff
}
```

### Delegates

.NET heeft 3 soorten delegates:

- `Action<T>` - doe iets. geen returnwaarde.
- `Predicate<T>` - checken, returnwaarde boolean.
- `Func<T, R>` - returnwaarde is instelbaar

### Lambdas

- een Griekse letter
- in C#?
  - minifunctie `x => 2 * x`
  - minimethode / inline methode
  - mini-interface

## Unittesten

- testen van backend. ook frontend.
- testen van 1 component
  - testen van een pad van 1 methode
- mocken! geen integratie, maar mocken.
- toetsen dat het systeem werkt.
- **zo klein mogelijk stukje code / afzonderlijk / geisoleerd**
- zorgen voor goede code coverage
  - zegt wat over hoeveel van het systeem getest is
  - 80%? 90%?
  - een leuk metriekje, maar niet heilig. Het vertelt niet het hele verhaal.
    ```cs
    try
    {
      service.Do();
    }
    catch(Exception ex) {}
    ```
- mutation testing?

Testframeworks:

- NUnit
- MSTest
- xUnit

Verschillen? Vroeger best wat, vooral met data-driven/parameterized tests ([vooral MSTest met z'n `\[DataSource\]`](https://learn.microsoft.com/en-us/visualstudio/test/how-to-create-a-data-driven-unit-test?view=vs-2022)). Vandaag de dag? Nauwelijks meer.

FluentAssertions:

- komt vanaf versie 8 met dure licentie
- [AwesomeAssertions](https://awesomeassertions.org/) is een erg toffe drop-in replacement
- is heel prettig voor assertions waar je objecten/lijsten van objecten vergelijkt
  ```cs
  actualDto.Should().BeEquivalentTo(expectedDto);
  ```

### Mocken

- bij het unittest dat je de dependencies "wegmockt"
  - database
  - Azure
  - API
  - andere class
- mockframeworks
  - Rhino Mocks  <== heul oud
  - Moq - `new Mock<IBla>()`  `Mock.Of<...>()`
  - FakeItEasy
  - NSubstitute

Dankzij mockframeworks hoef je niet handmatig een mock te maken en daarbij alle interacties te registreren:

```cs
class MijnService : IService
{
	public void Doe() {}
}

class MijnFakeService : IService
{
	public bool HasDoeBeenCalled = false;

	public void Doe()
	{
		HasDoeBeenCalled = true;
	}
}
```

Bijhouden dat een methode is aangeroepen, hoe vaak hij is aangeroepen, met welke parameters, returnwaarde(n) instellen, exceptions configureren, allemaal een hoop werk als dat voor iedere methode in iedere class moet gebeuren.

Wat is lastig te mocken?

- `static` zaken: `DateTime.Now`, `File.AppendAllText()`, wat je zelf `static` maakt
- classes die niet werken met interfaces, maar met concrete classes
- classes zonder een interface om een nep-versie mee te maken. Kan wel:
  ```cs
  new Mock<BestaandeService>();
  ```
  Maar `BestaandeService` moet dan wel z'n methoden definieren met `virtual`. Een interface is sowieso fijner.
- [TypeMock](https://www.typemock.com/) biedt wel uitkomst in sommige van deze gevallen (maar betaald).

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



## Frontend

"fullstack developer"

Frontend

- UI/UX
- "het zien" van wat je maakt

Backend

- vaak moeilijkere stukken code
  - algoritmen
  - multithreading
  - 300 concurrent gebruikers
  - schaalbaarheid

### Tooling

- Visual Studio Code: texteditor
- Node.js frontend tooltjes
  - prettier: opinionated code formatter
  - ESLint: static code analysis
  - testing: karma jasmine jest vitest mocha chai sinon
  - buildtools:
    - gulp
      ```ts
      gulp.src("src/**/*.ts").pipe(tsc()).pipe(gulp.dest("./dist"));
      ```
    - grunt
    - module bundlers:
      - webpack (meest gebruikt)
      - vite (meest modern)
  - webserver: express

CSS-ontwikkelingen

- SCSS voor mooiere syntax
- Tailwind: moderne manier om styles uit te drukken.
  ```html
  <div class="bg-blue-400 p-4 m-6 hover:bg-blue-900"></div>
  ```
  Hergebruik nog steeds wel mogelijk voor "echte" herbruikbare UI-elementen [`@layer`](https://tailwindcss.com/docs/adding-custom-styles#adding-base-styles) en [`@layer components`](https://tailwindcss.com/docs/adding-custom-styles#adding-component-classes):
  ```css
  @layer utilities {
    h1 {
      @apply text-7xl;
    }
  }
  @layer components { .card { /* ... */ } }
  ```
- Scoped CSS

TypeScript

- van Microsoft
- zeer uitgebreide poging om te dynamiek/flexibliteit te reguleren
- zeer fijne toevoeging voor projecten die jarenlang meegaan en waar 8+ man aan werken

### SPA-libraries

SPA - hoge interacties gebruiksvriendelijkheid

- React - Meta / facebook
- Angular - Google
- Blazor - Microsoft C#
- Knockout - Steve Sanderson - Microsoft
- Svelte - Rich Harris - Vercel
- Vue - Evan You - Google
- Solid - Ryan Carniato - Vercel
- Qwik - Misko Hevery - Google
- Web Components: Lit - Google

waarom niet gewoon vanilla JS?

- libraries/frameworks verhogen leesbaarheid in het algemeen
- DOM API: Document Object Model API
  - is een draak van een API die de leesbaarheid van je code niet ten goede komt.
  - testbaarheid is ook vaak lastig, want je moet vaak de hele DOM wegmocken

### Appdevelopment

- native apps
  - beste UX
  - twee devteams Swift Kotlin
- compile-to-native
  - React Native
  - Flutter Google
  - 1 devteam
  - .NET MAUI
- web tussenlaagjes
  - capacitor
  - phonegap
  - ionic
- web native - PWA
