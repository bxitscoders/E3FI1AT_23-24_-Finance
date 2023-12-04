﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 29.11.2023 09:27:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

#nullable enable annotations
#nullable disable warnings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Model
{

    /// <summary>
    /// There are no comments for Model.Financetransaction in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Financetransaction")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Financetransaction : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Financetransaction object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        public static Financetransaction CreateFinancetransaction(int iD)
        {
            Financetransaction financetransaction = new Financetransaction();
            financetransaction.ID = iD;
            return financetransaction;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual int ID
        {
            get
            {
                int value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private int _ID;
        partial void OnGetID(ref int value);
        partial void OnIDChanging(ref int value);
        partial void OnIDChanged();

        #endregion
    }

}