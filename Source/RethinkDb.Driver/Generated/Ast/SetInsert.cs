








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
    public class SetInsert : ReqlExpr {

    
    
    
        public SetInsert (object arg) : this(new Arguments(arg), null) {
        }
        public SetInsert (Arguments args) : this(args, null) {
        }
        public SetInsert (Arguments args, OptArgs optargs)
             : this(TermType.SET_INSERT, args, optargs) {
        }

    protected SetInsert (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}