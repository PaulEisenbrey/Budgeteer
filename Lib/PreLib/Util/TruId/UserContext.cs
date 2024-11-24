//-------------------------------------------------------------------------------------------------
// <copyright file="UserContext.cs" company="Trupanion">
//     Copyright(c) 2014-2017 by Trupanion. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------------------------

namespace Utilities.TruId
{
    using System;

    using Utilities.IoCInterfaces;
    using Utilities.TruId.Interfaces;

    public class UserContext : IUserContext, ITransientSvc
    {
        private Guid uniqueId;

        public UserContext()
        {
            this.Reset();
        }

        public Guid UniqueId 
        {
            get
            {
                return uniqueId;
            }
            set
            {
                uniqueId = value;
            }
        }

        public string? Name { get; set; }

        public string? DisplayName { get; set; }

        public int LegacyId { get; set; }

        public void Reset()
        {
            this.UniqueId = Guid.Empty;
            this.Name = null;
            this.DisplayName = null;

            // TODO: review this default. not sure this is correct for all scenarios.
            this.LegacyId = 1;
        }
    }
}
