








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {
    public class Reduce : ReqlExpr {

    
    
    
        public Reduce (object arg) : this(new Arguments(arg), null) {
        }
        public Reduce (Arguments args) : this(args, null) {
        }
        public Reduce (Arguments args, OptArgs optargs)
             : this(TermType.REDUCE, args, optargs) {
        }

    protected Reduce (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}