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

endringer i ExerciseTests.cs, la til to nye tester for å sjekke maks kapasitet. 


Svar på refleksjonsspørsmålene:
