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
i selve testen nå så endrer jeg invalidoperationexception til argumentoutofrangeexception. kanskje kjøre en separat test først for å se om det faktisk fungerer? kjørte ikke separat tekst, endret selve testen og den passerer. ser også at jeg leste oppgaveteksten helt feil og startet på nytt. 

Jeg la til en if blokk for å sjekke om stacken er tom, om stacken er tom så skal den throwe invalidoperationexception. om den har innhold så skal den opperere som normalt.

Svar på refleksjonsspørsmålene:


