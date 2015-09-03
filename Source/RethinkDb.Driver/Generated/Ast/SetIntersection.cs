








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
    public class SetIntersection : ReqlExpr {

    
    
    
        public SetIntersection (object arg) : this(new Arguments(arg), null) {
        }
        public SetIntersection (Arguments args) : this(args, null) {
        }
        public SetIntersection (Arguments args, OptArgs optargs)
             : this(TermType.SET_INTERSECTION, args, optargs) {
        }

    protected SetIntersection (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}