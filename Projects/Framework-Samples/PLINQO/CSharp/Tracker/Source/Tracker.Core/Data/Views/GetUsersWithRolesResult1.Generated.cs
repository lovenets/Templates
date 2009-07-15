﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// Class representing data for the Tracker database.
    /// </summary>
    
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    public partial class GetUsersWithRolesResult1
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="GetUsersWithRolesResult1"/> class.
        /// </summary>
        static GetUsersWithRolesResult1()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<GetUsersWithRolesResult1>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersWithRolesResult1"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public GetUsersWithRolesResult1()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Column Mapped Properties

        private int _id;

        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    _id = value;
                    OnIdChanged();
                }
            }
        }

        private string _emailAddress;

        /// <summary>
        /// Gets or sets the EmailAddress column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "EmailAddress", Storage = "_emailAddress", DbType = "nvarchar(250) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    OnEmailAddressChanging(value);
                    _emailAddress = value;
                    OnEmailAddressChanged();
                }
            }
        }

        private string _firstName;

        /// <summary>
        /// Gets or sets the FirstName column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "FirstName", Storage = "_firstName", DbType = "nvarchar(200)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    OnFirstNameChanging(value);
                    _firstName = value;
                    OnFirstNameChanged();
                }
            }
        }

        private string _lastName;

        /// <summary>
        /// Gets or sets the LastName column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastName", Storage = "_lastName", DbType = "nvarchar(200)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    OnLastNameChanging(value);
                    _lastName = value;
                    OnLastNameChanged();
                }
            }
        }

        private System.Data.Linq.Binary _avatar;

        /// <summary>
        /// Gets or sets the Avatar column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Avatar", Storage = "_avatar", DbType = "varbinary(MAX)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public System.Data.Linq.Binary Avatar
        {
            get { return _avatar; }
            set
            {
                if (_avatar != value)
                {
                    OnAvatarChanging(value);
                    _avatar = value;
                    OnAvatarChanged();
                }
            }
        }

        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    _createdDate = value;
                    OnCreatedDateChanged();
                }
            }
        }

        private System.DateTime _modifiedDate;

        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ModifiedDate", Storage = "_modifiedDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    OnModifiedDateChanging(value);
                    _modifiedDate = value;
                    OnModifiedDateChanged();
                }
            }
        }

        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        public System.Data.Linq.Binary RowVersion
        {
            get { return _rowVersion; }
            set
            {
                if (_rowVersion != value)
                {
                    OnRowVersionChanging(value);
                    _rowVersion = value;
                    OnRowVersionChanged();
                }
            }
        }

        private string _passwordHash;

        /// <summary>
        /// Gets or sets the PasswordHash column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "PasswordHash", Storage = "_passwordHash", DbType = "char(86) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(86)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        public string PasswordHash
        {
            get { return _passwordHash; }
            set
            {
                if (_passwordHash != value)
                {
                    OnPasswordHashChanging(value);
                    _passwordHash = value;
                    OnPasswordHashChanged();
                }
            }
        }

        private string _passwordSalt;

        /// <summary>
        /// Gets or sets the PasswordSalt column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "PasswordSalt", Storage = "_passwordSalt", DbType = "char(5) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.Runtime.Serialization.DataMember(Order = 10)]
        public string PasswordSalt
        {
            get { return _passwordSalt; }
            set
            {
                if (_passwordSalt != value)
                {
                    OnPasswordSaltChanging(value);
                    _passwordSalt = value;
                    OnPasswordSaltChanged();
                }
            }
        }

        private string _comment;

        /// <summary>
        /// Gets or sets the Comment column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Comment", Storage = "_comment", DbType = "text", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 11)]
        public string Comment
        {
            get { return _comment; }
            set
            {
                if (_comment != value)
                {
                    OnCommentChanging(value);
                    _comment = value;
                    OnCommentChanged();
                }
            }
        }

        private bool _isApproved;

        /// <summary>
        /// Gets or sets the IsApproved column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IsApproved", Storage = "_isApproved", DbType = "bit NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 12)]
        public bool IsApproved
        {
            get { return _isApproved; }
            set
            {
                if (_isApproved != value)
                {
                    OnIsApprovedChanging(value);
                    _isApproved = value;
                    OnIsApprovedChanged();
                }
            }
        }

        private Nullable<System.DateTime> _lastLoginDate;

        /// <summary>
        /// Gets or sets the LastLoginDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastLoginDate", Storage = "_lastLoginDate", DbType = "datetime", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 13)]
        public Nullable<System.DateTime> LastLoginDate
        {
            get { return _lastLoginDate; }
            set
            {
                if (_lastLoginDate != value)
                {
                    OnLastLoginDateChanging(value);
                    _lastLoginDate = value;
                    OnLastLoginDateChanged();
                }
            }
        }

        private System.DateTime _lastActivityDate;

        /// <summary>
        /// Gets or sets the LastActivityDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastActivityDate", Storage = "_lastActivityDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 14)]
        public System.DateTime LastActivityDate
        {
            get { return _lastActivityDate; }
            set
            {
                if (_lastActivityDate != value)
                {
                    OnLastActivityDateChanging(value);
                    _lastActivityDate = value;
                    OnLastActivityDateChanged();
                }
            }
        }

        private Nullable<System.DateTime> _lastPasswordChangeDate;

        /// <summary>
        /// Gets or sets the LastPasswordChangeDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastPasswordChangeDate", Storage = "_lastPasswordChangeDate", DbType = "datetime", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 15)]
        public Nullable<System.DateTime> LastPasswordChangeDate
        {
            get { return _lastPasswordChangeDate; }
            set
            {
                if (_lastPasswordChangeDate != value)
                {
                    OnLastPasswordChangeDateChanging(value);
                    _lastPasswordChangeDate = value;
                    OnLastPasswordChangeDateChanged();
                }
            }
        }

        private string _avatarType;

        /// <summary>
        /// Gets or sets the AvatarType column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "AvatarType", Storage = "_avatarType", DbType = "nvarchar(150)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        [System.Runtime.Serialization.DataMember(Order = 16)]
        public string AvatarType
        {
            get { return _avatarType; }
            set
            {
                if (_avatarType != value)
                {
                    OnAvatarTypeChanging(value);
                    _avatarType = value;
                    OnAvatarTypeChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        partial void OnIdChanged();
        /// <summary>Called when <see cref="EmailAddress"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnEmailAddressChanging(string value);
        /// <summary>Called after <see cref="EmailAddress"/> has Changed.</summary>
        partial void OnEmailAddressChanged();
        /// <summary>Called when <see cref="FirstName"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnFirstNameChanging(string value);
        /// <summary>Called after <see cref="FirstName"/> has Changed.</summary>
        partial void OnFirstNameChanged();
        /// <summary>Called when <see cref="LastName"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastNameChanging(string value);
        /// <summary>Called after <see cref="LastName"/> has Changed.</summary>
        partial void OnLastNameChanged();
        /// <summary>Called when <see cref="Avatar"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnAvatarChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="Avatar"/> has Changed.</summary>
        partial void OnAvatarChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="ModifiedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnModifiedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="ModifiedDate"/> has Changed.</summary>
        partial void OnModifiedDateChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        partial void OnRowVersionChanged();
        /// <summary>Called when <see cref="PasswordHash"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnPasswordHashChanging(string value);
        /// <summary>Called after <see cref="PasswordHash"/> has Changed.</summary>
        partial void OnPasswordHashChanged();
        /// <summary>Called when <see cref="PasswordSalt"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnPasswordSaltChanging(string value);
        /// <summary>Called after <see cref="PasswordSalt"/> has Changed.</summary>
        partial void OnPasswordSaltChanged();
        /// <summary>Called when <see cref="Comment"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCommentChanging(string value);
        /// <summary>Called after <see cref="Comment"/> has Changed.</summary>
        partial void OnCommentChanged();
        /// <summary>Called when <see cref="IsApproved"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIsApprovedChanging(bool value);
        /// <summary>Called after <see cref="IsApproved"/> has Changed.</summary>
        partial void OnIsApprovedChanged();
        /// <summary>Called when <see cref="LastLoginDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastLoginDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="LastLoginDate"/> has Changed.</summary>
        partial void OnLastLoginDateChanged();
        /// <summary>Called when <see cref="LastActivityDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastActivityDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="LastActivityDate"/> has Changed.</summary>
        partial void OnLastActivityDateChanged();
        /// <summary>Called when <see cref="LastPasswordChangeDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastPasswordChangeDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="LastPasswordChangeDate"/> has Changed.</summary>
        partial void OnLastPasswordChangeDateChanged();
        /// <summary>Called when <see cref="AvatarType"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnAvatarTypeChanging(string value);
        /// <summary>Called after <see cref="AvatarType"/> has Changed.</summary>
        partial void OnAvatarTypeChanged();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }
        #endregion
    }
}

