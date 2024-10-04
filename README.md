Voor deze test heb je al de leerstof nodig die voor de herfstvakantie is
gezien.

**Tijdens de test**

-   Er mag op geen enkele manier gebruik gemaakt worden van het
    internet,een gsm of **externe hulp**

-   Je mag gebruik maken van oefeningen en je oplossingen, de slides, de
    syllabus en het handboek.

**Einde tussentijdse test**

-   De test duurt **twee uur**. Het is niet de bedoeling dat je na de
    twee uur nog verder werkt.

**C# Essentials -- PXL Shop**

**Shop opdracht**

Je bent aangenomen door de PXL om een kassa systeem te maken voor de
nieuwe PXL Shop. In de shop kunnen studenten dicht bij de PXL hun
favoriete voedingsproducten kopen, zoals avocado's, broccoli, bruine
bonen, kiwi's en mango's. Na de lessen kan je nu op de campus zelf
inkopen doen en tijd besparen.

Er is helaas nog niet genoeg budget om de kassa te voorzien met een
barcode scanner. Met andere woorden momenteel worden de producten
manueel ingegeven aan de kassa per bestelling.

De opdracht bestaat uit twee delen:

-   Een User Interface gemaakt met XAML

-   De programmeerlogica in C#

**Overzicht:**

1.  User Interface

2.  Programmeerlogica

    1.  Klassenvariabelen

    2.  Timer

    3.  Product Toevoegen

    4.  Check Out

    5.  Nieuwe Bestelling

    6.  Achtergrondkleur

**1. User Interface**

![](./media/image2.emf)

*Figuur 1: startpositie van het venster*

In het venster maken we gebruik van een DockPanel dat het scherm
onderverdeeld in twee delen: een Grid met besturingselementen om
producten toe te voegen aan een rekening, een StackPanel die onderaan
het scherm de tijd toont. Op figuur 2 zie je de onderverdeling van het
venster.

![](./media/image3.emf)

*Figuur 2: opdeling van het venster*

**XAML-Voorwaarden:**

1\. Het StackPanel bevat één TextBlock waarin de tijd getoond wordt.

2\. Het StackPanel onderaan heeft de kleur "Black" en de tekst in het
StackPanel heeft de kleur "White".

3\. Het Grid bestaat uit drie kolommen en vier rijen. Elke rij heeft
dezelfde hoogte en elke kolom heeft dezelfde breedte.

4\. Er is een info-veld en invulveld voor de naam, prijs en hoeveelheid
van het product in het Grid.

5\. Er zijn drie knoppen: een "Voeg Toe"-knop, een "Check Out"-knop en
een "Nieuwe Bestelling"-knop.

6\. De besturingselementen in het Grid hebben allemaal een marge van 10
en een lettergrootte van 20, behalve de output van het ticket in de
meest rechtse kolom heeft een lettergrootte van 12.

7\. De output van het ticket verschijnt in het lettertype "Courier New".

8\. De titel van het venster is "PXL-Shop".

**2. Programmeerlogica**

**2.1 Klassenvariabelen**

***Variabelen:***

-   Declareer een string, *output,* waarin de tekst wordt bewaard die
    getoond wordt in de meest rechtse kolom.

-   Declareer een variabele, *totalPrice*, waarin de huidige totaalprijs
    wordt bewaard van alle reeds toegevoegde producten.

**2.2 Timer**

***Programmeervoorwaarden:***

-   Wanneer het venster geladen is, zal de timer gestart worden
    (Window_Loaded).

-   De timer toont de gebruiker het tijdstip van de dag in uren, minuten
    en seconden.

-   De timer wordt iedere seconde geüpdatet.

    3.  **Product Toevoegen**

***Programmeervoorwaarden:***

-   Wanneer de gebruiker op de "Voeg Toe"-knop klikt, dan wordt de
    productnaam met de hoeveelheid toegevoegd in een nieuwe regel aan
    het ticket in de output TextBox in de meest rechtse kolom in het
    formaat "*hoeveelheid* x *productnaam*". Verder wordt de totaalprijs
    verhoogd met (*hoeveelheid \* productprijs*).

![](./media/image4.emf)*Figuur 3: Voorbeeld van formatering van
toegevoegde producten in het outputveld.*

**2.4 Check Out**

Wanneer de gebruiker op de "Check Out"-knop drukt, dan wordt er een
ticket geproduceerd met een totaalprijs. Deze totaalprijs wordt
benadrukt door een vierkant van sterren er rond te plaatsen.

***Programmeervoorwaarden:***

-   Maak een methode, *FrameResult()*, waaraan je het totaalbedrag kan
    meegeven als argument en waarvan je een string kan ontvangen van
    meerdere regels waarin het totaalbedrag geframed is met het asterisk
    symbool, "\*".

-   Het ticket wordt afgesloten met een extra witregel en "PXL - Shop".

-   Indien je te vroeg op "Check Out" klikt, dan kan je gewoon verder
    producten toevoegen via de "Voeg Toe"-knop. De zonet berekende
    totaalprijs en de "PXL - Shop" regel verdwijnen weer, wanneer er een
    nieuw product wordt toegevoegd. (Zie figuur 5)

![](./media/image5.emf)*\
Figuur 4: Zodra de gebruiker op "Check Out" klikt, wordt de totaalprijs
berekend.*

![](./media/image6.emf)

*Figuur 5: Opnieuw op "Voeg Toe" klikken doet de totaalprijs en "PXL -
Shop" regel verdwijnen en voegt opnieuw een product toe.*

**2.5 Nieuwe Bestelling**

***Programmeervoorwaarden:***

-   Als de gebruiker op de "Nieuwe Bestelling"-knop klikt, dan worden
    alle invulvelden leeggemaakt.

-   Wanneer er een nieuwe bestelling wordt gemaakt, dan worden de
    *output* en *totalPrice* variabelen opnieuw ingesteld op hun
    begintoestand.

**2.6 Achtergrondkleur**

Wanneer de applicatie gestart wordt, dan wordt er een willekeurige
achtergrondkleur gekozen tussen LimeGreen en LightGreen voor het Grid.

***Programmeervoorwaarden:***

-   Maak een methode, *RandomBackground()*, die bij het opstarten van de
    applicatie aangeroepen wordt om een willekeurige kleur in te
    stellen.

-   Wanneer je de methode uitvoert, dan is er 50% kans dat de
    achtergrondkleur van het Grid LimeGreen wordt en 50% kans dat de
    achtergrondkleur LightGreen wordt.

-   *Tip: het instellen van kleuren kan je in de code doen als volgt:*
    NaamTextBox.Background = Brushes.Green;

***Veel succes!***
