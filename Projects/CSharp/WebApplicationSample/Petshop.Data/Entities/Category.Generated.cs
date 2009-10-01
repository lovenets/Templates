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

namespace Petshop.Data
{
    /// <summary>
    /// The class representing the dbo.Category table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Category")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("CategoryId")]
    [System.Diagnostics.DebuggerDisplay("CategoryId: {CategoryId}")]
    public partial class Category
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Category"/> class.
        /// </summary>
        static Category()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<Category>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Category()
        {
            Initialize();
        }

        private void Initialize()
        {
            _productList = new System.Data.Linq.EntitySet<Product>(OnProductListAdd, OnProductListRemove);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        private string _categoryId;

        /// <summary>
        /// Gets or sets the CategoryId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CategoryId", Storage = "_categoryId", DbType = "varchar(10) NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public string CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (_categoryId != value)
                {
                    OnCategoryIdChanging(value);
                    SendPropertyChanging("CategoryId");
                    _categoryId = value;
                    SendPropertyChanged("CategoryId");
                    OnCategoryIdChanged();
                }
            }
        }

        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "varchar(80)")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        private string _descn;

        /// <summary>
        /// Gets or sets the Descn column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Descn", Storage = "_descn", DbType = "varchar(255)")]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public string Descn
        {
            get { return _descn; }
            set
            {
                if (_descn != value)
                {
                    OnDescnChanging(value);
                    SendPropertyChanging("Descn");
                    _descn = value;
                    SendPropertyChanged("Descn");
                    OnDescnChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntitySet<Product> _productList;

        /// <summary>
        /// Gets or sets the Product association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Category_Product", Storage = "_productList", ThisKey = "CategoryId", OtherKey = "CategoryId")]
        [System.Runtime.Serialization.DataMember(Order=4, EmitDefaultValue=false)]
        public System.Data.Linq.EntitySet<Product> ProductList
        {
            get { return (serializing && !_productList.HasLoadedOrAssignedValues) ? null : _productList; }
            set { _productList.Assign(value); }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnProductListAdd(Product entity)
        {
            SendPropertyChanging(null);
            entity.Category = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnProductListRemove(Product entity)
        {
            SendPropertyChanging(null);
            entity.Category = null;
            SendPropertyChanged(null);
        }
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
        /// <summary>Called when <see cref="CategoryId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCategoryIdChanging(string value);
        /// <summary>Called after <see cref="CategoryId"/> has Changed.</summary>
        partial void OnCategoryIdChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        partial void OnNameChanged();
        /// <summary>Called when <see cref="Descn"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnDescnChanging(string value);
        /// <summary>Called after <see cref="Descn"/> has Changed.</summary>
        partial void OnDescnChanged();

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

        /// <summary>
        /// Deserializes an instance of <see cref="Category"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Category"/> instance.</param>
        /// <returns>An instance of <see cref="Category"/> that is deserialized from the XML string.</returns>
        public static Category FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Category));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Category;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Category"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Category"/> instance.</param>
        /// <returns>An instance of <see cref="Category"/> that is deserialized from the byte array.</returns>
        public static Category FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Category));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Category;
            }
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Category Clone()
        {
            return (Category)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _productList = Detach(_productList, OnProductListAdd, OnProductListRemove);
        }
        #endregion
    }
}

