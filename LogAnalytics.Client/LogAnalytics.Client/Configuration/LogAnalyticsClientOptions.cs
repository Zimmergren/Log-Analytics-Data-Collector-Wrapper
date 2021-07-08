﻿namespace LogAnalytics.Client.Configuration
{
    /// <summary>
    /// Log Analytics Client Options.
    /// Defines settings for the Log Analytics Client.
    /// </summary>
    public class LogAnalyticsClientOptions
    {
        /// <summary>
        /// Gets or sets the Workspace ID.
        /// </summary>
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets the Shared Key.
        /// </summary>
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets the Azure Sovereign Cloud.
        /// </summary>
        public string EndPointOverride { get; set; }
    }
}
