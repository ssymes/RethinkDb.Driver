








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
    public class Distance : ReqlExpr {

    
    
    
        public Distance (object arg) : this(new Arguments(arg), null) {
        }
        public Distance (Arguments args) : this(args, null) {
        }
        public Distance (Arguments args, OptArgs optargs)
             : this(TermType.DISTANCE, args, optargs) {
        }

    protected Distance (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}