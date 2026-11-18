# Arbeidslogg – Lasterom: test tilstand uten testrekkefølge

## Før koding

Min forventning og begrunnelse: Her forventer jeg at tester jeg lager skal kunne opprette nye CargoBays og at jeg skal kunne adde items til disse, det er en grense på to items? så sjekke tilfeller hvor jeg overskrivde denne regelen. 

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|constructor_startsempty var bay = new cargobay(); | lager en ny beholder som er tom| lager ny beholder som er tom| 
|bay.tryadd("mat");| legger til mat i beholder.| legger til mat i beholder, count er 1| 
bay.tryadd("Mat") bay.tryadd("vann")| legger til to objekter i beholder, count skal være to| legger til objekter og count er 2|
|bay.tryadd("mat"); ("vann"); ("luft");| legger til tre objekter i listen, testen skal feile da det er kun plass til to objekter i beholderen.|


## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:


