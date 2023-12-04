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
    /// There are no comments for Model.Sharevalue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Sharevalue")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Sharevalue : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Sharevalue object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="value">Initial value of Value.</param>
        /// <param name="timeStamp">Initial value of TimeStamp.</param>
        /// <param name="sharesFK">Initial value of SharesFK.</param>
        public static Sharevalue CreateSharevalue(int iD, int value, global::System.DateTime timeStamp, int sharesFK)
        {
            Sharevalue sharevalue = new Sharevalue();
            sharevalue.ID = iD;
            sharevalue.Value = value;
            sharevalue.TimeStamp = timeStamp;
            sharevalue.SharesFK = sharesFK;
            return sharevalue;
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
        /// There are no comments for Value in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual int Value
        {
            get
            {
                int value = _Value;
                OnGetValue(ref value);
                return value;
            }
            set
            {
                if (_Value != value)
                {
                  OnValueChanging(ref value);
                  ReportPropertyChanging("Value");
                  _Value = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Value");
                  OnValueChanged();
              }
            }
        }
        private int _Value;
        partial void OnGetValue(ref int value);
        partial void OnValueChanging(ref int value);
        partial void OnValueChanged();
    
        /// <summary>
        /// There are no comments for TimeStamp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.DateTime TimeStamp
        {
            get
            {
                global::System.DateTime value = _TimeStamp;
                OnGetTimeStamp(ref value);
                return value;
            }
            set
            {
                if (_TimeStamp != value)
                {
                  OnTimeStampChanging(ref value);
                  ReportPropertyChanging("TimeStamp");
                  _TimeStamp = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TimeStamp");
                  OnTimeStampChanged();
              }
            }
        }
        private global::System.DateTime _TimeStamp;
        partial void OnGetTimeStamp(ref global::System.DateTime value);
        partial void OnTimeStampChanging(ref global::System.DateTime value);
        partial void OnTimeStampChanged();
    
        /// <summary>
        /// There are no comments for SharesFK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual int SharesFK
        {
            get
            {
                int value = _SharesFK;
                OnGetSharesFK(ref value);
                return value;
            }
            set
            {
                if (_SharesFK != value)
                {
                  OnSharesFKChanging(ref value);
                  ReportPropertyChanging("SharesFK");
                  _SharesFK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SharesFK");
                  OnSharesFKChanged();
              }
            }
        }
        private int _SharesFK;
        partial void OnGetSharesFK(ref int value);
        partial void OnSharesFKChanging(ref int value);
        partial void OnSharesFKChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Shares in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "shareValue_ibfk_1", "Shares")]
        public virtual Shares Shares
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Shares>("Model.shareValue_ibfk_1", "Shares").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Shares>("Model.shareValue_ibfk_1", "Shares").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for Shares in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Shares> SharesReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Shares>("Model.shareValue_ibfk_1", "Shares");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Shares>("Model.shareValue_ibfk_1", "Shares", value);
                }
                else
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Shares>("Model.shareValue_ibfk_1", "Shares").Value = null;
                }
            }
        }

        #endregion
    }

}