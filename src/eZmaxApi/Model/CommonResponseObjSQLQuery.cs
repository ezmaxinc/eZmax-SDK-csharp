/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
    /// Definition of objSQLQuery Object
    /// </summary>
    [DataContract]
    public partial class CommonResponseObjSQLQuery :  IEquatable<CommonResponseObjSQLQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjSQLQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseObjSQLQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjSQLQuery" /> class.
        /// </summary>
        /// <param name="sQuery">The SQL Query (required).</param>
        /// <param name="fDuration">Execution time of the SQL Query in seconds (required).</param>
        public CommonResponseObjSQLQuery(string sQuery = default(string), float fDuration = default(float))
        {
            // to ensure "sQuery" is required (not null)
            if (sQuery == null)
            {
                throw new InvalidDataException("sQuery is a required property for CommonResponseObjSQLQuery and cannot be null");
            }
            else
            {
                this.SQuery = sQuery;
            }

            // to ensure "fDuration" is required (not null)
            if (fDuration == null)
            {
                throw new InvalidDataException("fDuration is a required property for CommonResponseObjSQLQuery and cannot be null");
            }
            else
            {
                this.FDuration = fDuration;
            }

        }

        /// <summary>
        /// The SQL Query
        /// </summary>
        /// <value>The SQL Query</value>
        [DataMember(Name="sQuery", EmitDefaultValue=true)]
        public string SQuery { get; set; }

        /// <summary>
        /// Execution time of the SQL Query in seconds
        /// </summary>
        /// <value>Execution time of the SQL Query in seconds</value>
        [DataMember(Name="fDuration", EmitDefaultValue=true)]
        public float FDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjSQLQuery {\n");
            sb.Append("  SQuery: ").Append(SQuery).Append("\n");
            sb.Append("  FDuration: ").Append(FDuration).Append("\n");
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
            return this.Equals(input as CommonResponseObjSQLQuery);
        }

        /// <summary>
        /// Returns true if CommonResponseObjSQLQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseObjSQLQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseObjSQLQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SQuery == input.SQuery ||
                    (this.SQuery != null &&
                    this.SQuery.Equals(input.SQuery))
                ) && 
                (
                    this.FDuration == input.FDuration ||
                    (this.FDuration != null &&
                    this.FDuration.Equals(input.FDuration))
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
                if (this.SQuery != null)
                    hashCode = hashCode * 59 + this.SQuery.GetHashCode();
                if (this.FDuration != null)
                    hashCode = hashCode * 59 + this.FDuration.GetHashCode();
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