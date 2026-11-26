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
* uten å ha sjekket testen, så forventer vel testen at det skal være noe i sammlingen. jeg får


## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---

## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:

