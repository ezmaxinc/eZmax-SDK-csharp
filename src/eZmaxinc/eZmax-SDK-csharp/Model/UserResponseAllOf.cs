/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
    /// UserResponseAllOf
    /// </summary>
    [DataContract]
    public partial class UserResponseAllOf :  IEquatable<UserResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseAllOf" /> class.
        /// </summary>
        /// <param name="pkiUserID">The unique ID of the User (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="eUserType">eUserType (required).</param>
        /// <param name="sUserFirstname">The First name of the user (required).</param>
        /// <param name="sUserLastname">The Last name of the user (required).</param>
        /// <param name="sUserLoginname">The Login name of the User. (required).</param>
        public UserResponseAllOf(int pkiUserID = default(int), int fkiLanguageID = default(int), FieldEUserType eUserType = default(FieldEUserType), string sUserFirstname = default(string), string sUserLastname = default(string), string sUserLoginname = default(string))
        {
            // to ensure "pkiUserID" is required (not null)
            if (pkiUserID == null)
            {
                throw new InvalidDataException("pkiUserID is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.pkiUserID = pkiUserID;
            }
            
            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.fkiLanguageID = fkiLanguageID;
            }
            
            // to ensure "eUserType" is required (not null)
            if (eUserType == null)
            {
                throw new InvalidDataException("eUserType is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.eUserType = eUserType;
            }
            
            // to ensure "sUserFirstname" is required (not null)
            if (sUserFirstname == null)
            {
                throw new InvalidDataException("sUserFirstname is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.sUserFirstname = sUserFirstname;
            }
            
            // to ensure "sUserLastname" is required (not null)
            if (sUserLastname == null)
            {
                throw new InvalidDataException("sUserLastname is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.sUserLastname = sUserLastname;
            }
            
            // to ensure "sUserLoginname" is required (not null)
            if (sUserLoginname == null)
            {
                throw new InvalidDataException("sUserLoginname is a required property for UserResponseAllOf and cannot be null");
            }
            else
            {
                this.sUserLoginname = sUserLoginname;
            }
            
        }
        
        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="pkiUserID", EmitDefaultValue=true)]
        public int pkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// Gets or Sets eUserType
        /// </summary>
        [DataMember(Name="eUserType", EmitDefaultValue=true)]
        public FieldEUserType eUserType { get; set; }

        /// <summary>
        /// The First name of the user
        /// </summary>
        /// <value>The First name of the user</value>
        [DataMember(Name="sUserFirstname", EmitDefaultValue=true)]
        public string sUserFirstname { get; set; }

        /// <summary>
        /// The Last name of the user
        /// </summary>
        /// <value>The Last name of the user</value>
        [DataMember(Name="sUserLastname", EmitDefaultValue=true)]
        public string sUserLastname { get; set; }

        /// <summary>
        /// The Login name of the User.
        /// </summary>
        /// <value>The Login name of the User.</value>
        [DataMember(Name="sUserLoginname", EmitDefaultValue=true)]
        public string sUserLoginname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponseAllOf {\n");
            sb.Append("  pkiUserID: ").Append(pkiUserID).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  eUserType: ").Append(eUserType).Append("\n");
            sb.Append("  sUserFirstname: ").Append(sUserFirstname).Append("\n");
            sb.Append("  sUserLastname: ").Append(sUserLastname).Append("\n");
            sb.Append("  sUserLoginname: ").Append(sUserLoginname).Append("\n");
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
            return this.Equals(input as UserResponseAllOf);
        }

        /// <summary>
        /// Returns true if UserResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.pkiUserID == input.pkiUserID ||
                    (this.pkiUserID != null &&
                    this.pkiUserID.Equals(input.pkiUserID))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    (this.fkiLanguageID != null &&
                    this.fkiLanguageID.Equals(input.fkiLanguageID))
                ) && 
                (
                    this.eUserType == input.eUserType ||
                    (this.eUserType != null &&
                    this.eUserType.Equals(input.eUserType))
                ) && 
                (
                    this.sUserFirstname == input.sUserFirstname ||
                    (this.sUserFirstname != null &&
                    this.sUserFirstname.Equals(input.sUserFirstname))
                ) && 
                (
                    this.sUserLastname == input.sUserLastname ||
                    (this.sUserLastname != null &&
                    this.sUserLastname.Equals(input.sUserLastname))
                ) && 
                (
                    this.sUserLoginname == input.sUserLoginname ||
                    (this.sUserLoginname != null &&
                    this.sUserLoginname.Equals(input.sUserLoginname))
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
                if (this.pkiUserID != null)
                    hashCode = hashCode * 59 + this.pkiUserID.GetHashCode();
                if (this.fkiLanguageID != null)
                    hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.eUserType != null)
                    hashCode = hashCode * 59 + this.eUserType.GetHashCode();
                if (this.sUserFirstname != null)
                    hashCode = hashCode * 59 + this.sUserFirstname.GetHashCode();
                if (this.sUserLastname != null)
                    hashCode = hashCode * 59 + this.sUserLastname.GetHashCode();
                if (this.sUserLoginname != null)
                    hashCode = hashCode * 59 + this.sUserLoginname.GetHashCode();
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

            
            // fkiLanguageID (int) maximum
            if(this.fkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value less than or equal to 2.", new [] { "fkiLanguageID" });
            }

            // fkiLanguageID (int) minimum
            if(this.fkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value greater than or equal to 1.", new [] { "fkiLanguageID" });
            }

            yield break;
        }
    }

}
