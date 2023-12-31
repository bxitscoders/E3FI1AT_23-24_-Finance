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
    /// There are no comments for Model.Account in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Account : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Account object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="credit">Initial value of Credit.</param>
        /// <param name="userFK">Initial value of UserFK.</param>
        public static Account CreateAccount(int iD, int credit, int userFK)
        {
            Account account = new Account();
            account.ID = iD;
            account.Credit = credit;
            account.UserFK = userFK;
            return account;
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
    
        /// <summary>
        /// There are no comments for Credit in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual int Credit
        {
            get
            {
                int value = _Credit;
                OnGetCredit(ref value);
                return value;
            }
            set
            {
                if (_Credit != value)
                {
                  OnCreditChanging(ref value);
                  ReportPropertyChanging("Credit");
                  _Credit = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Credit");
                  OnCreditChanged();
              }
            }
        }
        private int _Credit;
        partial void OnGetCredit(ref int value);
        partial void OnCreditChanging(ref int value);
        partial void OnCreditChanged();
    
        /// <summary>
        /// There are no comments for UserFK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual int UserFK
        {
            get
            {
                int value = _UserFK;
                OnGetUserFK(ref value);
                return value;
            }
            set
            {
                if (_UserFK != value)
                {
                  OnUserFKChanging(ref value);
                  ReportPropertyChanging("UserFK");
                  _UserFK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("UserFK");
                  OnUserFKChanged();
              }
            }
        }
        private int _UserFK;
        partial void OnGetUserFK(ref int value);
        partial void OnUserFKChanging(ref int value);
        partial void OnUserFKChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "account_FK", "User")]
        public virtual User User
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("Model.account_FK", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("Model.account_FK", "User").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("Model.account_FK", "User");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<User>("Model.account_FK", "User", value);
                }
                else
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("Model.account_FK", "User").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Possessions in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "possession_ibfk_2", "Possessions")]
        public virtual EntityCollection<Possession> Possessions
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Possession>("Model.possession_ibfk_2", "Possessions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Possession>("Model.possession_ibfk_2", "Possessions", value);
                }
            }
        }

        #endregion
    }

}
