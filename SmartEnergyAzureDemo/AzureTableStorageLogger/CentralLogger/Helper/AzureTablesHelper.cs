﻿// --------------------------------------------------------------------------------------------------------------------
// This code is published under the The MIT License (MIT). See LICENSE.TXT for details. 
// Copyright(c) Microsoft and Contributors
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogger.Helper
{
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    class AzureTablesHelper
    {
        /// <summary>
        /// Take an Azure Table Storage filter as a string and append an additional condition
        /// </summary>
        /// <param name="properties">Name / Value Dictionary to filter entities by</param>
        /// <returns>A string representing the combined filter</returns>
        internal static string CreateTableStorageQueryFilter<T>(Dictionary<string, string> properties)
            where T : ITableEntity, new()
        {
            if (!properties.Any())
            {
                throw new ArgumentException("CreateTableStorageQueryFilter: At least one condition must be supplied");
            }

            //Generate a filter object with the first property
            var element = properties.First();
            var filter =
                new TableQuery<T>().Where(TableQuery.GenerateFilterCondition(element.Key,
                    QueryComparisons.Equal, element.Value)).FilterString;

            //Combine any additional properties to that filter
            foreach (var property in properties.Where((t => t.Key != element.Key)))
            {
                var additionalFilter = new TableQuery<T>().Where(TableQuery.GenerateFilterCondition(property.Key,
                    QueryComparisons.Equal, property.Value)).FilterString;
                filter = CombineAzureTableStorageQueryFilters(filter, additionalFilter);
            }

            return filter;
        }

        /// <summary>
        /// Take an Azure Table Storage filter as a string and append an additional condition
        /// </summary>
        /// <param name="currentFilter">The current filter</param>
        /// <param name="filterToAdd">The filter to combine with the currentFilter object</param>
        /// <returns>A string representing the combined filter</returns>
        public static string CombineAzureTableStorageQueryFilters(string currentFilter, string filterToAdd)
        {
            return TableQuery.CombineFilters(currentFilter,
                TableOperators.And,
                filterToAdd);
        }

        public static CloudTable GetAzureTablesTableObject(string connectionString, string tableName)
        {
            // Retrieve the storage account from the connection string.
            var storageAccount =
                CloudStorageAccount.Parse(connectionString);

            // Create the table client.
            var tableClient = storageAccount.CreateCloudTableClient();

            // Create the CloudTable object that represents the table.
            var table = tableClient.GetTableReference(tableName);
            return table;
        }

        /// <summary>
        /// Append time based filters, if supplied, to the given Azure Table Query string
        /// </summary>
        /// <param name="startDateTime">Datetime of a Minimum datetime filter to apply</param>
        /// <param name="endDateTime">Datetime of a Maximum datetime filter to apply</param>
        /// <param name="filterToAppendTo">The Filter to append the optional DateTime filters to</param>
        /// <returns>Filter text with any datetime filters applied</returns>
        public static string AppendOptionalTimeBasedFilters(DateTime? startDateTime, DateTime? endDateTime, string filterToAppendTo)
        {
            string completedFilterString = filterToAppendTo;

            if (startDateTime != null)
            {
                completedFilterString = AppendNewerThanTableStorageDateTimeQueryFilter(completedFilterString, startDateTime.Value);
            }
            if (endDateTime != null)
            {
                completedFilterString = AppendOlderThanTableStorageDateTimeQueryFilter(completedFilterString, endDateTime.Value);
            }

            return completedFilterString;
        }

        /// <summary>
        /// Take an Azure Table Storage filter as a string and append a condition to return only values who's timestamp is
        /// after the given DateTime
        /// </summary>
        /// <param name="currentFilter">The current filter</param>
        /// <param name="dateTime">The dateTime to append as the condition</param>
        /// <returns>A string representing the combined filter</returns>
        public static string AppendNewerThanTableStorageDateTimeQueryFilter(string currentFilter, DateTime dateTime)
        {
            var timeQuery = TableQuery.GenerateFilterConditionForDate("Timestamp",
                QueryComparisons.GreaterThanOrEqual, dateTime);

            if (string.IsNullOrEmpty(currentFilter))
            {
                return timeQuery;
            }

            return CombineAzureTableStorageQueryFilters(currentFilter, timeQuery);
        }

        /// <summary>
        /// Take an Azure Table Storage filter as a string and append a condition to return only values who's timestamp is
        /// before the given DateTime
        /// </summary>
        /// <param name="currentFilter">The current filter</param>
        /// <param name="dateTime">The dateTime to append as the condition</param>
        /// <returns>A string representing the combined filter</returns>
        public static string AppendOlderThanTableStorageDateTimeQueryFilter(string currentFilter, DateTime dateTime)
        {
            var timeQuery = TableQuery.GenerateFilterConditionForDate("Timestamp",
                QueryComparisons.LessThanOrEqual, dateTime);

            return CombineAzureTableStorageQueryFilters(currentFilter, timeQuery);
        }
    }
}
