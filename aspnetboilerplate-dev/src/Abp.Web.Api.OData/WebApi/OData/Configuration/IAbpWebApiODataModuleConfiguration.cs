﻿using System;
using System.Web.OData.Builder;
using Abp.Configuration.Startup;

namespace Abp.WebApi.OData.Configuration
{
    /// <summary>
    /// Used to configure Abp.Web.Api.OData module.
    /// </summary>
    public interface IAbpWebApiODataModuleConfiguration
    {
        /// <summary>
        /// Gets ODataConventionModelBuilder.
        /// </summary>
        ODataConventionModelBuilder ODataModelBuilder { get; set; }

        /// <summary>
        /// Allows overriding OData mapping.
        /// </summary>
        Action<IAbpStartupConfiguration> MapAction { get; set; }
    }
}