# Redovisning och Utförande

#### Utfört av: Colin Farkas

Jag har börjat utifrån *OrderService.cs* klassen. Där har jag förtydligat variabelnamn, och med hjälp av **DRY** och **KISS** principen dels skapat private props för de olika stadier av en order (*Attempt, Success och Failed*), men även refaktorerat bort if-else stycket med hjälp av **Open Closed Principle (sOlid)** för att få större flexibilitet om man i framtiden tillsätter nya ordertyper.

För att hålla mig till **Single Responsibility Pattern (Solid)**, har jag refaktorerat ut de privata metoderna till sina egna klasser där alla nu hanterar en uppgift. Sedan har jag, för att löskoppla klasserna mellan varandra, skapat *interface* (med inheritance av varandra) som beskrivet i **Interface Segregation Principle (solId)**. Därutöver detta har jag med en *Factory.cs* klass och dependency injection (genom **Dependeny Inersion Principle (soliD)**) fört bort instancieringen av klasser till en centraliserad miljö för att göra *high level classes* så rena som möjligt.

Tack för att du tar dig tiden att gå igenom min Lab!
Jag är osäker när det kommer till hur man ska strukturera filträdet med mappar och vad man ska man namnge dem?