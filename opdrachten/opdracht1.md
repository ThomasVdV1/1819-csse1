

# Opdracht 1: besturingssystemen
## Beschrijving computeronderdelen en hun functies.
Eerst en vooral heb je de behuizing die alle onderdelen in hun plaats houd. De behuizing biedt ook bescherming aan de onderdelen. Om stroom te voorzien aan alle onderdelen is er een voeding. De voeding is een adapter die de binnenkomende stroom (netstroom op 230 Volt) verdeelt onder de componenten.

In de behuizing zit een moederbord waarop bijna alle onderdelen op aangesloten zijn (behalve onderdelen die enkel stroom nodig hebben en dus direct op de voeding wordt aangesloten).

Het 'hart' van de computer is de CPU = Central Processing Unit (of CVE = Centrale Verwerkingseenheid). De CPU maakt (complexe) berekeningen: er gaat data en instructies naar de CPU, die deze vervolgens uitvoert. De nieuwe data wordt dan terug naar andere onderdelen gestuurd.

De processor is verbonden met de northbridge via de *front-side bus*. De northbridge regelt de communicatie tussen de processor en de rest van het systeem. Aan de northbridge zijn meestal onderdelen verbonden die een snelle communicatie moeten hebben.

Tussen de CPU en de northbridge is er een *clock generator* aangesloten, die nodig is voor processen die een bepaalde volgorde nodig hebben.

Op de northbridge is (via een *high-speed graphics bus: AGP of PCIe*) een grafische kaart/videokaar/GPU (Graphic Processing Unit) aangelsoten, die er voor zorgt dat grafische elementen kunnen weergegeven worden op een scherm. Dit zijn rekentaken die ook door de CPU kunnen uitgevoerd worden, maar voor complexere grafische elementen is het verstandiger om een GPU te gebruiken.

Naast de GPU is er ook RAM (Random-access memory)-geheugen aangesloten op de northbridhe. RAM is geheugen die snel toegenkelijk is (en telkens wordt gewist). Dit is belangrijk voor het uitvoeren van verschillende processen tegelijkertijd.

Componenten die een relatief tragere communicatie hebben, worden (via *PCI bus*, *LPC bus*, ...) aangesloten op de southbridge. De southbridge is via een internal bus verbonden met de northbridge.

Op de southbridge is meestal een HDD (Hard Disc Drive) of SSD (Solid State Drive) aangesloten (tegenwoordig meestal met een SATA verbinding). Dit geheugen slaat gegevens en bestanden voor langere tijd op (in tegenstelling tot RAM). Een HDD is een draaiende schijf waarop data kan worden opgeslagen en een SSD heeft geen draaiende schijf en is meestal sneller, stiller, lichter, zuiniger en koeler, maar vaak ook duurder.

ROM (read-only memory/alleen leesbaar geheugen) is ook een geheugenopslagmedium maar is niet bedoeld om vaak te herschrijven. Hier word meestal de firmware op bewaard.

Het BIOS (Basic Input/Output System) is een bibliotheek van stuurprogramma's voor aansturing van hardware die nodig is om het besturingssysteem te starten. In het BIOS zit ook de instructie voor de Power-On Self-Test of POST. Dit proces kijkt na of alles in orde is. Pas hierna wordt de computer volledig opgestart.

De algemene instellingen van het BIOS worden vastgehouden door een klein stukje geheugen, de CMOS. Omdat de CMOS een laag verbruik heeft, kan het jarenlang door een kleine batterij gevoed worden als de computer uit staat.
