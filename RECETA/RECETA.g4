grammar RECETA;

receta: nombre+ EOF;
nombre: nom por tp* tc* clr ing ela;
ingreItem: TAB number WS TXT NEWLINE;
elaItem: TAB number ')' WS TXT NEWLINE;
nom: GUION WS 'RECETA' SEP WS TXT NEWLINE;
por: GUION WS 'PORCIONES' SEP WS porc NEWLINE;
tp: GUION WS 'TIEMPO PREPARACION' SEP WS min NEWLINE;
tc: GUION WS 'TIEMPO COCCION' SEP WS min NEWLINE;
clr: GUION WS 'CALORIAS' SEP WS calo NEWLINE;
ing: GUION WS 'INGREDIENTES' SEP NEWLINE ingreItem+;
ela: GUION WS 'ELABORACION' SEP NEWLINE elaItem+;
minSTR: 'MIN' | 'min';
number: INT | FLOAT;
min: number WS minSTR;
porc: number WS TXT;
calo: number WS TXT;
INT: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
WS: ' ';
SEP: ':';
GUION: '-';
NEWLINE: '\n';
TAB: '\t';
TXT: ([a-zA-Z]+ ','* WS*)+;