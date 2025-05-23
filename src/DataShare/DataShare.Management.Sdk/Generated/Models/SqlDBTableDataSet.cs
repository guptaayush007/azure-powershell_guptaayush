// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataShare.Models
{
    using System.Linq;

    /// <summary>
    /// A SQL DB table data set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SqlDBTable")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SqlDBTableDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the SqlDBTableDataSet class.
        /// </summary>
        public SqlDBTableDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDBTableDataSet class.
        /// </summary>

        /// <param name="id">The resource id of the azure resource
        /// </param>

        /// <param name="name">Name of the azure resource
        /// </param>

        /// <param name="type">Type of the azure resource
        /// </param>

        /// <param name="databaseName">Database name of the source data set
        /// </param>

        /// <param name="dataSetId">Unique id for identifying a data set resource
        /// </param>

        /// <param name="schemaName">Schema of the table. Default value is dbo.
        /// </param>

        /// <param name="sqlServerResourceId">Resource id of SQL server
        /// </param>

        /// <param name="tableName">SQL DB table name.
        /// </param>
        public SqlDBTableDataSet(string id = default(string), string name = default(string), string type = default(string), string databaseName = default(string), string dataSetId = default(string), string schemaName = default(string), string sqlServerResourceId = default(string), string tableName = default(string))

        : base(id, name, type)
        {
            this.DatabaseName = databaseName;
            this.DataSetId = dataSetId;
            this.SchemaName = schemaName;
            this.SqlServerResourceId = sqlServerResourceId;
            this.TableName = tableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets database name of the source data set
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName {get; set; }

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId {get; private set; }

        /// <summary>
        /// Gets or sets schema of the table. Default value is dbo.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.schemaName")]
        public string SchemaName {get; set; }

        /// <summary>
        /// Gets or sets resource id of SQL server
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sqlServerResourceId")]
        public string SqlServerResourceId {get; set; }

        /// <summary>
        /// Gets or sets sQL DB table name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tableName")]
        public string TableName {get; set; }
    }
}