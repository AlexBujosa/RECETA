using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECETA
{
    internal class receta : RECETABaseVisitor<int>
    {
        public override int VisitCalo([NotNull] RECETAParser.CaloContext context)
        {
            Console.WriteLine($"Visitando Calorias: {context.GetText()}");
            return base.VisitCalo(context);
        }

        public override int VisitClr([NotNull] RECETAParser.ClrContext context)
        {
            Console.WriteLine($"Visitando Calorias Titulo: {context.GetText()}");
            return base.VisitClr(context);
        }

        public override int VisitEla([NotNull] RECETAParser.ElaContext context)
        {
            Console.WriteLine($"Visitando Elaboracion Titulo: {context.GetText()}");
            return base.VisitEla(context);
        }

        public override int VisitElaItem([NotNull] RECETAParser.ElaItemContext context)
        {
            Console.WriteLine($"Visitando Elaboracion Item: {context.GetText()}");
            return base.VisitElaItem(context);
        }

        public override int VisitIng([NotNull] RECETAParser.IngContext context)
        {
            Console.WriteLine($"Visitando Ingrediente Titulo: {context.GetText()}");
            return base.VisitIng(context);
        }

        public override int VisitIngreItem([NotNull] RECETAParser.IngreItemContext context)
        {
            Console.WriteLine($"Visitando Ingrediente Item: {context.GetText()}");
            return base.VisitIngreItem(context);
        }

        public override int VisitMin([NotNull] RECETAParser.MinContext context)
        {
            Console.WriteLine($"Visitando descripcion minuto: {context.GetText()}");
            return base.VisitMin(context);
        }

        public override int VisitMinSTR([NotNull] RECETAParser.MinSTRContext context)
        {
            Console.WriteLine($"Visitando String de minuto: {context.GetText()}");
            return base.VisitMinSTR(context);
        }

        public override int VisitNom([NotNull] RECETAParser.NomContext context)
        {
            Console.WriteLine($"Visitando Nombre Titulo: {context.GetText()}");
            return base.VisitNom(context);
        }

        public override int VisitNombre([NotNull] RECETAParser.NombreContext context)
        {
            Console.WriteLine($"Visitando nombre (Rama Principal): {context.GetText()}");
            return base.VisitNombre(context);
        }

        public override int VisitNumber([NotNull] RECETAParser.NumberContext context)
        {
            Console.WriteLine($"Visitando Numero (INT|FLOAT): {context.GetText()}");
            return base.VisitNumber(context);
        }

        public override int VisitPor([NotNull] RECETAParser.PorContext context)
        {
            Console.WriteLine($"Visitando Porcion titulo: {context.GetText()}");
            return base.VisitPor(context);
        }

        public override int VisitPorc([NotNull] RECETAParser.PorcContext context)
        {
            Console.WriteLine($"Visitando Porcion descripcion: {context.GetText()}");
            return base.VisitPorc(context);
        }

        public override int VisitReceta([NotNull] RECETAParser.RecetaContext context)
        {
            Console.WriteLine($"Visitando Rama Receta->Nombre: {context.GetText()}");
            return base.VisitReceta(context);
        }

        public override int VisitTc([NotNull] RECETAParser.TcContext context)
        {
            Console.WriteLine($"Visitando Tiempo Coccion: {context.GetText()}");
            return base.VisitTc(context);
        }

        public override int VisitTp([NotNull] RECETAParser.TpContext context)
        {
            Console.WriteLine($"Visitando Tiempo Preparacion: {context.GetText()}");
            return base.VisitTp(context);
        }
    }
}
