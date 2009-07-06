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
using System.Data.Linq;

namespace PetShop.Core.Data
{
    /// <summary>
    /// The query extension class for Account.
    /// </summary>
    public static partial class AccountExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static PetShop.Core.Data.Account ByKey(this IQueryable<PetShop.Core.Data.Account> queryable, int accountId)
        {
            var entity = queryable as System.Data.Linq.Table<PetShop.Core.Data.Account>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.ByKey.Invoke((PetShop.Core.Data.PetShopDataContext)entity.Context, accountId);
            
            return queryable.FirstOrDefault(a => a.AccountId == accountId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<PetShop.Core.Data.Account> table, int accountId)
        {
            return table.Delete(a => a.AccountId == accountId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.UniqueID"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByUniqueID(this IQueryable<PetShop.Core.Data.Account> queryable, int uniqueID)
        {
            return queryable.Where(a => a.UniqueID == uniqueID);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Email"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByEmail(this IQueryable<PetShop.Core.Data.Account> queryable, string email)
        {
            return queryable.Where(a => a.Email == email);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.FirstName"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByFirstName(this IQueryable<PetShop.Core.Data.Account> queryable, string firstName)
        {
            return queryable.Where(a => a.FirstName == firstName);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.LastName"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByLastName(this IQueryable<PetShop.Core.Data.Account> queryable, string lastName)
        {
            return queryable.Where(a => a.LastName == lastName);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Address1"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByAddress1(this IQueryable<PetShop.Core.Data.Account> queryable, string address1)
        {
            return queryable.Where(a => a.Address1 == address1);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Address2"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByAddress2(this IQueryable<PetShop.Core.Data.Account> queryable, string address2)
        {
            return queryable.Where(a => object.Equals(a.Address2, address2));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.City"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByCity(this IQueryable<PetShop.Core.Data.Account> queryable, string city)
        {
            return queryable.Where(a => a.City == city);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.State"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByState(this IQueryable<PetShop.Core.Data.Account> queryable, string state)
        {
            return queryable.Where(a => a.State == state);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Zip"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByZip(this IQueryable<PetShop.Core.Data.Account> queryable, string zip)
        {
            return queryable.Where(a => a.Zip == zip);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Country"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByCountry(this IQueryable<PetShop.Core.Data.Account> queryable, string country)
        {
            return queryable.Where(a => a.Country == country);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Account.Phone"/>.
        /// </summary>
        public static IQueryable<PetShop.Core.Data.Account> ByPhone(this IQueryable<PetShop.Core.Data.Account> queryable, string phone)
        {
            return queryable.Where(a => object.Equals(a.Phone, phone));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<PetShop.Core.Data.PetShopDataContext, int, PetShop.Core.Data.Account> ByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (PetShop.Core.Data.PetShopDataContext db, int accountId) => 
                        db.Account.FirstOrDefault(a => a.AccountId == accountId));

        }
        #endregion
    }
}
