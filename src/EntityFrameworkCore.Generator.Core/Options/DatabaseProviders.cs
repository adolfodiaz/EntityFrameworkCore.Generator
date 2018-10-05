﻿using System;

namespace EntityFrameworkCore.Generator.Options
{
    /// <summary>
    /// The database to generate code for
    /// </summary>
    public enum DatabaseProviders
    {
        /// <summary>
        /// The SQL server provider
        /// </summary>
        SqlServer,

        /// <summary>
        /// The PostgreSQL provider
        /// </summary>
        PostgreSQL,

        /// <summary>
        /// The sqlite provider
        /// </summary>
        Sqlite
    }
}