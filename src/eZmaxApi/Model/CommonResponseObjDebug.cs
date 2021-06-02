/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.45
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// This is a generic debug object that is returned by all API requests
    /// </summary>
    [DataContract]
    public partial class CommonResponseObjDebug :  IEquatable<CommonResponseObjDebug>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebug" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseObjDebug() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebug" /> class.
        /// </summary>
        /// <param name="sMemoryUsage">The peak memory allocated during the API request execution. Formatted as a human readable string (required).</param>
        /// <param name="sRunTime">The total server execution time of the API request execution. Formatted as a human readable string (required).</param>
        /// <param name="iSQLSelects">The number of SQL SELECT queries that were sent to the database server during the API request execution (required).</param>
        /// <param name="iSQLQueries">The number of SQL INSERT/UPDATE/DELETE queries that were sent to the database server during the API request execution (required).</param>
        /// <param name="aObjSQLQuery">An array of the SQL Queries that were executed during the API request execution (required).</param>
        public CommonResponseObjDebug(string sMemoryUsage = default(string), string sRunTime = default(string), int iSQLSelects = default(int), int iSQLQueries = default(int), List<CommonResponseObjSQLQuery> aObjSQLQuery = default(List<CommonResponseObjSQLQuery>))
        {
            // to ensure "sMemoryUsage" is required (not null)
            if (sMemoryUsage == null)
            {
                throw new InvalidDataException("sMemoryUsage is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.SMemoryUsage = sMemoryUsage;
            }

            // to ensure "sRunTime" is required (not null)
            if (sRunTime == null)
            {
                throw new InvalidDataException("sRunTime is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.SRunTime = sRunTime;
            }

            // to ensure "iSQLSelects" is required (not null)
            if (iSQLSelects == null)
            {
                throw new InvalidDataException("iSQLSelects is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.ISQLSelects = iSQLSelects;
            }

            // to ensure "iSQLQueries" is required (not null)
            if (iSQLQueries == null)
            {
                throw new InvalidDataException("iSQLQueries is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.ISQLQueries = iSQLQueries;
            }

            // to ensure "aObjSQLQuery" is required (not null)
            if (aObjSQLQuery == null)
            {
                throw new InvalidDataException("aObjSQLQuery is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.AObjSQLQuery = aObjSQLQuery;
            }

        }

        /// <summary>
        /// The peak memory allocated during the API request execution. Formatted as a human readable string
        /// </summary>
        /// <value>The peak memory allocated during the API request execution. Formatted as a human readable string</value>
        [DataMember(Name="sMemoryUsage", EmitDefaultValue=true)]
        public string SMemoryUsage { get; set; }

        /// <summary>
        /// The total server execution time of the API request execution. Formatted as a human readable string
        /// </summary>
        /// <value>The total server execution time of the API request execution. Formatted as a human readable string</value>
        [DataMember(Name="sRunTime", EmitDefaultValue=true)]
        public string SRunTime { get; set; }

        /// <summary>
        /// The number of SQL SELECT queries that were sent to the database server during the API request execution
        /// </summary>
        /// <value>The number of SQL SELECT queries that were sent to the database server during the API request execution</value>
        [DataMember(Name="iSQLSelects", EmitDefaultValue=true)]
        public int ISQLSelects { get; set; }

        /// <summary>
        /// The number of SQL INSERT/UPDATE/DELETE queries that were sent to the database server during the API request execution
        /// </summary>
        /// <value>The number of SQL INSERT/UPDATE/DELETE queries that were sent to the database server during the API request execution</value>
        [DataMember(Name="iSQLQueries", EmitDefaultValue=true)]
        public int ISQLQueries { get; set; }

        /// <summary>
        /// An array of the SQL Queries that were executed during the API request execution
        /// </summary>
        /// <value>An array of the SQL Queries that were executed during the API request execution</value>
        [DataMember(Name="a_objSQLQuery", EmitDefaultValue=true)]
        public List<CommonResponseObjSQLQuery> AObjSQLQuery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjDebug {\n");
            sb.Append("  SMemoryUsage: ").Append(SMemoryUsage).Append("\n");
            sb.Append("  SRunTime: ").Append(SRunTime).Append("\n");
            sb.Append("  ISQLSelects: ").Append(ISQLSelects).Append("\n");
            sb.Append("  ISQLQueries: ").Append(ISQLQueries).Append("\n");
            sb.Append("  AObjSQLQuery: ").Append(AObjSQLQuery).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonResponseObjDebug);
        }

        /// <summary>
        /// Returns true if CommonResponseObjDebug instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseObjDebug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseObjDebug input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SMemoryUsage == input.SMemoryUsage ||
                    (this.SMemoryUsage != null &&
                    this.SMemoryUsage.Equals(input.SMemoryUsage))
                ) && 
                (
                    this.SRunTime == input.SRunTime ||
                    (this.SRunTime != null &&
                    this.SRunTime.Equals(input.SRunTime))
                ) && 
                (
                    this.ISQLSelects == input.ISQLSelects ||
                    (this.ISQLSelects != null &&
                    this.ISQLSelects.Equals(input.ISQLSelects))
                ) && 
                (
                    this.ISQLQueries == input.ISQLQueries ||
                    (this.ISQLQueries != null &&
                    this.ISQLQueries.Equals(input.ISQLQueries))
                ) && 
                (
                    this.AObjSQLQuery == input.AObjSQLQuery ||
                    this.AObjSQLQuery != null &&
                    input.AObjSQLQuery != null &&
                    this.AObjSQLQuery.SequenceEqual(input.AObjSQLQuery)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SMemoryUsage != null)
                    hashCode = hashCode * 59 + this.SMemoryUsage.GetHashCode();
                if (this.SRunTime != null)
                    hashCode = hashCode * 59 + this.SRunTime.GetHashCode();
                if (this.ISQLSelects != null)
                    hashCode = hashCode * 59 + this.ISQLSelects.GetHashCode();
                if (this.ISQLQueries != null)
                    hashCode = hashCode * 59 + this.ISQLQueries.GetHashCode();
                if (this.AObjSQLQuery != null)
                    hashCode = hashCode * 59 + this.AObjSQLQuery.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
