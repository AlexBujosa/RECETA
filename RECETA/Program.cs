using Antlr4.Runtime;
using RECETA;
string input = "- RECETA: Pudin de pan\n" +
                "- PORCIONES: 3 personas\n" +
                "- TIEMPO PREPARACION: 20 min\n" +
                "- TIEMPO COCCION: 60 min\n" +
                "- CALORIAS: 535 kcal\n" +
                "- INGREDIENTES:\n" +
                "\t2.5 tazas leche evaporada,\n" +
                "\t2 huevos,\n" +
                "\t2 cucharadita extracto de vainilla,\n" +
                "\t1 cucharadita canela en polvo,\n" +
                "\t0.5 cucharadita jengibre rallado o en polvo,\n" +
                "\t0.5 cucharadita clavo dulce en polvo,\n" +
                "\t0.25 cucharadita sal,\n" +
                "\t0.5 taza azucar morena,\n" +
                "\t3 tazas pan viejo en trocitos,,\n" +
                "\t0.25 taza pasas,\n" +
                "\t0.25 taza mantequilla\n" +
                "- ELABORACION:\n" +
                "\t1) Buscar una licuadora\n" +
                "\t2) Echar todos los liquidos\n" +
                "\t3) Echar todos los solidos\n" +
                "\t4) Licuar\n" +
                "\t5) Beberselo en el vaso de la licuadora\n" +
                "\t6) Fin\n" +
                "- RECETA: Pudin de pan\n" +
                "- PORCIONES: 2 jartones\n" +
                "- CALORIAS: 2000 calorias\n" +
                "- INGREDIENTES:\n" +
                "\t2 Pizzas Grandes de Pizza Hut\n" +
                "- ELABORACION:\n" +
                "\t1) Colocar la Pizza en la mesa\n" +
                "\t2) Comersela\n";
Console.WriteLine($"input: {input}\n");
ICharStream stream = CharStreams.fromString(input);
RECETALexer lexer = new RECETALexer(stream);
CommonTokenStream token = new CommonTokenStream(lexer);
RECETAParser parser = new RECETAParser(token);
RECETAParser.RecetaContext tree = parser.receta();
receta receta = new receta();
int result= receta.Visit(tree);