# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse: før jeg starter nå, så forventer jeg at alle test tilfellen skal komme som suksess. det stemmer da ikke på InlineData felt 2. jeg ser ikke i feilmelingen HVORFOR den feiler. Jeg ser på SeatPolicy og det ser ut som at (her blander jeg mye) requested er satt til less than available. Her endrer jeg nok til less than or equal to for at testen skal passere. 
for min egen del så leser jeg metoden: 
return requested {greater then}> 0 && requested {less then}< available; 
endre til <= skal fikse problemet. 



## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
|inlinedata (1, 4, true);| forventer at testen passerer.| testen passerer| 
|inlinedata (3, 4, true);   forventer at testen passerer.| testen passerer| 
|inlinedata (4, 4, true);| forventer at testen passerer. | testen passerer ikke. expected true, actual false. 
|


## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:
