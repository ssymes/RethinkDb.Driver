








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
    public class Le : ReqlExpr {

    
    
    
        public Le (object arg) : this(new Arguments(arg), null) {
        }
        public Le (Arguments args) : this(args, null) {
        }
        public Le (Arguments args, OptArgs optargs)
             : this(TermType.LE, args, optargs) {
        }

    protected Le (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}