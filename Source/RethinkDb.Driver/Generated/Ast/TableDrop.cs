








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
    public class TableDrop : ReqlExpr {

    
    
    
        public TableDrop (object arg) : this(new Arguments(arg), null) {
        }
        public TableDrop (Arguments args) : this(args, null) {
        }
        public TableDrop (Arguments args, OptArgs optargs)
             : this(TermType.TABLE_DROP, args, optargs) {
        }

    protected TableDrop (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}