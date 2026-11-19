# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:
her forventer jeg at tester skal kunne gjennbruke med generics, telle og legge til/fjerne fra stacken med LIFO prinsipper. 

## Forsøk
vil legge til at tidlig i denne oppgaven så endret jeg selve throwet til indexoutofrangeexception. forstod i ettertid at det var feil tilnærming og gikk så inn i CargoStack og la til en if block for avvise en tom stack. jeg trur det var riktig.

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
Pop_EmptyStack_ThrowsInvalidOperationExxception| forventet throwsinvalidoperationexception| faktisk argumentoutofrangeexception| her lærte jeg å lese gjennom testen i konsoll, se hva som feiler og hva som egentlig er forventet av testen.
|NewStack_CountZero_EmptyStack| lager en ny stack og sjekker at den er tom| lager ny stack og bekrefter at stacken er tom 
AddItems_PopStack| lage stack, legge til items, pope ut items til den er tom samtidig som vi sjekker at items blir poppet ut og antallet i stakken deretter.| stack lages, items blir lagt til og en etter en poppet ut og innhold sjekkes for vær pop at antall stemmer.
AddInt_PopStackAndWhatNot|lage en stack av typen int, legger til integer 7, poper og sjekker antall.| stack<int> opprettes, 7 legges til, sjekker at 7 er i stacken og så fjernes fra stack, count 0 deretter. 
AddToStack_Pop_AddToStackAgain_Reusability| oppretter ny stack, pusher string inn i stacken, sjekker at stack innholder pushet string, pop string, sjekk at stacken er tom, legg til ny string i eksisterende stack og sjekk innhold. pop stacken slik at den tømmes og bekreft tom stack . 

## Etterpå

Hvilke filer endret jeg, og hvorfor?
Gjorde endring i CargoStack.cs. Jeg la til en if blokk for å sjekke om stacken er tom, om stacken er tom så skal den throwe invalidoperationexception. om den har innhold så skal den opperere som normalt.
i exercisetest.cs så la jeg til flere tester for å sjekke stack funksjonalitet. 

Svar på refleksjonsspørsmålene:

1. testen skal kontrollere kravet vi har satt, ikke godta en tilfeldig feil i implementasjonen.

2. Throws kontrollerer at Pop() kaster den forventa unntakstypen. Equal sammenligner verdier, derfor testet vi dette med Throws.

3. samme generisk klasse kan brukes med ulike datatyper. 


