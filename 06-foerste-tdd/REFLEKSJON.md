# Arbeidslogg – Oppdragskort: første Red–Green–Refactor

## Før koding

Min forventning og begrunnelse:
i denne oppgaven skal jeg starte med tester før jeg koder, jeg startet her med å skrive en test for å sjekke om completed kommer tilbake true. når jeg kjører testen etter å ha skrivd testen for iscompleted kommer den tilbake som false, jeg må skrive selve koden for IsCompleted.


## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|IsCompleted_IsTrue| forventer at taskII.IsCompleted skal returnere true| testen feiler og returnerer false. 
taskII.Complete();| forventer med dette at forrige test passere| testen passerer, taskII.IsCompleted returnerer som true.|


## Etterpå

Hvilke filer endret jeg, og hvorfor?
Starter med endringer i MissionTask.cs. selve metodeblokken for Complete er ikke utfylt, det mangler metode.

Svar på refleksjonsspørsmålene:


