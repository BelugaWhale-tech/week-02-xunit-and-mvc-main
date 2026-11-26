# Arbeidslogg – Kontrolleren: koble sammen en hel konsollapp

## Før koding


Min forventning og begrunnelse:
her har jeg glemt å skrive før jeg har nådd dette punktet. 
Har brukt agenten flittig for å prøve å løse denne oppgaven.

jeg har litt mangler her i refleksjon. 


## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---

## Etterpå

Hvilke filer endret jeg, og hvorfor?

jeg gjorde endringer i MissionCOntroller.cs, her måtte jeg endre så programet kunne lese bruker unput, sjekka at det ble skrevet inn en gyldig int, at modellen kalles og at vi viser resultatet.

Arbeidsflyten er som følger: 

view viser oss menyen, controllers behandler våre inputs og ber modellene opprette eller fullføre et oppdrag. controller henter så ut oppdragene våre og det blir vist til oss via view?.

8. * før implementasjon så fikk jeg beskjed om at implementasjonen ikke var fullført når jeg brukte menyvalg 3 
* jeg brukte tryparse til å håndtere ugyldig input. jeg la kallet i en if blokk, om input er heltall så vil det returnere som true(tryparse returnerer true or false) jeg putter så dette in i en ny if blokk, som sjekker om ID matcher med inputet, om det er match så får vi fullført oppdraget. om det ikke er match så ber vi om gyldig oppdragsID. om tryparse kallet feiler, så skal det gå rett til else blokken og be om heltall for ID. 
* endret jeg noen i completeTask?
* resultatet fra de manuelle scenarione kommer ut riktig nå, jeg hadde mye krøll men fikk det til teslutt. ingen liker å se på feilene sine så jeg skriver ikke ned feilkallene her. 
* Dette føler jeg at jeg har svart på under Arbeidsflyten er som følger: delen over. 

Svar på refleksjonsspørsmålene:

1. Vi trenger bare ett missionboard, flere missionboards kunne ført til at brukerinputs kunne blitt assigna feil, at vi ender opp med å kalle på missionboard igjen og får ett nytt tomt missionboard.
2. vi bruker tryparse før vi kaller MissionBoard.Complete() for det er via tryparse vi får oppdrags ID. ID parses gjennom metoden og så sjekkes det om oppdrags ID finnes. 
3. for det er ikke kontrollerens avsvar. det ansvaret ligger på modellen, det er den som tar oppslag og endringer. view viser oss den informasjonen. 
4. for vi tester selve metodene, de er ikke avhengig av at controlleren vår er satt riktig..? 
5. kontroller gir inputs til modellen, modellen finner oppdraget med den oppgitte IDn og endrer statusen. view viser oss at oppdraget er fullført, view viser oss også at oppdraget står som venter om vi ikke kjører menyvalg 3 og fullfører først. 


