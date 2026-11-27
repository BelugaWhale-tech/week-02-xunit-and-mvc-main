# Arbeidslogg – Nytt behov: vis bare ufullførte oppdrag

## Før koding

Min forventning og begrunnelse: 
Oppgaven vil at jeg skal kunne vise hvilke oppdrag som er markert "Ufullførte", vi skal legge til ett nytt meny alternativ og bruke TDD til å utvikle funksjonaliteten. metoden skal legges til i MissionBoard. paster inn kravene her: 
* Metoden MissionBoard.GetPending() skal:

Returnere oppdrag som har IsCompleted == false.
Bevare rekkefølgen oppdragene ble lagt til i.
Returnere en ny liste, ikke tavlens interne liste.
Ikke endre eller fjerne noen oppdrag fra tavlen.
Returnere en tom liste hvis ingen oppdrag venter

Listen skal inneholde referanser til eksisterende oppdragsobjekter. slik jeg lærte i oppgave 09.

undersøker oppgitte filer i henhold til oppgave.README og sjekker punktene: 
* Hva gjør GetPending() akkurat nå?
* Hvordan henter menyvalg 2 alle oppdragene?
* Hvordan viser ShowTasks() en liste med oppdrag?
* Hvor ligger menyteksten?

2. Red- kjør test og undersøk feil.
* assert.single() feiler, Collection was empty.
* etter å ha sjekket koden ser det ut som at GetPending() returnerer en ny tom MissionTask liste
* de andre testene består da de har komlette metoder som skal testes, vi har ikke ferdigstilt GetPending() det mangler koden som skal gi det funksjonen vi er ute etter.


## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|CreateNewMissionBoard_GetPendingReturnsNewList| lager nytt tomt MissionBoard. GetPending() skal returnere tom liste.| GetPending() retunrere med tom liste. 
|CreatenewMissionBoard_AddTwoMissions_GetPendingReturnsListWithMissionsIncomplet| forventet at testen skal returnere liste med ufullførte oppdrag.| returnerer en tom liste. 

## Etterpå

Hvilke filer endret jeg, og hvorfor?
* endringer i MissionBoard for å filtrere. 
* la til flere tester i ExcerciseTests. teste tom tavle, ufullført/fullført oppdrag, rekkefølge og at resultatlista er en kopi. 
* MissionView, la til meny-valg 4
* MissionController. koble meny- valg 4 til GetPending() og ShowTasks()


Svar på refleksjonsspørsmålene:

1. det har med ansvar å gjøre, _view skal bare vise og ikke endre. mens board har ansvaret for å finne ufullførte oppdrag.  
2. for å holde orginalen i behold? vi lager jo en kopi. om vi skulle ha behov for å hente dem senere så kan vi det. om vi gjør endringer i resultatlista så har vi fortsatt den orginale å se tilbake på om nødvendig. 
3. GetPending() returnerer altid en tom liste. derfor består testen. 
4. Showtasks() viser oss oppdragene, meny-valg 4 skal bare vise oss ufullførte oppdrag. Showtasks() kan vise oss hvilken som helst oppdragslite så trenger vi ikke en ny visningsmetode
5. godt spørsmål. testene passerer når jeg fikset opp GetPending() siden testene passerer så betyr det jo at arbeidet som er gjort fungerer, selvom det også er mulig for tester å passere selvom funksjonaliteten ikke er der.. vanskelig spørsmål

