﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Petshop.Data
{
    /// <summary>
    /// The manager class for Product.
    /// </summary>
    public partial class ProductManager 
        : CodeSmith.Data.EntityManagerBase<PetshopDataManager, Petshop.Data.Product>
    {
        /// <summary>
        /// Initializes the <see cref="ProductManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public ProductManager(PetshopDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        protected Petshop.Data.PetshopDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        protected System.Data.Linq.Table<Petshop.Data.Product> Entity
        {
            get { return Manager.Context.Product; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        public static CodeSmith.Data.IEntityKey<string> CreateKey(string productId)
        {
            return new CodeSmith.Data.EntityKey<string>(productId);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;string&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;string&gt;.</exception>
        public override Petshop.Data.Product GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<string>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<string>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<string>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public Petshop.Data.Product GetByKey(string productId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, productId);
            else
                return Entity.FirstOrDefault(p => p.ProductId == productId);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        public int Delete(string productId)
        {
            return Entity.Delete(p => p.ProductId == productId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Petshop.Data.Product> GetByName(string name)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByName.Invoke(Context, name);
            else
                return Entity.Where(p => p.Name == name);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Petshop.Data.Product> GetByCategoryId(string categoryId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByCategoryId.Invoke(Context, categoryId);
            else
                return Entity.Where(p => p.CategoryId == categoryId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Petshop.Data.Product> GetByCategoryIdName(string categoryId, string name)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByCategoryIdName.Invoke(Context, categoryId, name);
            else
                return Entity.Where(p => p.CategoryId == categoryId 
					&& p.Name == name);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Petshop.Data.Product> GetByCategoryIdProductIdName(string categoryId, string productId, string name)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByCategoryIdProductIdName.Invoke(Context, categoryId, productId, name);
            else
                return Entity.Where(p => p.CategoryId == categoryId 
					&& p.ProductId == productId 
					&& p.Name == name);
        }

        #region Extensibility Method Definitions
        /// <summary>Called when the class is created.</summary>
        partial void OnCreated();
        #endregion
        
        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Petshop.Data.PetshopDataContext, string, Petshop.Data.Product> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, string productId) => 
                        db.Product.FirstOrDefault(p => p.ProductId == productId));

            internal static readonly Func<Petshop.Data.PetshopDataContext, string, IQueryable<Petshop.Data.Product>> GetByName = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, string name) => 
                        db.Product.Where(p => p.Name == name));

            internal static readonly Func<Petshop.Data.PetshopDataContext, string, IQueryable<Petshop.Data.Product>> GetByCategoryId = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, string categoryId) => 
                        db.Product.Where(p => p.CategoryId == categoryId));

            internal static readonly Func<Petshop.Data.PetshopDataContext, string, string, IQueryable<Petshop.Data.Product>> GetByCategoryIdName = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, string categoryId, string name) => 
                        db.Product.Where(p => p.CategoryId == categoryId 
							&& p.Name == name));

            internal static readonly Func<Petshop.Data.PetshopDataContext, string, string, string, IQueryable<Petshop.Data.Product>> GetByCategoryIdProductIdName = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, string categoryId, string productId, string name) => 
                        db.Product.Where(p => p.CategoryId == categoryId 
							&& p.ProductId == productId 
							&& p.Name == name));

        }
        #endregion
    }
}

