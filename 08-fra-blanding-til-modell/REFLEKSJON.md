# Arbeidslogg – Skill oppskytingsregelen fra konsollen

## Før koding

Min forventning og begrunnelse: Undersøker startkoden, oppfattes som rotete og vanskelig å forholde seg til.
programmet leser inn drivstoff og sikkerhetsgodkjenning i toplevel? det leses inn manuelt via user input. oppskytningen avgjøres som tillat OM fuel er 50 eller høyere og approved er true. programmet skriver melding til bruker i consolen(?)

reglene for oppskytning må flyttes til CanLaunch i LaunchPolicy.cs 
her feiler testtilfelle nummer to? testen forventer true men mottar false. 
CanLaunch returnerer false akkurat nå. 

noterer ned at jeg har testet selve konsollresultatet også. testet med 50/ja 49/ja og 50/nei, den første blir godkjent mens de to siste blir avvist. 

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---


## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:

