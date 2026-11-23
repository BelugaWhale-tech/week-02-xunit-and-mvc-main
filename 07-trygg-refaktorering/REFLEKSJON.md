# Arbeidslogg – Oppskytingspris: forbedre grønn kode

## Før koding

Min forventning og begrunnelse:
sjekker ut eksisterende kode, vanskelig å se hva parameterene og variablen brukes til. ser etter beregninger som gjentas. testene som er på plass kjører uten problemer. 
for testingen begynner skal jeg utvide koden til å kontrollere det høyeste antallet tillatte personer. 

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
[InlineData(20, false, 2000)] | Testen passerer  
[InlineData(20, true, 2400)]  | Testen passerer


## Etterpå

Hvilke filer endret jeg, og hvorfor?

endringer i ExerciseTests.cs, endret beregningene så ikke vi endte opp med noe overføldig. 
la til to nye tester for å sjekke maks kapasitet. 


Svar på refleksjonsspørsmålene:
før refactor bestod vell alle testene? jeg endret parameterene og variablen i koden for lettere leslighet. testene passerer fortsatt. det ble lettere å forstå etter refactor
jeg kjørte testene mellom endringene for å forsikre meg om at testene fortsatt passerer. 
forkjellen på endring og forbedring, ved forbedring så gjorde vi at beregningen mindre kodete? vi flyttet beregning av grunnpris så den ikke regnes flere ganger. hadde vi endret beregningen så ville det nok se veldig anderledes ut. 
kan en grønn testpakke garantere riktig oppførsel for tilfeller testene ikke undersøker? hvorfor eller hvorfor ikke?: min første tanke er nei, vi kan ikke garantere riktig oppførsel for tester vi ikke undersøker. 