








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
    public class ChangeAt : ReqlExpr {

    
    
    
        public ChangeAt (object arg) : this(new Arguments(arg), null) {
        }
        public ChangeAt (Arguments args) : this(args, null) {
        }
        public ChangeAt (Arguments args, OptArgs optargs)
             : this(TermType.CHANGE_AT, args, optargs) {
        }

    protected ChangeAt (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}