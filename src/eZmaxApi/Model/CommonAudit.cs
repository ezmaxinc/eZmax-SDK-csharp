/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.41
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
    /// Gives informations about the user that created the object and the last user to have modified it.  If the object was never modified after creation, both Created and Modified informations will be the same.  Apikey details will only be provided if the changes were made by an API key.  
    /// </summary>
    [DataContract]
    public partial class CommonAudit :  IEquatable<CommonAudit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAudit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonAudit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAudit" /> class.
        /// </summary>
        /// <param name="fkiUserIDCreated">The unique ID of the User (required).</param>
        /// <param name="fkiUserIDModified">The unique ID of the User (required).</param>
        /// <param name="fkiApikeyIDCreated">The unique ID of the Apikey.</param>
        /// <param name="fkiApikeyIDModified">The unique ID of the Apikey.</param>
        /// <param name="dtCreatedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="dtModifiedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        public CommonAudit(int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string))
        {
            // to ensure "fkiUserIDCreated" is required (not null)
            if (fkiUserIDCreated == null)
            {
                throw new InvalidDataException("fkiUserIDCreated is a required property for CommonAudit and cannot be null");
            }
            else
            {
                this.FkiUserIDCreated = fkiUserIDCreated;
            }

            // to ensure "fkiUserIDModified" is required (not null)
            if (fkiUserIDModified == null)
            {
                throw new InvalidDataException("fkiUserIDModified is a required property for CommonAudit and cannot be null");
            }
            else
            {
                this.FkiUserIDModified = fkiUserIDModified;
            }

            // to ensure "dtCreatedDate" is required (not null)
            if (dtCreatedDate == null)
            {
                throw new InvalidDataException("dtCreatedDate is a required property for CommonAudit and cannot be null");
            }
            else
            {
                this.DtCreatedDate = dtCreatedDate;
            }

            // to ensure "dtModifiedDate" is required (not null)
            if (dtModifiedDate == null)
            {
                throw new InvalidDataException("dtModifiedDate is a required property for CommonAudit and cannot be null");
            }
            else
            {
                this.DtModifiedDate = dtModifiedDate;
            }

            this.FkiApikeyIDCreated = fkiApikeyIDCreated;
            this.FkiApikeyIDModified = fkiApikeyIDModified;
        }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="fkiUserIDCreated", EmitDefaultValue=true)]
        public int FkiUserIDCreated { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="fkiUserIDModified", EmitDefaultValue=true)]
        public int FkiUserIDModified { get; set; }

        /// <summary>
        /// The unique ID of the Apikey
        /// </summary>
        /// <value>The unique ID of the Apikey</value>
        [DataMember(Name="fkiApikeyIDCreated", EmitDefaultValue=false)]
        public int FkiApikeyIDCreated { get; set; }

        /// <summary>
        /// The unique ID of the Apikey
        /// </summary>
        /// <value>The unique ID of the Apikey</value>
        [DataMember(Name="fkiApikeyIDModified", EmitDefaultValue=false)]
        public int FkiApikeyIDModified { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name="dtCreatedDate", EmitDefaultValue=true)]
        public string DtCreatedDate { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name="dtModifiedDate", EmitDefaultValue=true)]
        public string DtModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonAudit {\n");
            sb.Append("  FkiUserIDCreated: ").Append(FkiUserIDCreated).Append("\n");
            sb.Append("  FkiUserIDModified: ").Append(FkiUserIDModified).Append("\n");
            sb.Append("  FkiApikeyIDCreated: ").Append(FkiApikeyIDCreated).Append("\n");
            sb.Append("  FkiApikeyIDModified: ").Append(FkiApikeyIDModified).Append("\n");
            sb.Append("  DtCreatedDate: ").Append(DtCreatedDate).Append("\n");
            sb.Append("  DtModifiedDate: ").Append(DtModifiedDate).Append("\n");
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
            return this.Equals(input as CommonAudit);
        }

        /// <summary>
        /// Returns true if CommonAudit instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonAudit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiUserIDCreated == input.FkiUserIDCreated ||
                    (this.FkiUserIDCreated != null &&
                    this.FkiUserIDCreated.Equals(input.FkiUserIDCreated))
                ) && 
                (
                    this.FkiUserIDModified == input.FkiUserIDModified ||
                    (this.FkiUserIDModified != null &&
                    this.FkiUserIDModified.Equals(input.FkiUserIDModified))
                ) && 
                (
                    this.FkiApikeyIDCreated == input.FkiApikeyIDCreated ||
                    (this.FkiApikeyIDCreated != null &&
                    this.FkiApikeyIDCreated.Equals(input.FkiApikeyIDCreated))
                ) && 
                (
                    this.FkiApikeyIDModified == input.FkiApikeyIDModified ||
                    (this.FkiApikeyIDModified != null &&
                    this.FkiApikeyIDModified.Equals(input.FkiApikeyIDModified))
                ) && 
                (
                    this.DtCreatedDate == input.DtCreatedDate ||
                    (this.DtCreatedDate != null &&
                    this.DtCreatedDate.Equals(input.DtCreatedDate))
                ) && 
                (
                    this.DtModifiedDate == input.DtModifiedDate ||
                    (this.DtModifiedDate != null &&
                    this.DtModifiedDate.Equals(input.DtModifiedDate))
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
                if (this.FkiUserIDCreated != null)
                    hashCode = hashCode * 59 + this.FkiUserIDCreated.GetHashCode();
                if (this.FkiUserIDModified != null)
                    hashCode = hashCode * 59 + this.FkiUserIDModified.GetHashCode();
                if (this.FkiApikeyIDCreated != null)
                    hashCode = hashCode * 59 + this.FkiApikeyIDCreated.GetHashCode();
                if (this.FkiApikeyIDModified != null)
                    hashCode = hashCode * 59 + this.FkiApikeyIDModified.GetHashCode();
                if (this.DtCreatedDate != null)
                    hashCode = hashCode * 59 + this.DtCreatedDate.GetHashCode();
                if (this.DtModifiedDate != null)
                    hashCode = hashCode * 59 + this.DtModifiedDate.GetHashCode();
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
