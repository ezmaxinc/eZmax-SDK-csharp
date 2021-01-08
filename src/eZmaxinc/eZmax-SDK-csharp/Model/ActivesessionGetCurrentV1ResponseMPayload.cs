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
    /// Payload for the /1/object/activesession/getCurrent API Request
    /// </summary>
    [DataContract]
    public partial class ActivesessionGetCurrentV1ResponseMPayload :  IEquatable<ActivesessionGetCurrentV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// The type of session used for the API request call
        /// </summary>
        /// <value>The type of session used for the API request call</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EActivesessionSessiontypeEnum
        {
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1

        }

        /// <summary>
        /// The type of session used for the API request call
        /// </summary>
        /// <value>The type of session used for the API request call</value>
        [DataMember(Name="eActivesessionSessiontype", EmitDefaultValue=true)]
        public EActivesessionSessiontypeEnum eActivesessionSessiontype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGetCurrentV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivesessionGetCurrentV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGetCurrentV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="sCustomerCode">The customer code specific to the client in which the API request is being made (required).</param>
        /// <param name="eActivesessionSessiontype">The type of session used for the API request call (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sCompanyNameX">The name of the active Company in the current language (required).</param>
        /// <param name="sDepartmentNameX">The name of the active Department in the current language (required).</param>
        /// <param name="aRegisteredModules">An Array of Registered modules.  These are the modules that are Licensed to be used by the User or the API Key. (required).</param>
        /// <param name="aPermissions">An array of permissions granted to the user or api key (required).</param>
        public ActivesessionGetCurrentV1ResponseMPayload(string sCustomerCode = default(string), EActivesessionSessiontypeEnum eActivesessionSessiontype = default(EActivesessionSessiontypeEnum), int fkiLanguageID = default(int), string sCompanyNameX = default(string), string sDepartmentNameX = default(string), List<string> aRegisteredModules = default(List<string>), List<int> aPermissions = default(List<int>))
        {
            // to ensure "sCustomerCode" is required (not null)
            if (sCustomerCode == null)
            {
                throw new InvalidDataException("sCustomerCode is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.sCustomerCode = sCustomerCode;
            }
            
            // to ensure "eActivesessionSessiontype" is required (not null)
            if (eActivesessionSessiontype == null)
            {
                throw new InvalidDataException("eActivesessionSessiontype is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.eActivesessionSessiontype = eActivesessionSessiontype;
            }
            
            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.fkiLanguageID = fkiLanguageID;
            }
            
            // to ensure "sCompanyNameX" is required (not null)
            if (sCompanyNameX == null)
            {
                throw new InvalidDataException("sCompanyNameX is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.sCompanyNameX = sCompanyNameX;
            }
            
            // to ensure "sDepartmentNameX" is required (not null)
            if (sDepartmentNameX == null)
            {
                throw new InvalidDataException("sDepartmentNameX is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.sDepartmentNameX = sDepartmentNameX;
            }
            
            // to ensure "aRegisteredModules" is required (not null)
            if (aRegisteredModules == null)
            {
                throw new InvalidDataException("aRegisteredModules is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.a_RegisteredModules = aRegisteredModules;
            }
            
            // to ensure "aPermissions" is required (not null)
            if (aPermissions == null)
            {
                throw new InvalidDataException("aPermissions is a required property for ActivesessionGetCurrentV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.a_Permissions = aPermissions;
            }
            
        }
        
        /// <summary>
        /// The customer code specific to the client in which the API request is being made
        /// </summary>
        /// <value>The customer code specific to the client in which the API request is being made</value>
        [DataMember(Name="sCustomerCode", EmitDefaultValue=true)]
        public string sCustomerCode { get; set; }


        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The name of the active Company in the current language
        /// </summary>
        /// <value>The name of the active Company in the current language</value>
        [DataMember(Name="sCompanyNameX", EmitDefaultValue=true)]
        public string sCompanyNameX { get; set; }

        /// <summary>
        /// The name of the active Department in the current language
        /// </summary>
        /// <value>The name of the active Department in the current language</value>
        [DataMember(Name="sDepartmentNameX", EmitDefaultValue=true)]
        public string sDepartmentNameX { get; set; }

        /// <summary>
        /// An Array of Registered modules.  These are the modules that are Licensed to be used by the User or the API Key.
        /// </summary>
        /// <value>An Array of Registered modules.  These are the modules that are Licensed to be used by the User or the API Key.</value>
        [DataMember(Name="a_RegisteredModules", EmitDefaultValue=true)]
        public List<string> a_RegisteredModules { get; set; }

        /// <summary>
        /// An array of permissions granted to the user or api key
        /// </summary>
        /// <value>An array of permissions granted to the user or api key</value>
        [DataMember(Name="a_Permissions", EmitDefaultValue=true)]
        public List<int> a_Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivesessionGetCurrentV1ResponseMPayload {\n");
            sb.Append("  sCustomerCode: ").Append(sCustomerCode).Append("\n");
            sb.Append("  eActivesessionSessiontype: ").Append(eActivesessionSessiontype).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sCompanyNameX: ").Append(sCompanyNameX).Append("\n");
            sb.Append("  sDepartmentNameX: ").Append(sDepartmentNameX).Append("\n");
            sb.Append("  a_RegisteredModules: ").Append(a_RegisteredModules).Append("\n");
            sb.Append("  a_Permissions: ").Append(a_Permissions).Append("\n");
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
            return this.Equals(input as ActivesessionGetCurrentV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if ActivesessionGetCurrentV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivesessionGetCurrentV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivesessionGetCurrentV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sCustomerCode == input.sCustomerCode ||
                    (this.sCustomerCode != null &&
                    this.sCustomerCode.Equals(input.sCustomerCode))
                ) && 
                (
                    this.eActivesessionSessiontype == input.eActivesessionSessiontype ||
                    (this.eActivesessionSessiontype != null &&
                    this.eActivesessionSessiontype.Equals(input.eActivesessionSessiontype))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    (this.fkiLanguageID != null &&
                    this.fkiLanguageID.Equals(input.fkiLanguageID))
                ) && 
                (
                    this.sCompanyNameX == input.sCompanyNameX ||
                    (this.sCompanyNameX != null &&
                    this.sCompanyNameX.Equals(input.sCompanyNameX))
                ) && 
                (
                    this.sDepartmentNameX == input.sDepartmentNameX ||
                    (this.sDepartmentNameX != null &&
                    this.sDepartmentNameX.Equals(input.sDepartmentNameX))
                ) && 
                (
                    this.a_RegisteredModules == input.a_RegisteredModules ||
                    this.a_RegisteredModules != null &&
                    input.a_RegisteredModules != null &&
                    this.a_RegisteredModules.SequenceEqual(input.a_RegisteredModules)
                ) && 
                (
                    this.a_Permissions == input.a_Permissions ||
                    this.a_Permissions != null &&
                    input.a_Permissions != null &&
                    this.a_Permissions.SequenceEqual(input.a_Permissions)
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
                if (this.sCustomerCode != null)
                    hashCode = hashCode * 59 + this.sCustomerCode.GetHashCode();
                if (this.eActivesessionSessiontype != null)
                    hashCode = hashCode * 59 + this.eActivesessionSessiontype.GetHashCode();
                if (this.fkiLanguageID != null)
                    hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sCompanyNameX != null)
                    hashCode = hashCode * 59 + this.sCompanyNameX.GetHashCode();
                if (this.sDepartmentNameX != null)
                    hashCode = hashCode * 59 + this.sDepartmentNameX.GetHashCode();
                if (this.a_RegisteredModules != null)
                    hashCode = hashCode * 59 + this.a_RegisteredModules.GetHashCode();
                if (this.a_Permissions != null)
                    hashCode = hashCode * 59 + this.a_Permissions.GetHashCode();
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
