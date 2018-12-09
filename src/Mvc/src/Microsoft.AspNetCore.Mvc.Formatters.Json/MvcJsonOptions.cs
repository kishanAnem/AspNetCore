// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Provides programmatic configuration for JSON in the MVC framework.
    /// </summary>
    public class MvcJsonOptions
    {
        /// <summary>
        /// Gets or sets a flag to determine whether error messages from JSON deserialization by the
        /// <see cref="JsonInputFormatter"/> will be added to the <see cref="ModelStateDictionary"/>. If
        /// <see langword="false"/>, a generic error message will be used instead.
        /// </summary>
        /// <value>
        /// The default value is <see langword="true"/>.
        /// </value>
        /// <remarks>
        /// Error messages in the <see cref="ModelStateDictionary"/> are often communicated to clients, either in HTML
        /// or using <see cref="BadRequestObjectResult"/>. In effect, this setting controls whether clients can receive
        /// detailed error messages about submitted JSON data.
        /// </remarks>
        public bool AllowInputFormatterExceptionMessages { get; set; } = true;

        /// <summary>
        /// Gets the <see cref="JsonSerializerSettings"/> that are used by this application.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; } = JsonSerializerSettingsProvider.CreateSerializerSettings();
    }
}
