/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.26
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
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp.Model
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
                this.sMemoryUsage = sMemoryUsage;
            }
            
            // to ensure "sRunTime" is required (not null)
            if (sRunTime == null)
            {
                throw new InvalidDataException("sRunTime is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.sRunTime = sRunTime;
            }
            
            // to ensure "iSQLSelects" is required (not null)
            if (iSQLSelects == null)
            {
                throw new InvalidDataException("iSQLSelects is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.iSQLSelects = iSQLSelects;
            }
            
            // to ensure "iSQLQueries" is required (not null)
            if (iSQLQueries == null)
            {
                throw new InvalidDataException("iSQLQueries is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.iSQLQueries = iSQLQueries;
            }
            
            // to ensure "aObjSQLQuery" is required (not null)
            if (aObjSQLQuery == null)
            {
                throw new InvalidDataException("aObjSQLQuery is a required property for CommonResponseObjDebug and cannot be null");
            }
            else
            {
                this.a_objSQLQuery = aObjSQLQuery;
            }
            
        }
        
        /// <summary>
        /// The peak memory allocated during the API request execution. Formatted as a human readable string
        /// </summary>
        /// <value>The peak memory allocated during the API request execution. Formatted as a human readable string</value>
        [DataMember(Name="sMemoryUsage", EmitDefaultValue=true)]
        public string sMemoryUsage { get; set; }

        /// <summary>
        /// The total server execution time of the API request execution. Formatted as a human readable string
        /// </summary>
        /// <value>The total server execution time of the API request execution. Formatted as a human readable string</value>
        [DataMember(Name="sRunTime", EmitDefaultValue=true)]
        public string sRunTime { get; set; }

        /// <summary>
        /// The number of SQL SELECT queries that were sent to the database server during the API request execution
        /// </summary>
        /// <value>The number of SQL SELECT queries that were sent to the database server during the API request execution</value>
        [DataMember(Name="iSQLSelects", EmitDefaultValue=true)]
        public int iSQLSelects { get; set; }

        /// <summary>
        /// The number of SQL INSERT/UPDATE/DELETE queries that were sent to the database server during the API request execution
        /// </summary>
        /// <value>The number of SQL INSERT/UPDATE/DELETE queries that were sent to the database server during the API request execution</value>
        [DataMember(Name="iSQLQueries", EmitDefaultValue=true)]
        public int iSQLQueries { get; set; }

        /// <summary>
        /// An array of the SQL Queries that were executed during the API request execution
        /// </summary>
        /// <value>An array of the SQL Queries that were executed during the API request execution</value>
        [DataMember(Name="a_objSQLQuery", EmitDefaultValue=true)]
        public List<CommonResponseObjSQLQuery> a_objSQLQuery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjDebug {\n");
            sb.Append("  sMemoryUsage: ").Append(sMemoryUsage).Append("\n");
            sb.Append("  sRunTime: ").Append(sRunTime).Append("\n");
            sb.Append("  iSQLSelects: ").Append(iSQLSelects).Append("\n");
            sb.Append("  iSQLQueries: ").Append(iSQLQueries).Append("\n");
            sb.Append("  a_objSQLQuery: ").Append(a_objSQLQuery).Append("\n");
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
                    this.sMemoryUsage == input.sMemoryUsage ||
                    (this.sMemoryUsage != null &&
                    this.sMemoryUsage.Equals(input.sMemoryUsage))
                ) && 
                (
                    this.sRunTime == input.sRunTime ||
                    (this.sRunTime != null &&
                    this.sRunTime.Equals(input.sRunTime))
                ) && 
                (
                    this.iSQLSelects == input.iSQLSelects ||
                    (this.iSQLSelects != null &&
                    this.iSQLSelects.Equals(input.iSQLSelects))
                ) && 
                (
                    this.iSQLQueries == input.iSQLQueries ||
                    (this.iSQLQueries != null &&
                    this.iSQLQueries.Equals(input.iSQLQueries))
                ) && 
                (
                    this.a_objSQLQuery == input.a_objSQLQuery ||
                    this.a_objSQLQuery != null &&
                    input.a_objSQLQuery != null &&
                    this.a_objSQLQuery.SequenceEqual(input.a_objSQLQuery)
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
                if (this.sMemoryUsage != null)
                    hashCode = hashCode * 59 + this.sMemoryUsage.GetHashCode();
                if (this.sRunTime != null)
                    hashCode = hashCode * 59 + this.sRunTime.GetHashCode();
                if (this.iSQLSelects != null)
                    hashCode = hashCode * 59 + this.iSQLSelects.GetHashCode();
                if (this.iSQLQueries != null)
                    hashCode = hashCode * 59 + this.iSQLQueries.GetHashCode();
                if (this.a_objSQLQuery != null)
                    hashCode = hashCode * 59 + this.a_objSQLQuery.GetHashCode();
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
