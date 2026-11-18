# Arbeidslogg – Første xUnit-test og Arrange–Act–Assert

## Før koding

Min forventning og begrunnelse: forventer at testene skal gi meg suksess ved kjøring, endring av multiplikasjonen til *3 vil føre til 2 feiltester og en suksess. suksessen kommer av at i den testen ganger vi med 0. 

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|Calculate_ThreeCrewForFourDays_Returns24| forventet suksess, 24.|suksess, 24.| 
|Calculate_ZeroCrewFourDays_ReturnsZero| forventet sukess, 0| suksess, 0 
|Calculate_OneCrewForOneDay_ReturnsTwo| forventet suksess, 2|suksess, 2|

## Etterpå
hva lærte jeg?: Her lærte jeg bedre hvordan å faktisk skrive en test? jeg skjønner bedre at vi tester selve metoden og at dataen til testen legges til i selve testen. om dette er riktig og om jeg kommer til å klare å bedre skrive metoder i fremtiden blir å se. 

Hvilke filer endret jeg, og hvorfor?
i denne oppgaven la jeg til to nye tester i ExcerciseTests.cs, jeg endret også Core.cs sin utregning slik at den multipliserer med 3. dette førte til at to tester feilet mens test nummer 2 ble en suksess. den ble igjen en suksess pga matte. ganger man med 0 så blir resultatet 0. setter multiplikajsonen tilbake til 2 og kjører testene igjen for korrekt resultat.

Svar på refleksjonsspørsmålene:

