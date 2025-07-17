# Labs

1. Maak een bankapplicatie. Ik wil geld kunnen overmaken tussen twee rekeningen.
   - Console application
   - class Bank
   - class Rekening

2. Ik wil graag meerdere soorten rekeningen in de bankapplicatie:
   - `LopendeRekening` (niks bijzonders)
   - `Spaarrekening` waarvan niet betaald kan worden
   - `VipRekening` waar je korting krijgt op het te betalen bedrag

3. Vervang jullie class `Rekening` door een interface `IRekening` en krijg de applicatie weer werkend.

4. Extra oefening met overerving? Maak een nieuwe console-applicatie een lijst van medewerkers wordt bijgehouden. Een medewerker kan intern zijn met een vast maandbedrag als salaris, maar ook een consultant met een veel te hoog uurtarief. Toon een overzicht van maandelijkse kosten voor iedere medewerker.

5. Realiseer alle onderstaande opgaven realiseren met delegates/lambda-expressies.
   1. Maak een lijst met teststrings. Dit moeten getallen zijn die in een string staan, zowel hele als decimale getallen. Gebruik hiervoor een generic collection, bijv `List<>`.
   2. Druk alle strings af, niet met `foreach` maar m.b.v een lambda-expressie.
   3. Controleer of de lijst getallen bevat die kleiner dan 0 zijn.
   4. Controleer of de lijst alleen getallen bevat.
   5. Filter uit deze lijst een nieuwe lijst met strings waarin alle decimale getallen zitten .
   6. Converteer de nieuwe lijst naar een lijst van doubles.
   7. Tel alle doubles bij elkaar op en druk het resultaat af.

6. Unittest jullie bank, bijv. het transferren van geld tussen rekeningen. Maar ook `Withdraw()`/`Deposit()`-methoden lenen zich er helemaal prima voor. Zeker die ene van de `VipRekening` die korting geeft.

7. Laat de `VipRekening` een afhankelijkheid hebben richting een `IKortingService`. Breid de tests van je `VipRekening` uit met een mock die checkt of verschillende kortingen correct worden verwerkt.