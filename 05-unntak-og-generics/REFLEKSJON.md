# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:
her forventer jeg at tester skal kunne gjennbruke med generics, telle og legge til/fjerne fra stacken med LIFO prinsipper. 

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
Pop_EmptyStack_ThrowsInvalidOperationExxception| forventet throwsinvalidoperationexception| faktisk argumentoutofrangeexception| her lærte jeg å lese gjennom testen i konsoll, se hva som feiler og hva som egentlig er forventet av testen.

## Etterpå

Hvilke filer endret jeg, og hvorfor?
 
Jeg la til en if blokk for å sjekke om stacken er tom, om stacken er tom så skal den throwe invalidoperationexception. om den har innhold så skal den opperere som normalt.

Svar på refleksjonsspørsmålene:

1. testen skal kontrollere kravet vi har satt, ikke godta en tilfeldig feil i implementasjonen.

2. Throws kontrollerer at Pop() kaster den forventa unntakstypen. Equal sammenligner verdier, derfor testet vi dette med Throws.

3. samme generisk klasse kan brukes med ulike datatyper. 


