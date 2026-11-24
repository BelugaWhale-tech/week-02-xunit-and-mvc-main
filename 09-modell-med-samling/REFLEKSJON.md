# Arbeidslogg – Oppdragstavlen: test modellen før menyen

## Før koding

Min forventning og begrunnelse:

Undersøk startkoden:
* MissionBoard innholder klassen for liste med oppdrag. MissionTask innholder selve oppdrags objektet. 
* Når MissionBoard.add kalles så lages en ny liste med oppdrag, de får en ID og vi sjekker om oppdraget er markert som complete. trur jeg, klassen vår er MissionBoard. 
* når vi legger inn Mission i listen vår så tildeles den ID når den opprettes før den legges inn i listen. 
* Missiontask.complete() skal merke ett oppdrag via ID som complete eller true. 
* Akkurat nå returnerer Complete metoden vår false. 



## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---

## Etterpå

Hvilke filer endret jeg, og hvorfor?

jeg endre missionboard, der fullførte jeg complete metoden slik at testene returnerer true basert på ID til objektene i liste. 


Svar på refleksjonsspørsmålene:

jeg hadde to tester som feilet i starte,(noterte meg ikke det ned, men trur det var test 1 og 2) de var fordi complete metoden ikke var fullført og returnerte false. når metoden blir ferdig skriv så kjøres testene uten problemer. 

jeg skrev fire nye tester:
NewBoard_IsEmpty = sjekke om nytt missionboard blir laget og er tomt.
SameMission_CompletesTwice = sjekker mulighet for å merkere ett oppdrag som complete flere ganger. 
TwoBoards_SeperateChristmases = Her sjekker jeg at to lister opprettes og at ved å legge ett objekt i en liste så forblir den andre listen tom, sjekker så at jeg kan legge til objekt i liste nummer to.
ListCopy_ContainssameasOriginal = i denne testen sjekker jeg at en kopi av en liste inneholder samme objekt.

i missionboard.complete. så endret jeg koden slik at vi itererer gjennom listen for å finne matchende ID til objektet så det kan markeres som Complete.

etter implementasjon så bestod alle testene

assert.same viser at to objekter er samme instanse, brukes i siste testen jeg skrev.

# refleksjonspørsmål
jeg skal ikke si med 100% sikkerhet, men missionboard burde bruke task sin complete da board har en privat Id,

listekopien fra getall beskytter mot endringer, det er sin egen instanse så endringer i orignalen kommer ikke her, medmindre vi kaller på dem.

equal sjekker om verdiene er like mens same sjekker om begge referansene peker til nøyaktig samme objekt. i test 4 som jeg skrev selv. så sjekker vi at listen fra Getall innholder objektet som add returnerte.

hver test børmopprette eget missionboard så vi ikke ender opp med objekter fra tidligere tester som kan krølle til vår nye test. 