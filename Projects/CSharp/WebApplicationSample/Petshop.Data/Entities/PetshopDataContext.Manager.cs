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

namespace Petshop.Data
{
    /// <summary>
    /// The DataContext manager class for the Petshop database.
    /// </summary>
    public partial class PetshopDataContext
    {
        
        private Petshop.Data.PetshopDataManager _manager = null;
        
        /// <summary>
        /// Gets the data manager.
        /// </summary>
        /// <value>The data manager.</value>
        public Petshop.Data.PetshopDataManager Manager
        {
            get
            {
                if (_manager == null)
                    _manager = new Petshop.Data.PetshopDataManager(this);
                return _manager;
            }
        }
    }
}